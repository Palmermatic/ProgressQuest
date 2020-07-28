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
using ProgressQuest.Models.UI;
using static ProgressQuest.GameManager;

namespace ProgressQuest
{
    public static class GameManager
    {
        public static GameState State;
        public static Random rng;
        public static GameLog Log;

        public static void NewGame()
        {
            State = new GameState();
            rng = new Random();
            Log = new GameLog();
        }

        public static void Tick()
        {
            SetNextAction();
        }

        public static void SetNextAction()
        {
            if (State.QuestLog.CurrentActNumber == 0)
            {
                State.QuestLog.DoIntro();
            }
            else
            {
                if (State.Player.HP > 0)
                {
                    if (State.QuestLog.Location == "Town")
                    {
                        if (State.Player.Inventory.Any())
                        {
                            AdventureManager.SellLoot();
                        }
                        else
                        {
                            Log.Add("Walking to the killing fields...", () => { AdventureManager.SetNextLocation(); });
                        }
                    }
                    else
                    {
                        AdventureManager.DoBattle();
                    }
                }
                else
                {
                    if (State.QuestLog.Location == "Town")
                    {
                        Log.Add("Resting up...", () => { State.Player.HP = State.Player.MaxHP; });
                    }
                    else
                    {
                        Log.Add("Limping back to town...", () => { State.QuestLog.Location = "Town"; });
                    }
                }
            }
        }

        public static void TrainRandomStat()
        {
            var randomStat = State.Player.Stats.Skip(rng.Next(1, State.Player.Stats.Count)).First();
            GameManager.Log.Add("Training " + randomStat.Key + "...", () => { randomStat.Value.AddXP(10); });
        }
    }
}
