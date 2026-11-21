namespace WizClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NUD_Cps               = new System.Windows.Forms.NumericUpDown();
            this.label1                = new System.Windows.Forms.Label();
            this.B_Confirm             = new System.Windows.Forms.Button();
            this.B_FireKeyListen       = new System.Windows.Forms.Button();
            this.B_SimKeyListen        = new System.Windows.Forms.Button();
            this.ToolsBar_Close        = new System.Windows.Forms.Button();
            this.ToolsBar_Informations = new System.Windows.Forms.Button();
            this.ToolsBar_Reduce       = new System.Windows.Forms.Button();
            this.Custom_ToolsBar       = new System.Windows.Forms.Panel();
            this.label3                = new System.Windows.Forms.Label();
            this.Lb_FireKey            = new System.Windows.Forms.Label();
            this.label2                = new System.Windows.Forms.Label();
            this.Lb_SimKey             = new System.Windows.Forms.Label();
            this.LB_ToggleMod          = new System.Windows.Forms.Label();
            this.CB_ToggleMod          = new System.Windows.Forms.CheckBox();
            this.LB_ConfirmMessage     = new System.Windows.Forms.Label();
            this.LB_SimulationState    = new System.Windows.Forms.Label();
            this.TT_Default            = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_Main            = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // NUD_Cps
            // 
            this.NUD_Cps.Anchor                                  =  ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Cps.Font                                    =  new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Cps.Location                                =  new System.Drawing.Point(234, 160);
            this.NUD_Cps.Maximum                                 =  new decimal(new int[] { 300, 0, 0, 0 });
            this.NUD_Cps.Name                                    =  "NUD_Cps";
            this.NUD_Cps.Size                                    =  new System.Drawing.Size(70, 22);
            this.NUD_Cps.TabIndex                                =  1;
            this.NUD_Cps.TextAlign                               =  System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Cps.Value                                   =  new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Anchor                                   =  ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize                                 =  true;
            this.label1.BackColor                                =  System.Drawing.Color.Transparent;
            this.label1.Font                                     =  new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.Location                                 =  new System.Drawing.Point(58, 136);
            this.label1.Name                                     =  "label1";
            this.label1.Size                                     =  new System.Drawing.Size(111, 15);
            this.label1.TabIndex                                 =  1;
            this.label1.Text                                     =  "Touche simulé";
            // 
            // B_Confirm
            // 
            this.B_Confirm.BackColor                             =  System.Drawing.Color.Silver;
            this.B_Confirm.BackgroundImageLayout                 =  System.Windows.Forms.ImageLayout.None;
            this.B_Confirm.DialogResult                          =  System.Windows.Forms.DialogResult.Cancel;
            this.B_Confirm.FlatAppearance.BorderSize             =  0;
            this.B_Confirm.FlatAppearance.MouseDownBackColor     =  System.Drawing.Color.Gainsboro;
            this.B_Confirm.FlatAppearance.MouseOverBackColor     =  System.Drawing.Color.DarkGray;
            this.B_Confirm.FlatStyle                             =  System.Windows.Forms.FlatStyle.Flat;
            this.B_Confirm.Font                                  =  new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Confirm.Location                              =  new System.Drawing.Point(136, 353);
            this.B_Confirm.Name                                  =  "B_Confirm";
            this.B_Confirm.Size                                  =  new System.Drawing.Size(128, 30);
            this.B_Confirm.TabIndex                              =  3;
            this.B_Confirm.Text                                  =  "Enregistrer";
            this.B_Confirm.UseVisualStyleBackColor               =  false;
            this.B_Confirm.Click                                 += new System.EventHandler(this.B_Confirm_Click);
            // 
            // B_FireKeyListen
            // 
            this.B_FireKeyListen.Location                        =  new System.Drawing.Point(213, 266);
            this.B_FireKeyListen.Name                            =  "B_FireKeyListen";
            this.B_FireKeyListen.Size                            =  new System.Drawing.Size(24, 23);
            this.B_FireKeyListen.TabIndex                        =  2;
            this.B_FireKeyListen.Text                            =  "✏️";
            this.B_FireKeyListen.UseVisualStyleBackColor         =  true;
            this.B_FireKeyListen.Click                           += new System.EventHandler(this.B_FireKeyListen_Click);
            // 
            // B_SimKeyListen
            // 
            this.B_SimKeyListen.Location                         =  new System.Drawing.Point(126, 159);
            this.B_SimKeyListen.Name                             =  "B_SimKeyListen";
            this.B_SimKeyListen.Size                             =  new System.Drawing.Size(24, 23);
            this.B_SimKeyListen.TabIndex                         =  0;
            this.B_SimKeyListen.Text                             =  "✏️";
            this.B_SimKeyListen.UseVisualStyleBackColor          =  true;
            this.B_SimKeyListen.Click                            += new System.EventHandler(this.B_SimKeyListen_Click);
            // 
            // ToolsBar_Close
            // 
            this.ToolsBar_Close.BackColor                        =  System.Drawing.Color.Transparent;
            this.ToolsBar_Close.BackgroundImage                  =  global::WizClicker.Properties.Resources.Main_close;
            this.ToolsBar_Close.FlatAppearance.BorderSize        =  0;
            this.ToolsBar_Close.FlatStyle                        =  System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Close.ForeColor                        =  System.Drawing.Color.Transparent;
            this.ToolsBar_Close.Location                         =  new System.Drawing.Point(344, 2);
            this.ToolsBar_Close.Name                             =  "ToolsBar_Close";
            this.ToolsBar_Close.Size                             =  new System.Drawing.Size(49, 27);
            this.ToolsBar_Close.TabIndex                         =  6;
            this.ToolsBar_Close.UseVisualStyleBackColor          =  false;
            this.ToolsBar_Close.Click                            += new System.EventHandler(this.ToolsBar_Close_Click);
            this.ToolsBar_Close.MouseEnter                       += new System.EventHandler(this.ToolsBar_Close_MouseEnter);
            this.ToolsBar_Close.MouseLeave                       += new System.EventHandler(this.ToolsBar_Close_MouseLeave);
            // 
            // ToolsBar_Informations
            // 
            this.ToolsBar_Informations.BackColor                 =  System.Drawing.Color.Transparent;
            this.ToolsBar_Informations.BackgroundImage           =  global::WizClicker.Properties.Resources.Main_informations;
            this.ToolsBar_Informations.FlatAppearance.BorderSize =  0;
            this.ToolsBar_Informations.FlatStyle                 =  System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Informations.Location                  =  new System.Drawing.Point(282, 2);
            this.ToolsBar_Informations.Name                      =  "ToolsBar_Informations";
            this.ToolsBar_Informations.Size                      =  new System.Drawing.Size(34, 27);
            this.ToolsBar_Informations.TabIndex                  =  4;
            this.ToolsBar_Informations.UseVisualStyleBackColor   =  false;
            this.ToolsBar_Informations.Click                     += new System.EventHandler(this.ToolsBar_Information_Click);
            this.ToolsBar_Informations.MouseEnter                += new System.EventHandler(this.ToolsBar_Information_MouseEnter);
            this.ToolsBar_Informations.MouseLeave                += new System.EventHandler(this.ToolsBar_Information_MouseLeave);
            // 
            // ToolsBar_Reduce
            // 
            this.ToolsBar_Reduce.BackColor                       =  System.Drawing.Color.Transparent;
            this.ToolsBar_Reduce.BackgroundImage                 =  global::WizClicker.Properties.Resources.Main_reduce;
            this.ToolsBar_Reduce.FlatAppearance.BorderSize       =  0;
            this.ToolsBar_Reduce.FlatStyle                       =  System.Windows.Forms.FlatStyle.Flat;
            this.ToolsBar_Reduce.Location                        =  new System.Drawing.Point(313, 2);
            this.ToolsBar_Reduce.Name                            =  "ToolsBar_Reduce";
            this.ToolsBar_Reduce.Size                            =  new System.Drawing.Size(34, 27);
            this.ToolsBar_Reduce.TabIndex                        =  5;
            this.ToolsBar_Reduce.UseVisualStyleBackColor         =  false;
            this.ToolsBar_Reduce.Click                           += new System.EventHandler(this.ToolsBar_Reduce_Click);
            this.ToolsBar_Reduce.MouseEnter                      += new System.EventHandler(this.ToolsBar_Reduce_MouseEnter);
            this.ToolsBar_Reduce.MouseLeave                      += new System.EventHandler(this.ToolsBar_Reduce_MouseLeave);
            // 
            // Custom_ToolsBar
            // 
            this.Custom_ToolsBar.BackColor                       =  System.Drawing.Color.Transparent;
            this.Custom_ToolsBar.Dock                            =  System.Windows.Forms.DockStyle.Top;
            this.Custom_ToolsBar.Location                        =  new System.Drawing.Point(0, 0);
            this.Custom_ToolsBar.Name                            =  "Custom_ToolsBar";
            this.Custom_ToolsBar.Size                            =  new System.Drawing.Size(400, 38);
            this.Custom_ToolsBar.TabIndex                        =  11;
            this.Custom_ToolsBar.MouseDown                       += new System.Windows.Forms.MouseEventHandler(this.Custom_ToolsBar_MouseDown);
            this.Custom_ToolsBar.MouseMove                       += new System.Windows.Forms.MouseEventHandler(this.Custom_ToolsBar_MouseMove);
            this.Custom_ToolsBar.MouseUp                         += new System.Windows.Forms.MouseEventHandler(this.Custom_ToolsBar_MouseUp);
            // 
            // label3
            // 
            this.label3.Anchor                                   =  ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize                                 =  true;
            this.label3.BackColor                                =  System.Drawing.Color.Transparent;
            this.label3.Font                                     =  new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label3.Location                                 =  new System.Drawing.Point(253, 136);
            this.label3.Name                                     =  "label3";
            this.label3.Size                                     =  new System.Drawing.Size(31, 15);
            this.label3.TabIndex                                 =  1;
            this.label3.Text                                     =  "CPS";
            // 
            // Lb_FireKey
            // 
            this.Lb_FireKey.BackColor                            =  System.Drawing.Color.Transparent;
            this.Lb_FireKey.FlatStyle                            =  System.Windows.Forms.FlatStyle.Flat;
            this.Lb_FireKey.Font                                 =  new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Lb_FireKey.Location                             =  new System.Drawing.Point(64, 269);
            this.Lb_FireKey.Name                                 =  "Lb_FireKey";
            this.Lb_FireKey.Size                                 =  new System.Drawing.Size(145, 19);
            this.Lb_FireKey.TabIndex                             =  14;
            this.Lb_FireKey.Text                                 =  "{FireKey}";
            this.Lb_FireKey.TextAlign                            =  System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor                                   =  ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize                                 =  true;
            this.label2.BackColor                                =  System.Drawing.Color.Transparent;
            this.label2.Font                                     =  new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor                                =  System.Drawing.SystemColors.ControlText;
            this.label2.Location                                 =  new System.Drawing.Point(122, 245);
            this.label2.Name                                     =  "label2";
            this.label2.Size                                     =  new System.Drawing.Size(159, 15);
            this.label2.TabIndex                                 =  1;
            this.label2.Text                                     =  "Touche d\'activation";
            // 
            // Lb_SimKey
            // 
            this.Lb_SimKey.BackColor                             =  System.Drawing.Color.Transparent;
            this.Lb_SimKey.FlatStyle                             =  System.Windows.Forms.FlatStyle.Flat;
            this.Lb_SimKey.Font                                  =  new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Lb_SimKey.Location                              =  new System.Drawing.Point(-11, 162);
            this.Lb_SimKey.Name                                  =  "Lb_SimKey";
            this.Lb_SimKey.Size                                  =  new System.Drawing.Size(133, 19);
            this.Lb_SimKey.TabIndex                              =  16;
            this.Lb_SimKey.Text                                  =  "{SimKey}";
            this.Lb_SimKey.TextAlign                             =  System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_ToggleMod
            // 
            this.LB_ToggleMod.BackColor                          =  System.Drawing.Color.Transparent;
            this.LB_ToggleMod.Font                               =  new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.LB_ToggleMod.Location                           =  new System.Drawing.Point(227, 187);
            this.LB_ToggleMod.Name                               =  "LB_ToggleMod";
            this.LB_ToggleMod.Size                               =  new System.Drawing.Size(134, 17);
            this.LB_ToggleMod.TabIndex                           =  18;
            this.LB_ToggleMod.Text                               =  "Mode maintien";
            // 
            // CB_ToggleMod
            // 
            this.CB_ToggleMod.BackColor                          =  System.Drawing.Color.Transparent;
            this.CB_ToggleMod.Location                           =  new System.Drawing.Point(210, 186);
            this.CB_ToggleMod.Name                               =  "CB_ToggleMod";
            this.CB_ToggleMod.Size                               =  new System.Drawing.Size(21, 17);
            this.CB_ToggleMod.TabIndex                           =  19;
            this.CB_ToggleMod.Text                               =  "CB_ToggleMod";
            this.CB_ToggleMod.UseVisualStyleBackColor            =  false;
            // 
            // LB_ConfirmMessage
            // 
            this.LB_ConfirmMessage.BackColor                     =  System.Drawing.Color.Transparent;
            this.LB_ConfirmMessage.Font                          =  new System.Drawing.Font("Unispace", 8.749999F, System.Drawing.FontStyle.Bold);
            this.LB_ConfirmMessage.Location                      =  new System.Drawing.Point(115, 321);
            this.LB_ConfirmMessage.Name                          =  "LB_ConfirmMessage";
            this.LB_ConfirmMessage.Size                          =  new System.Drawing.Size(166, 29);
            this.LB_ConfirmMessage.TabIndex                      =  20;
            this.LB_ConfirmMessage.Text                          =  "Placeholder";
            this.LB_ConfirmMessage.TextAlign                     =  System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_SimulationState
            // 
            this.LB_SimulationState.BackColor                    =  System.Drawing.Color.Transparent;
            this.LB_SimulationState.Font                         =  new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold);
            this.LB_SimulationState.Location                     =  new System.Drawing.Point(115, 292);
            this.LB_SimulationState.Name                         =  "LB_SimulationState";
            this.LB_SimulationState.Size                         =  new System.Drawing.Size(166, 29);
            this.LB_SimulationState.TabIndex                     =  21;
            this.LB_SimulationState.Text                         =  "Placeholder";
            this.LB_SimulationState.TextAlign                    =  System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Main
            // 
            this.Timer_Main.Enabled                              =  true;
            this.Timer_Main.Interval                             =  50D;
            this.Timer_Main.SynchronizingObject                  =  this;
            this.Timer_Main.Elapsed                              += new System.Timers.ElapsedEventHandler(this.TM_FireKeyWaiting_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions                             =  new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode                                   =  System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate                                    =  System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor                                       =  System.Drawing.SystemColors.Control;
            this.BackgroundImage                                 =  global::WizClicker.Properties.Resources.Main;
            this.ClientSize                                      =  new System.Drawing.Size(400, 400);
            this.ControlBox                                      =  false;
            this.Controls.Add(this.LB_SimulationState);
            this.Controls.Add(this.LB_ConfirmMessage);
            this.Controls.Add(this.CB_ToggleMod);
            this.Controls.Add(this.LB_ToggleMod);
            this.Controls.Add(this.B_SimKeyListen);
            this.Controls.Add(this.Lb_SimKey);
            this.Controls.Add(this.B_FireKeyListen);
            this.Controls.Add(this.Lb_FireKey);
            this.Controls.Add(this.ToolsBar_Reduce);
            this.Controls.Add(this.ToolsBar_Close);
            this.Controls.Add(this.ToolsBar_Informations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUD_Cps);
            this.Controls.Add(this.B_Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Custom_ToolsBar);
            this.FormBorderStyle =  System.Windows.Forms.FormBorderStyle.None;
            this.Icon            =  ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location        =  new System.Drawing.Point(15, 15);
            this.Name            =  "MainForm";
            this.Load            += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timer_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Timers.Timer Timer_Main;

        private System.Windows.Forms.ToolTip TT_Default;

        private System.Windows.Forms.Label LB_ConfirmMessage;

        private System.Windows.Forms.Label LB_SimulationState;

        private System.Windows.Forms.CheckBox CB_ToggleMod;

        private System.Windows.Forms.Label LB_ToggleMod;

        private System.Windows.Forms.Button B_SimKeyListen;
        private System.Windows.Forms.Label Lb_SimKey;

        private System.Windows.Forms.Label  Lb_FireKey;
        private System.Windows.Forms.Button B_FireKeyListen;

#endregion

        private System.Windows.Forms.NumericUpDown NUD_Cps;
        private System.Windows.Forms.Label         label1;
        private System.Windows.Forms.Label         label2;
        private System.Windows.Forms.Button        B_Confirm;
        private System.Windows.Forms.Button        ToolsBar_Close;
        private System.Windows.Forms.Button        ToolsBar_Informations;
        private System.Windows.Forms.Button        ToolsBar_Reduce;
        private System.Windows.Forms.Panel         Custom_ToolsBar;
        private System.Windows.Forms.Label         label3;
    }
}

