using ProgressQuest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static ProgressQuest.GameStrings;

namespace ProgressQuest
{
    public class GameState
    {
        public Player Player { get; set; }
        public string Location { get; set; }
        public bool IsRunning { get; set; }
        public int IntroStepsLeft { get; set; }



        /// <summary>
        /// constructor
        /// </summary>
        public GameState()
        {
            Player = new Player();
            IsRunning = true;
            IntroStepsLeft = INTRO_STEPS.Length;
        }


    }
}
