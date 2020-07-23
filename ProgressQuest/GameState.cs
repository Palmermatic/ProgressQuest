using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static ProgressQuest.GameStrings;

namespace ProgressQuest
{
    public class GameState
    {
        public Dictionary<string, PlayerStat> Stats;
        public bool IsRunning { get; set; }
        public int IntroStepsLeft { get; set; }

        public GameState()
        {
            Stats = new Dictionary<string, PlayerStat>();
            IsRunning = true;
            IntroStepsLeft = INTRO_STEPS.Length;
        }


    }
}
