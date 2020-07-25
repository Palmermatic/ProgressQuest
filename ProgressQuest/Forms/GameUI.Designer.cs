﻿namespace ProgressQuest
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
            this.questLogListBox = new System.Windows.Forms.ListBox();
            this.hpBar = new System.Windows.Forms.ProgressBar();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.cashLabel = new System.Windows.Forms.Label();
            this.cashText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.equipmentListBox = new System.Windows.Forms.ListBox();
            this.gameStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hpLabel = new System.Windows.Forms.Label();
            this.hpText = new System.Windows.Forms.Label();
            this.damageText = new System.Windows.Forms.Label();
            this.dmgMinLabel = new System.Windows.Forms.Label();
            this.dmgMaxLabel = new System.Windows.Forms.Label();
            this.dashText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameStateBindingSource)).BeginInit();
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
            // questLogListBox
            // 
            this.questLogListBox.FormattingEnabled = true;
            this.questLogListBox.Location = new System.Drawing.Point(0, 627);
            this.questLogListBox.Name = "questLogListBox";
            this.questLogListBox.Size = new System.Drawing.Size(632, 95);
            this.questLogListBox.TabIndex = 7;
            // 
            // hpBar
            // 
            this.hpBar.Location = new System.Drawing.Point(48, 475);
            this.hpBar.Name = "hpBar";
            this.hpBar.Size = new System.Drawing.Size(288, 23);
            this.hpBar.Step = 1;
            this.hpBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hpBar.TabIndex = 8;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoEllipsis = true;
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.playerNameLabel.Location = new System.Drawing.Point(44, 24);
            this.playerNameLabel.MaximumSize = new System.Drawing.Size(288, 20);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(45, 20);
            this.playerNameLabel.TabIndex = 9;
            this.playerNameLabel.Text = "noob";
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(20, 42);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(198, 147);
            this.inventoryListBox.TabIndex = 10;
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Location = new System.Drawing.Point(61, 25);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(19, 13);
            this.cashLabel.TabIndex = 11;
            this.cashLabel.Text = "$0";
            // 
            // cashText
            // 
            this.cashText.AutoSize = true;
            this.cashText.Location = new System.Drawing.Point(20, 25);
            this.cashText.Name = "cashText";
            this.cashText.Size = new System.Drawing.Size(34, 13);
            this.cashText.TabIndex = 12;
            this.cashText.Text = "Cash:";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.cashText);
            this.groupBox1.Controls.Add(this.inventoryListBox);
            this.groupBox1.Controls.Add(this.cashLabel);
            this.groupBox1.Location = new System.Drawing.Point(355, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 214);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dashText);
            this.groupBox2.Controls.Add(this.dmgMaxLabel);
            this.groupBox2.Controls.Add(this.dmgMinLabel);
            this.groupBox2.Controls.Add(this.damageText);
            this.groupBox2.Controls.Add(this.equipmentListBox);
            this.groupBox2.Location = new System.Drawing.Point(355, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 226);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment";
            // 
            // equipmentListBox
            // 
            this.equipmentListBox.FormattingEnabled = true;
            this.equipmentListBox.Location = new System.Drawing.Point(20, 29);
            this.equipmentListBox.Name = "equipmentListBox";
            this.equipmentListBox.Size = new System.Drawing.Size(198, 160);
            this.equipmentListBox.TabIndex = 10;
            // 
            // gameStateBindingSource
            // 
            this.gameStateBindingSource.DataSource = typeof(ProgressQuest.GameState);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(178, 481);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(35, 13);
            this.hpLabel.TabIndex = 15;
            this.hpLabel.Text = "label1";
            // 
            // hpText
            // 
            this.hpText.AutoSize = true;
            this.hpText.Location = new System.Drawing.Point(147, 481);
            this.hpText.Name = "hpText";
            this.hpText.Size = new System.Drawing.Size(25, 13);
            this.hpText.TabIndex = 16;
            this.hpText.Text = "HP:";
            // 
            // damageText
            // 
            this.damageText.AutoSize = true;
            this.damageText.Location = new System.Drawing.Point(20, 196);
            this.damageText.Name = "damageText";
            this.damageText.Size = new System.Drawing.Size(50, 13);
            this.damageText.TabIndex = 11;
            this.damageText.Text = "Damage:";
            // 
            // dmgMinLabel
            // 
            this.dmgMinLabel.AutoSize = true;
            this.dmgMinLabel.Location = new System.Drawing.Point(81, 197);
            this.dmgMinLabel.Name = "dmgMinLabel";
            this.dmgMinLabel.Size = new System.Drawing.Size(45, 13);
            this.dmgMinLabel.TabIndex = 12;
            this.dmgMinLabel.Text = "minDmg";
            // 
            // dmgMaxLabel
            // 
            this.dmgMaxLabel.AutoSize = true;
            this.dmgMaxLabel.Location = new System.Drawing.Point(157, 197);
            this.dmgMaxLabel.Name = "dmgMaxLabel";
            this.dmgMaxLabel.Size = new System.Drawing.Size(48, 13);
            this.dmgMaxLabel.TabIndex = 13;
            this.dmgMaxLabel.Text = "maxDmg";
            // 
            // dashText
            // 
            this.dashText.AutoSize = true;
            this.dashText.Location = new System.Drawing.Point(132, 196);
            this.dashText.Name = "dashText";
            this.dashText.Size = new System.Drawing.Size(10, 13);
            this.dashText.TabIndex = 14;
            this.dashText.Text = "-";
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 772);
            this.Controls.Add(this.hpText);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.hpBar);
            this.Controls.Add(this.questLogListBox);
            this.Controls.Add(this.adventureCheckbox);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.actionBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameUI";
            this.Text = "Progress Quest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameStateBindingSource)).EndInit();
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
        public System.Windows.Forms.ListBox questLogListBox;
        private System.Windows.Forms.ProgressBar hpBar;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.BindingSource gameStateBindingSource;
        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label cashText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox equipmentListBox;
        private System.Windows.Forms.Label dmgMinLabel;
        private System.Windows.Forms.Label damageText;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label hpText;
        private System.Windows.Forms.Label dashText;
        private System.Windows.Forms.Label dmgMaxLabel;
    }
}
