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
    public class EquipmentManager
    {
        public BindingList<ArmorItem> Items { get; set; }

        public EquipmentManager()
        {
            Items = new BindingList<ArmorItem>();
            foreach (PLAYER_ARMOR_SLOT slot in Enum.GetValues(typeof(PLAYER_ARMOR_SLOT)))
            {
                Items.Add(new ArmorItem { Name = "empty", Value = 0, Slot = slot });
            }
        }

        public LootItem Equip(ArmorItem item)
        {
            var oldItem = Items.First(i => i.Slot == item.Slot);
            var index = Items.IndexOf(oldItem);
            var oldLoot = new LootItem { Name = oldItem.Name, Value = oldItem.Value };
            Items.Remove(oldItem);
            Items.Insert(index, item);
            return oldLoot;
        }
    }
}
