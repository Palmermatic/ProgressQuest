using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQuest.Managers
{
    public static class AdventureManager
    {
        public static string GetNextLocation()
        {
            return GameStrings.ADVENTURE_LOCATIONS[0];
        }

        internal static void DoBattle()
        {
            // if monster is dead, loot it and find a new monster

        }

        internal static void SellLoot()
        {
            if (!GameManager.State.Player.Inventory.Any())
            {

            }
            var item = GameManager.State.Player.Inventory.First();
            GameManager.GameLog.Add("Selling " + item.Name, () =>
            {
                GameManager.State.Player.Inventory.Remove(item);
                GameManager.State.Player.Cash += item.Value;
            });
        }
    }
}
