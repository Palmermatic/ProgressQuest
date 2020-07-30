using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProgressQuest.GameManager;
using static ProgressQuest.GameStrings;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProgressQuest
{
    public partial class GameUI : Form
    {
        public GameUI()
        {
            InitializeComponent();

            // initialize player
            NewGame();
            foreach (var stat in Enum.GetValues(typeof(STARTING_PLAYER_STAT)))
            {
                var s = new PlayerStat(stat.ToString());
                AddPlayerStat(s);
            }

            // bind all the UI controls
            actionBar.DataBindings.Add("Maximum", GameManager.Log, "TicksRequired");
            adventureCheckbox.DataBindings.Add(new Binding("Checked", State.IsRunning, ""));
            gameLogListBox.DataSource = GameManager.Log.Log;
            gameLogListBox.SelectedIndexChanged += new EventHandler(SelectLastLog);

            // player
            dmgMinLabel.DataBindings.Add("Text", State.Player, "DmgMin");
            dmgMaxLabel.DataBindings.Add("Text", State.Player, "DmgMax");
            hpBar.DataBindings.Add("Value", State.Player, "HPPercent");
            hpLabel.DataBindings.Add("Text", State.Player, "HPLabel");
            playerNameLabel.DataBindings.Add("Text", State.Player, "Name");
            cashLabel.DataBindings.Add("Text", State.Player, "Cash");
            inventoryListBox.DataSource = State.Player.Inventory;
            equipmentListBox.DataSource = State.Player.Equipment;

            // enemy
            enemyHPBar.DataBindings.Add("Value", State.Enemy, "HPPercent");
            enemyHPLabel.DataBindings.Add("Text", State.Enemy, "HPLabel");
            enemyNameLabel.DataBindings.Add("Text", State.Enemy, "Name");
            enemyLevelLabel.DataBindings.Add("Text", State.Enemy, "Level");
            enemyMinDmgLabel.DataBindings.Add("Text", State.Enemy, "DmgMin");
            enemyMaxDmgLabel.DataBindings.Add("Text", State.Enemy, "DmgMax");

            locationLabel.DataBindings.Add("Text", State.QuestLog, "Location");
            questBar.DataBindings.Add("Value", State.QuestLog, "CurrentQuestPercent");
            questLogListBox.DataSource = State.QuestLog.Quests;
            questLogListBox.DisplayMember = "Text";
        }

        private void SelectLastLog(object sender, EventArgs e)
        {
            //TODO this doesn't fire until the quest log is clicked. need it to fire on form load
            equipmentListBox.SelectedIndex = State.Player.LastEquipped;
            gameLogListBox.SelectedIndex = 0;

            for (int i = 0; i < questLogListBox.Items.Count; ++i)
            {
                questLogListBox.SetItemChecked(i, ((Models.UI.QuestLog.Quest)questLogListBox.Items[i]).IsChecked);
            }
            questLogListBox.SelectedIndex = questLogListBox.Items.Count - 1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO ask to save
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO pause game
            //TODO serialize gamestate to file
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO ask to save
            //TODO deserialize file to gamestate
        }

        public void AddPlayerStat(PlayerStat stat)
        {
            State.Player.Stats.Add(stat.Name, stat);

            var yCoord = 10 * statsBox.Controls.Count + 25;

            var label = new Label
            {
                Name = stat.Name + "Label",
                Text = stat.Name,
                Location = new Point(20, yCoord),
                AutoSize = true
            };
            statsBox.Controls.Add(label);

            var value = new Label
            {
                Name = stat.Name + "Value",
                Location = new Point(80, yCoord),
                AutoSize = true
            };
            value.DataBindings.Add("Text", stat, "Value");
            statsBox.Controls.Add(value);

            var xpBar = new ProgressBar
            {
                Name = stat.Name + "XP",
                Location = new Point(120, yCoord),
                Size = new Size(90, 17),
                Minimum = 0,
                Maximum = 100,
                Step = 1,
                Style = ProgressBarStyle.Continuous,
                MarqueeAnimationSpeed = 0
            };
            xpBar.DataBindings.Add("Value", stat, "XPPercent");
            statsBox.Controls.Add(xpBar);

            var xpTip = new ToolTip();
            xpTip.SetToolTip(xpBar, stat.CurrentXP + " / " + stat.NextLevel);
        }

        private void actionTimer_Tick(object sender, EventArgs e)
        {
            if (actionBar.Value >= actionBar.Maximum)
            {
                actionBar.Value = 0;

                Tick();
            }
            else
            {
                actionBar.PerformStep();
            }

        }

        private void adventureCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (adventureCheckbox.Checked)
            {
                actionTimer.Start();
            }
            else
            {
                actionTimer.Stop();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new AboutBox1(JsonSerializer.Serialize(State));
            a.ShowDialog();
        }
    }
}
