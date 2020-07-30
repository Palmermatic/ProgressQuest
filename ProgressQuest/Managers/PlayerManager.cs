using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameManager;

namespace ProgressQuest.Managers
{
    public static class PlayerManager
    {
        public static void AddXP(int value)
        {
            AddXP("Level", value);
        }

        public static void AddXP(string statName, int value)
        {
            var stat = State.Player.Stats[statName];
            if (stat.CurrentXP + value > stat.NextLevel)
            {
                stat.Value += 1;
                Log.Add("Your " + statName + " is now " + stat.Value);
                stat.CurrentXP -= (stat.NextLevel - value);
                stat.NextLevel += 10;
            }
            else
            {
                stat.CurrentXP += value;
            }
        }
    }
}
