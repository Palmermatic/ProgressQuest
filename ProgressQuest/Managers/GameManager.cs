using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProgressQuest.GameStrings;
using Microsoft.VisualBasic;
using ProgressQuest.Managers;

namespace ProgressQuest
{
    public static class GameManager
    {
        public static GameState State;
        public static Random rng;
        public static GameLog GameLog;

        public static void NewGame()
        {
            State = new GameState();
            State.Player.Name = Interaction.InputBox("Enter your name", "New game", "");
            rng = new Random();
            GameLog = new GameLog();
        }

        public static void Tick()
        {
            SetNextAction();
            State.Player.Stats["Experience"].AddXP(10);
        }

        public static void SetNextAction()
        {
            if (State.IntroStepsLeft > 0)
            {
                GameManager.GameLog.Add(INTRO_STEPS[INTRO_STEPS.Length - State.IntroStepsLeft--]);
            }
            else
            {
                if (State.Player.HP > 0)
                {
                    if (State.Location == "Town")
                    {
                        if (State.Player.Inventory.Any())
                        {
                            AdventureManager.SellLoot();
                        }
                        else
                        {
                            GameManager.GameLog.Add("Walking to the killing fields...", () => { State.Location = AdventureManager.GetNextLocation(); });
                        }
                    }
                    else
                    {
                        AdventureManager.DoBattle();
                    }
                }
                else
                {
                    if (State.Location == "Town")
                    {
                        GameManager.GameLog.Add("Resting up...", () => { State.Player.HP = State.Player.MaxHP; });
                    }
                    else
                    {
                        GameManager.GameLog.Add("Limping back to town...", () => { State.Location = "Town"; });
                    }
                }
            }
        }

        public static void TrainRandomStat()
        {
            var randomStat = State.Player.Stats.Skip(rng.Next(1, State.Player.Stats.Count)).First();
            GameManager.GameLog.Add("Training " + randomStat.Key + "...", () => { randomStat.Value.AddXP(10); });
        }
    }
}
