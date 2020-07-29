using ProgressQuest.Models;
using System;
using System.Linq;
using static ProgressQuest.GameManager;
using static ProgressQuest.GameStrings;

namespace ProgressQuest.Managers
{
    public static class LootManager
    {
        public static LootItem GetNewItem(int value)
        {
            var t = new LootItem { Name = "a piece of shit", Value = value };
            return t;
        }

        public static ArmorItem GetNewArmor(int value)
        {
            var slots = Enum.GetValues(typeof(GameStrings.PLAYER_ARMOR_SLOT));
            var slot = rng.Next(1, slots.Length);
            var enumerator = slots.GetEnumerator();
            for (int i = 0; i < slot; i++)
            {
                enumerator.MoveNext();
            }
            var preValue = rng.Next(-3, 3);
            var matValue = rng.Next(-3, 3);
            var sufValue = rng.Next(-3, 3);
            var prefix = Math.Abs( rng.Next(1, QUALITY_PREFIXES.Length-4) + preValue );
            var material = Math.Abs( rng.Next(1, MATERIALS.Length-4) + matValue );
            var suffix = Math.Abs( rng.Next(1, QUALITY_SUFFIXES.Length-4) + sufValue );
            var name = $"{QUALITY_PREFIXES[prefix]} {MATERIALS[material]} ";
            PLAYER_ARMOR_SLOT slotType;
            switch (slot)
            {
                case (int)PLAYER_ARMOR_SLOT.Head:
                    name += HEAD_SLOTS[rng.Next(1, HEAD_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Head;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Neck:
                    name += NECK_SLOTS[rng.Next(1, NECK_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Neck;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Shoulders:
                    name += SHOULDER_SLOTS[rng.Next(1, SHOULDER_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Shoulders;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Torso:
                    name += TORSO_SLOTS[rng.Next(1, TORSO_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Torso;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Waist:
                    name += WAIST_SLOTS[rng.Next(1, WAIST_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Waist;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Arms:
                    name += ARM_SLOTS[rng.Next(1, ARM_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Arms;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Hands:
                    name += HAND_SLOTS[rng.Next(1, HAND_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Hands;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Ring:
                    name += RING_SLOTS[rng.Next(1, RING_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Ring;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Legs:
                    name += LEG_SLOTS[rng.Next(1, LEG_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Legs;
                    break;
                case (int)PLAYER_ARMOR_SLOT.Feet:
                    name += FOOT_SLOTS[rng.Next(1, FOOT_SLOTS.Length-1)]; slotType = PLAYER_ARMOR_SLOT.Feet;
                    break;
                default:
                    name += "piece of shit"; slotType = PLAYER_ARMOR_SLOT.Feet;
                    break;
            }
            name += " of " + QUALITY_SUFFIXES[rng.Next(1, QUALITY_SUFFIXES.Length-1)];

            var item = new ArmorItem
            {
                Name = name, Value = value + preValue + matValue + sufValue, Slot = slotType };
            return item;
        }

        public static void GenerateLoot(int value = 0)
        {
            if (value == 0)
            {
                value = State.QuestLog.CurrentActNumber * State.QuestLog.CurrentChapterNumber * State.QuestLog.CurrentQuestNumber;
            }
            if (rng.Next(1,20) > 15)
            {
                State.Player.Inventory.Add(GetNewItem(value));
            }
            else
            {
                EquipmentManager.Equip(GetNewArmor(value));
            }
        }

        public static string[] QUALITY_PREFIXES =
        {
            "awful", "dilapidated", "crappy", "broken", "cracked", "worn", "brittle",
            "unremarkable", "average", "middling", "okay",
            "nice", "sweet", "expensive", "shiny", "imbued", "reinforced", "enchanted"
        };

        public static string[] MATERIALS =
        {
            "linen", "cotton", "wool", "polyester",
            "paper", "wood", "iron", "bronze", "steel",
            "mithril", "diamond", "neutronium"
        };

        public static string[] QUALITY_SUFFIXES =
        {
            "ineptitude", "shoddiness", "brokenness",
            "plainness", "commonality",
            "superiority", "quickness", "sharpness",
            "revenge", "damage", "sheer power"
        };

        public static string[] HEAD_SLOTS =
        {
            "hat", "cap", "helmet", "wizard's hat"
        };

        public static string[] NECK_SLOTS =
        {
            "bandana", "necktie", "amulet", "gorget"
        };

        public static string[] SHOULDER_SLOTS =
        {
            "epaulets", "shawl", "mantle"
        };

        public static string[] TORSO_SLOTS =
        {
            "shirt", "jacket", "breastplate"
        };

        public static string[] WAIST_SLOTS =
        {
            "belt", "cummerbund", "girdle", "warbelt"
        };

        public static string[] ARM_SLOTS =
        {
            "sleeves", "bracers"
        };

        public static string[] HAND_SLOTS =
        {
            "mittens", "gloves", "gauntlets"
        };

        public static string[] RING_SLOTS =
        {
            "decoder ring", "band", "ring", "talisman"
        };

        public static string[] LEG_SLOTS =
        {
            "codpiece", "shorts", "pants", "leggings"
        };

        public static string[] FOOT_SLOTS =
        {
            "flip-flops", "socks", "shoes", "boots", "greaves"
        };

    }
}