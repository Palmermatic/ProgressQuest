﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameStrings;
using static ProgressQuest.GameManager;

namespace ProgressQuest.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string name { get; set; }
        public string Name { get { return name; } set {
                if (!string.IsNullOrWhiteSpace(value) && name != value) { name = value; NotifyPropertyChanged(); } } }
        public Dictionary<string, PlayerStat> Stats;
        private BigInteger hp { get; set; }
        public BigInteger HP
        {
            get { return hp; }
            set { if (value != hp) { hp = Math.Max(0, (int)value); NotifyPropertyChanged("HPLabel"); NotifyPropertyChanged("HPPercent"); } }
        }
        private BigInteger maxHP { get; set; }
        public BigInteger MaxHP
        {
            get { return maxHP; }
            set { if (value != maxHP) { maxHP = value; NotifyPropertyChanged("HPLabel"); NotifyPropertyChanged("HPPercent"); } }
        }
        public int HPPercent { get { if (maxHP == 0) return 0; return (int)(hp * 100 / maxHP); } }
        public string HPLabel { get { return HP + " / " + MaxHP; } }

        private BigInteger cash { get; set; }
        public BigInteger Cash { get { return cash; } set { if (cash != value) { cash = value; NotifyPropertyChanged(); } } }
        private BigInteger dmgMin { get; set; }
        public BigInteger DmgMin { get { return dmgMin; } set { if (dmgMin != value) { dmgMin = value; NotifyPropertyChanged(); } } }
        private BigInteger dmgMax { get; set; }
        public BigInteger DmgMax { get { return dmgMax; } set { if (dmgMax != value) { dmgMax = value; NotifyPropertyChanged(); } } }

        public BindingList<LootItem> Inventory { get; set; }
        public BindingList<ArmorItem> Equipment { get; set; }
        private int lastEquipped;
        public int LastEquipped { get { return lastEquipped; } set { if (lastEquipped != value) { lastEquipped = value; NotifyPropertyChanged(); } } }

        public Player()
        {
            var input = Interaction.InputBox("Enter your name", "New game");
            Name = string.IsNullOrWhiteSpace(input) ? "a noob" : input;
            Inventory = new BindingList<LootItem>();
            Equipment = new BindingList<ArmorItem>();
            DmgMin = 1;
            DmgMax = 1;
            foreach (PLAYER_ARMOR_SLOT slot in Enum.GetValues(typeof(PLAYER_ARMOR_SLOT)))
            {
                Equipment.Add(new ArmorItem { Name = "empty", Value = 0, Slot = slot });
            }
            Stats = new Dictionary<string, PlayerStat>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
