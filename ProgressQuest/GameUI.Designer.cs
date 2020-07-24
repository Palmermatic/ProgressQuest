namespace ProgressQuest
{
    public partial class GameUI
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
            this.actionBar = new System.Windows.Forms.ProgressBar();
            this.statsBox = new System.Windows.Forms.GroupBox();
            this.adventureCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionTimer = new System.Windows.Forms.Timer(this.components);
            this.QuestLog = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionBar
            // 
            this.actionBar.Location = new System.Drawing.Point(0, 728);
            this.actionBar.MarqueeAnimationSpeed = 0;
            this.actionBar.Maximum = 4;
            this.actionBar.Name = "actionBar";
            this.actionBar.Size = new System.Drawing.Size(926, 23);
            this.actionBar.Step = 1;
            this.actionBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.actionBar.TabIndex = 0;
            // 
            // statsBox
            // 
            this.statsBox.AutoSize = true;
            this.statsBox.Location = new System.Drawing.Point(48, 54);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(288, 424);
            this.statsBox.TabIndex = 1;
            this.statsBox.TabStop = false;
            this.statsBox.Text = "Character Stats";
            // 
            // adventureCheckbox
            // 
            this.adventureCheckbox.AutoSize = true;
            this.adventureCheckbox.Location = new System.Drawing.Point(814, 705);
            this.adventureCheckbox.Name = "adventureCheckbox";
            this.adventureCheckbox.Size = new System.Drawing.Size(103, 17);
            this.adventureCheckbox.TabIndex = 3;
            this.adventureCheckbox.Text = "Go Adventuring!";
            this.adventureCheckbox.UseVisualStyleBackColor = true;
            this.adventureCheckbox.CheckedChanged += new System.EventHandler(this.adventureCheckbox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionTimer
            // 
            this.actionTimer.Interval = 250;
            this.actionTimer.Tick += new System.EventHandler(this.actionTimer_Tick);
            // 
            // QuestLog
            // 
            this.QuestLog.FormattingEnabled = true;
            this.QuestLog.Location = new System.Drawing.Point(0, 627);
            this.QuestLog.Name = "QuestLog";
            this.QuestLog.Size = new System.Drawing.Size(632, 95);
            this.QuestLog.TabIndex = 7;
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 772);
            this.Controls.Add(this.QuestLog);
            this.Controls.Add(this.adventureCheckbox);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.actionBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameUI";
            this.Text = "Progress Quest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar actionBar;
        private System.Windows.Forms.GroupBox statsBox;
        private System.Windows.Forms.CheckBox adventureCheckbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer actionTimer;
        public System.Windows.Forms.ListBox QuestLog;
    }
}

