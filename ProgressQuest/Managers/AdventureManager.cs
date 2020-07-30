using ProgressQuest.Models;
using ProgressQuest.Models.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameManager;

namespace ProgressQuest.Managers
{
    public static class AdventureManager
    {
        public static void DoBattle()
        {
            if (State.Enemy.MaximumHP == 0)
            {
                Log.Add($"Patrolling for baddies...", () => { MonsterManager.GetEnemy(); });
            }
            else if (State.Enemy.CurrentHP <= 0)
            {
                Log.Add(State.Enemy.Name + " slain!  Looting...", () => { LootManager.GenerateLoot(); QuestManager.KilledAMonster(); });
            }
            else
            {
                var mySwing = rng.Next((int)State.Player.DmgMin, (int)State.Player.DmgMax);
                var enemySwing = rng.Next((int)State.Enemy.DmgMin, (int)State.Enemy.DmgMax);
                Log.Add($"Hit for {mySwing}.  Took {enemySwing} damage.", () => { State.Player.HP -= enemySwing; State.Enemy.CurrentHP -= mySwing; });
            }
        }

        public static void SellLoot()
        {
            var item = State.Player.Inventory.First();
            Log.Add($"Selling {item.Name} for ${item.Value}", () =>
            {
                State.Player.Cash += item.Value;
                State.Player.Inventory.Remove(item);
            });
        }

        internal static void WalkToBattle()
        {
            Log.Add("Walking to " + GameStrings.ADVENTURE_LOCATIONS[0], () => { State.QuestLog.Location = GameStrings.ADVENTURE_LOCATIONS[0]; });
        }

        internal static void Rest()
        {
            Log.Add("Resting up...", () => { State.Player.HP = State.Player.MaxHP; }, 10);
        }

        internal static void WalkToTown()
        {
            Log.Add("Limping back to town...", () => { State.QuestLog.Location = "Town"; }, 5);
        }
    }
}
