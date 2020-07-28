﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQuest.Models
{
    public class Monster : DisplayedItem
    {
        public string Name { get; set; }
        private BigInteger maximumHP { get; set; }
        public BigInteger MaximumHP { get; set; }
        private BigInteger currentHP { get; set; }
        public BigInteger CurrentHP { get; set; }
        public int CurrentHPPercent { get { return (int)(currentHP * 100 / maximumHP); } }

        private BigInteger dmgMin { get; set; }
        public BigInteger DmgMin { get { return dmgMin; } set { if (dmgMin != value) { dmgMin = value; NotifyPropertyChanged(); } } }
        private BigInteger dmgMax { get; set; }
        public BigInteger DmgMax { get { return dmgMax; } set { if (dmgMax != value) { dmgMax = value; NotifyPropertyChanged(); } } }

        public Monster()
        { }

    }
}
