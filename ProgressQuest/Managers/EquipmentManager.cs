using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameStrings;
using static ProgressQuest.GameManager;

namespace ProgressQuest.Models
{
    public static class EquipmentManager
    {
        public static void Equip(ArmorItem item)
        {
            var oldItem = State.Player.Equipment.First(i => i.Slot == item.Slot);
            var index = State.Player.Equipment.IndexOf(oldItem);
            var oldLoot = new LootItem { Name = oldItem.Name, Value = oldItem.Value };
            State.Player.Equipment.Remove(oldItem);
            State.Player.Equipment.Insert(index, item);
            State.Player.LastEquipped = index;
        }
    }
}
