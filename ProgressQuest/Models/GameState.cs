using ProgressQuest.Models;
using ProgressQuest.Models.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static ProgressQuest.GameStrings;

namespace ProgressQuest
{
    public class GameState
    {
        public QuestLog QuestLog { get; set; }
        public Player Player { get; set; }
        public Monster Enemy { get; set; }

        public bool IsRunning { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public GameState()
        {
            Player = new Player();
            QuestLog = new QuestLog();
            Enemy = new Monster();
            IsRunning = true;
        }


    }
}
