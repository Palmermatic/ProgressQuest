﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProgressQuest
{
    public static class GameStrings
    {
        public static String[] INTRO_STEPS =
        {
            "You awaken with no memory.",
            "You search your surroundings. You are in a dark room.",
            "You are likely to be eaten by a grue.",
        };

        public enum STARTING_PLAYER_STAT
        {
            Experience,
            Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma
        };

        public static String[] ADVENTURE_LOCATIONS =
        {
            "Kobold Kamp",
            "Harpy Hill",
            "Gnoll Gnoll",
        };

        public enum PLAYER_ARMOR_SLOT
        {
            Head, Neck, Shoulders, Torso, Arms, Hands, Ring, Waist, Legs, Feet
        }

        public enum PLAYER_EQUIP_SLOT
        {
            LeftHand, RightHand
        }
    }
}