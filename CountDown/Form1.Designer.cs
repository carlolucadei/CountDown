namespace CountDown
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbMinutes = new System.Windows.Forms.TextBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TbSeconds = new System.Windows.Forms.TextBox();
            this.doubledot = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaTempoTrascorsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbMinutes
            // 
            this.TbMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMinutes.Location = new System.Drawing.Point(17, 35);
            this.TbMinutes.Multiline = true;
            this.TbMinutes.Name = "TbMinutes";
            this.TbMinutes.Size = new System.Drawing.Size(245, 245);
            this.TbMinutes.TabIndex = 0;
            this.TbMinutes.Text = "05";
            // 
            // pBar
            // 
            this.pBar.BackColor = System.Drawing.SystemColors.Control;
            this.pBar.Location = new System.Drawing.Point(17, 332);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(501, 23);
            this.pBar.TabIndex = 1;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TbSeconds
            // 
            this.TbSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSeconds.Location = new System.Drawing.Point(273, 34);
            this.TbSeconds.Multiline = true;
            this.TbSeconds.Name = "TbSeconds";
            this.TbSeconds.Size = new System.Drawing.Size(245, 245);
            this.TbSeconds.TabIndex = 1;
            this.TbSeconds.Text = "30";
            // 
            // doubledot
            // 
            this.doubledot.AutoSize = true;
            this.doubledot.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubledot.Location = new System.Drawing.Point(242, 107);
            this.doubledot.Name = "doubledot";
            this.doubledot.Size = new System.Drawing.Size(58, 85);
            this.doubledot.TabIndex = 4;
            this.doubledot.Text = ":";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLElapsed,
            this.lElapsedTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLElapsed
            // 
            this.tssLElapsed.Name = "tssLElapsed";
            this.tssLElapsed.Size = new System.Drawing.Size(99, 17);
            this.tssLElapsed.Text = "Tempo trascorso:";
            // 
            // lElapsedTime
            // 
            this.lElapsedTime.Name = "lElapsedTime";
            this.lElapsedTime.Size = new System.Drawing.Size(49, 17);
            this.lElapsedTime.Text = "00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.cancellaTempoTrascorsoToolStripMenuItem,
            this.toolStripSeparator1,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // cancellaTempoTrascorsoToolStripMenuItem
            // 
            this.cancellaTempoTrascorsoToolStripMenuItem.Name = "cancellaTempoTrascorsoToolStripMenuItem";
            this.cancellaTempoTrascorsoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.cancellaTempoTrascorsoToolStripMenuItem.Text = "Cancella Tempo Trascorso";
            this.cancellaTempoTrascorsoToolStripMenuItem.Click += new System.EventHandler(this.cancellaTempoTrascorsoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // Pause
            // 
            this.Pause.Image = global::CountDown.Properties.Resources.pause_32x32;
            this.Pause.Location = new System.Drawing.Point(110, 287);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(40, 40);
            this.Pause.TabIndex = 7;
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.Image = global::CountDown.Properties.Resources.stop_32x32;
            this.Stop.Location = new System.Drawing.Point(63, 286);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(40, 40);
            this.Stop.TabIndex = 3;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.Image = global::CountDown.Properties.Resources.play_32x32;
            this.Play.Location = new System.Drawing.Point(17, 286);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(40, 40);
            this.Play.TabIndex = 2;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TbSeconds);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.TbMinutes);
            this.Controls.Add(this.doubledot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(550, 420);
            this.MinimumSize = new System.Drawing.Size(550, 420);
            this.Name = "Form1";
            this.Text = "RadioIncredibile - Count Down";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbMinutes;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox TbSeconds;
        private System.Windows.Forms.Label doubledot;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssLElapsed;
        private System.Windows.Forms.ToolStripStatusLabel lElapsedTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaTempoTrascorsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.Button Pause;
    }
}

