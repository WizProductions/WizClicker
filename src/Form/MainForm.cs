using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsInput; // InputSimulatorPlus2 - NuGet package 1.0.9

namespace WizClicker
{
//#############################################################################
//##--------------------------------- CLASS ---------------------------------##
//#############################################################################

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        MyKeyListener    = new KeyListener();
        MyInputSimulator = new InputSimulator();

        MyKeyListener.OnListeningStoppedEvent += OnKeyListenerStopListen;

        NUD_Cps.Maximum         = WAppSettings.MaxCps;
        LB_SimulationState.Text = "";
        LB_ConfirmMessage.Text       = "";
        TT_Default.SetToolTip(B_FireKeyListen, WLoc.ToolTip_FireKey);
        TT_Default.SetToolTip(B_SimKeyListen, WLoc.ToolTip_SimKey);
        TT_Default.SetToolTip(B_Confirm, WLoc.ToolTip_Confirm);
    }

//#############################################################################
//##--------------------------------- FIELDS --------------------------------##
//#############################################################################

    private Keys _FireKey;

    public Keys FireKey
    {
        get => _FireKey;
        set
        {
            _FireKey        = value;
            Lb_FireKey.Text = GetTextFromKey(value);
        }
    }

    private Keys _SimKey;

    public Keys SimKey
    {
        get => _SimKey;
        set
        {
            _SimKey        = value;
            Lb_SimKey.Text = GetTextFromKey(value);
        }
    }

    public  int            ClickTickRate;
    private bool           bIsFireKeyDown;
    private bool           bIsWaitingFireKey;
    private bool           bIsWaitingSimKey;
    private KeyListener    MyKeyListener;
    private InputSimulator MyInputSimulator;
    private Thread         SimulationLoopThread;
    private bool           bIsSimulatingStarted;

//==== Custom Toolbar ====\\.
    private bool  bIsDragging;
    private Point DragStartPoint;

//#############################################################################
//##-------------------------------- METHODS --------------------------------##
//#############################################################################

//==== Imported ====\\.
    [DllImport("user32.dll")]
    private static extern short GetAsyncKeyState(int vKey);

//==== Methods ====\\.

#region ToolsBar
    private void Custom_ToolsBar_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            // Capture la position du curseur par rapport à la barre d'outils
            bIsDragging    = true;
            DragStartPoint = e.Location;
        }
    }

    private void Custom_ToolsBar_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            // Stop dragging
            bIsDragging = false;
        }
    }

    private void Custom_ToolsBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (bIsDragging)
        {
            // Calcul du décalage en pixels
            int offsetX = e.X - DragStartPoint.X;
            int offsetY = e.Y - DragStartPoint.Y;
            // Mise à jour de la position du formulaire
            this.Left += offsetX;
            this.Top  += offsetY;
        }
    }

    private void ToolsBar_Close_Click(object sender, EventArgs e)
        => Environment.Exit(0);

    private void ToolsBar_Close_MouseEnter(object sender, EventArgs e)
        => ToolsBar_Close.BackgroundImage = Properties.Resources.Main_close_hover;

    private void ToolsBar_Close_MouseLeave(object sender, EventArgs e)
        => ToolsBar_Close.BackgroundImage = Properties.Resources.Main_close;

    private void ToolsBar_Reduce_Click(object sender, EventArgs e)
        => WindowState = FormWindowState.Minimized;

    private void ToolsBar_Reduce_MouseEnter(object sender, EventArgs e)
        => ToolsBar_Reduce.BackgroundImage = Properties.Resources.Main_reduce_hover;

    private void ToolsBar_Reduce_MouseLeave(object sender, EventArgs e)
        => ToolsBar_Reduce.BackgroundImage = Properties.Resources.Main_reduce;

    private void ToolsBar_Information_MouseEnter(object sender, EventArgs e)
        => ToolsBar_Informations.BackgroundImage = Properties.Resources.Main_informations_hover;

    private void ToolsBar_Information_MouseLeave(object sender, EventArgs e)
        => ToolsBar_Informations.BackgroundImage = Properties.Resources.Main_informations;

    private void ToolsBar_Information_Click(object sender, EventArgs e)
    {
        Form InformationForm = new InformationForm();
        InformationForm.Show();
    }
#endregion // Toolbar

    private void MainForm_Load(object sender, EventArgs e)
    {
        Config.AppConfig ConfigObject = Config.ExtractConfig();

        NUD_Cps.Value        = ConfigObject.Cps;
        FireKey              = ConfigObject.FireKey;
        SimKey               = ConfigObject.SimKey;
        CB_ToggleMod.Checked = ConfigObject.bToggleMod;

        ClickTickRate = (int)Math.Ceiling(1000.0 / ConfigObject.Cps);
    }

    private void B_Confirm_Click(object sender, EventArgs e)
    {
        if ((int)NUD_Cps.Value > 0 && NUD_Cps.Value <= WAppSettings.MaxCps)
        {
            ClickTickRate = (int)Math.Ceiling(1000.0 / (int)NUD_Cps.Value);

            LB_ConfirmMessage.Text      = WLoc.Confirm_Success;
            LB_ConfirmMessage.ForeColor = WAppSettings.ConfirmTextColor_Success;

            Config.UpdateConfig(FireKey, SimKey, (int)NUD_Cps.Value, CB_ToggleMod.Checked);
        }
        else
        {
            LB_ConfirmMessage.Text      = WLoc.Confirm_Failed;
            LB_ConfirmMessage.ForeColor = WAppSettings.ConfirmTextColor_Failed;
        }
    }

    private void TM_FireKeyWaiting_Tick(object sender, EventArgs e)
    {
        if (bIsWaitingFireKey || bIsWaitingSimKey) return;

        // FireKey pressed
        if ((GetAsyncKeyState((int)_FireKey) & 0x8000) != 0)
        {
            // Wait key up to accept a new fire key action. (prevent mass swap state)
            if (bIsFireKeyDown)
            {
                return;
            }

            bIsFireKeyDown       = true;
            bIsSimulatingStarted = !bIsSimulatingStarted;

            if (bIsSimulatingStarted)
            {
                SimulationLoopThread = SimulationLoopThread = new Thread(CB_ToggleMod.Checked
                    ? new ThreadStart(HoldLoop)
                    : new ThreadStart(ClickLoop));
                SimulationLoopThread.IsBackground = true;
                SimulationLoopThread.Start();

                LB_SimulationState.Text      = WLoc.State_Active;
                LB_SimulationState.ForeColor = Color.FromArgb(255, 90, 0);
            }
            else
            {
                if (SimulationLoopThread is { IsAlive: true })
                {
                    // Security
                    SimulationLoopThread.Join(); //Close thread
                }
                
                CancelCurrentStateOfKey();

                LB_SimulationState.Text      = WLoc.State_Inactive;
                LB_SimulationState.ForeColor = Color.FromArgb(255, 200, 0);
            }
            
            Internal_UpdateIconFromSimulation();

            return;
        }

        bIsFireKeyDown = false;
    }

    private void ClickLoop()
    {
        if (IsMouseKey(SimKey))
        {
            // Use this switch expression to optimize the click and avoid switch resolve every tick
            Action ClickMethod = SimKey switch
            {
                Keys.LButton  => () => MyInputSimulator.Mouse.LeftButtonClick(),
                Keys.RButton  => () => MyInputSimulator.Mouse.RightButtonClick(),
                Keys.MButton  => () => MyInputSimulator.Mouse.MiddleButtonClick(),
                Keys.XButton1 => () => MyInputSimulator.Mouse.XButtonClick(1),
                Keys.XButton2 => () => MyInputSimulator.Mouse.XButtonClick(2),
                _             => throw new ArgumentException("Not a mouse key")
            };

            while (bIsSimulatingStarted)
            {
                ClickMethod();
                Thread.Sleep(ClickTickRate);
            }
        }
        else
        {
            while (bIsSimulatingStarted)
            {
                MyInputSimulator.Keyboard.KeyPress((WindowsInput.Native.VirtualKeyCode)SimKey);
                Thread.Sleep(ClickTickRate);
            }
        }
    }

    private void HoldLoop()
    {
        if (IsMouseKey(SimKey))
        {
            // Use this switch expression to optimize the click and avoid switch resolve every tick
            Action HoldMethod = SimKey switch
            {
                Keys.LButton  => () => MyInputSimulator.Mouse.LeftButtonDown(),
                Keys.RButton  => () => MyInputSimulator.Mouse.RightButtonDown(),
                Keys.MButton  => () => MyInputSimulator.Mouse.MiddleButtonDown(),
                Keys.XButton1 => () => MyInputSimulator.Mouse.XButtonDown(1),
                Keys.XButton2 => () => MyInputSimulator.Mouse.XButtonDown(2),
                _             => throw new ArgumentException("Not a mouse key")
            };

            while (bIsSimulatingStarted)
            {
                // Rerun key?
                if ((GetAsyncKeyState((int)SimKey) & 0x8000) == 0)
                {
                    HoldMethod();
                }

                Thread.Sleep(20);
            }
        }
        else
        {
            while (bIsSimulatingStarted)
            {
                // Rerun key?
                if ((GetAsyncKeyState((int)SimKey) & 0x8000) == 0)
                {
                    MyInputSimulator.Keyboard.KeyDown((WindowsInput.Native.VirtualKeyCode)SimKey);
                }

                Thread.Sleep(20);
            }
        }
    }

    private void CancelCurrentStateOfKey()
    {
        if ((GetAsyncKeyState((int)SimKey) & 0x8000) == 0) return;
        
        switch (SimKey)
        {
            case Keys.LButton:
            {
                MyInputSimulator.Mouse.LeftButtonUp();
                return;
            }
            case Keys.RButton:
            {
                MyInputSimulator.Mouse.RightButtonUp();
                return;
            }
            case Keys.MButton:
            {
                MyInputSimulator.Mouse.MiddleButtonUp();
                return;
            }
            case Keys.XButton1:
            {
                MyInputSimulator.Mouse.XButtonUp(1);
                return;
            }
            case Keys.XButton2:
            {
                MyInputSimulator.Mouse.XButtonUp(2);
                return;
            }
            default:
            {
                MyInputSimulator.Keyboard.KeyUp((WindowsInput.Native.VirtualKeyCode)SimKey);
                break;
            }
        }
    }

    private string GetTextFromKey(Keys Key)
    {
        return WLoc.KeyNames.TryGetValue(Key, out string KeyName)
            ? KeyName
            : Key.ToString();
    }

    // Called when the key listener just stopped to waiting a key, can contain a key or not
    private void OnKeyListenerStopListen(bool bIsKeyListened, Keys KeyListened)
    {
        if (bIsWaitingFireKey)
        {
            if (bIsKeyListened && KeyListened != SimKey)
            {
                FireKey = KeyListened;
            }
            else
            {
                // Old text
                Lb_FireKey.Text = GetTextFromKey(FireKey);
            }

            bIsWaitingFireKey = false;
        }
        else if (bIsWaitingSimKey)
        {
            if (bIsKeyListened && KeyListened != FireKey)
            {
                SimKey = KeyListened;
            }
            else
            {
                // Old text
                Lb_SimKey.Text = GetTextFromKey(SimKey);
            }

            bIsWaitingSimKey = false;
        }
    }

    private void Internal_UpdateIconFromSimulation()
    {
        if (bIsSimulatingStarted)
        {
            this.Icon = Properties.Resources.SimulationAppIcon;
        }
        else
        {
            this.Icon = Properties.Resources.DefaultAppIcon;
        }
    }

    public static bool IsMouseKey(Keys Key)
        => Key >= Keys.LButton && Key <= Keys.XButton2;

//==== Events ====\\.
    private void B_FireKeyListen_Click(object sender, EventArgs e)
    {
        if (bIsSimulatingStarted) return;

        MyKeyListener.StartListenKey();
        bIsWaitingFireKey = true;

        Lb_FireKey.Text = WLoc.KeyInput_Waiting;
    }

    private void B_SimKeyListen_Click(object sender, EventArgs e)
    {
        if (bIsSimulatingStarted) return;

        MyKeyListener.StartListenKey();
        bIsWaitingSimKey = true;

        Lb_SimKey.Text = WLoc.KeyInput_Waiting;
    }
}
}