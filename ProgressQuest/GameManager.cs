using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProgressQuest.GameStrings;

namespace ProgressQuest
{
    public static class GameManager
    {
        public static GameState State;
        public static Random rng;
        public static QuestLog QuestLog;

        public static void NewGame()
        {
            State = new GameState();
            rng = new Random();
            QuestLog = new QuestLog();
        }

        public static void Tick()
        {
            SetNextAction();
            State.Stats["Experience"].AddXP(10);
        }

        public static void SetNextAction()
        {
            if (State.IntroStepsLeft > 0)
            {
                QuestLog.Add(INTRO_STEPS[INTRO_STEPS.Length - State.IntroStepsLeft--]);
            }
            else
            {
                var randomStat = State.Stats.Skip(rng.Next(1, State.Stats.Count)).First();
                QuestLog.Add("Training " + randomStat.Key + "...", () => { randomStat.Value.AddXP(10); });
            }
        }
    }
}
