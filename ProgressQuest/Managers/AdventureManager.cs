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
            // if monster is dead, loot it and find a new monster

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
