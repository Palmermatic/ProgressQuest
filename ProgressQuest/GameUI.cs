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
using static ProgressQuest.QuestLog;

namespace ProgressQuest
{
    public partial class GameUI : Form
    {
        public GameUI()
        {
            InitializeComponent();
            GameManager.NewGame();
            foreach (var statName in STARTING_PLAYER_STATS)
            {
                var s = new PlayerStat(statName);
                AddPlayerStat(s);
            }
            adventureCheckbox.DataBindings.Add(new Binding("Checked", State, "IsRunning"));
            QuestLog.DataSource = GameManager.QuestLog.Log;
            QuestLog.SelectedIndexChanged += new EventHandler(SelectLastLog);
        }

        private void SelectLastLog(object sender, EventArgs e)
        {
            QuestLog.SelectedIndex = 0;
            //TODO this doesn't fire until the box is clicked
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pause game
            // serialize gamestate to file
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ask to save
            // deserialize file to gamestate
        }

        public void AddPlayerStat(PlayerStat stat)
        {
            State.Stats.Add(stat.Name, stat);

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
            value.DataBindings.Add("Text", stat, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
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
            xpBar.DataBindings.Add("Value", stat, "XPPercent", false, DataSourceUpdateMode.OnPropertyChanged);
            statsBox.Controls.Add(xpBar);

            var xpTip = new ToolTip();
            xpTip.SetToolTip(xpBar, stat.CurrentXP + " / " + stat.NextLevel);
        }

        private void actionTimer_Tick(object sender, EventArgs e)
        {
            if (actionBar.Value >= actionBar.Maximum)
            {
                Tick();
                actionBar.Value = 0;
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
    }
}
