using ProgressQuest.Models;
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
        public static void SetNextLocation()
        {
            State.QuestLog.Location = GameStrings.ADVENTURE_LOCATIONS[0];
        }

        public static void DoBattle()
        {
            if (State.Enemy == null)
            {
                Log.Add($"Patrolling for baddies...", () => { MonsterManager.GetEnemy(); });
            }
            else if (State.Enemy.CurrentHP <= 0)
            {
                Log.Add("Looting...", () => { LootManager.GenerateLoot(); State.QuestLog.KilledAMonster(); });
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
    }
}
