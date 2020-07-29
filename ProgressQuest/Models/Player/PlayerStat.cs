using ProgressQuest.Models;
using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using static ProgressQuest.GameManager;

namespace ProgressQuest
{
    public class PlayerStat : DisplayedItem
    {
        public string Name { get; set; }

        private BigInteger value { get; set; }
        public BigInteger Value
        {
            get { return this.value; }
            set { if (value != this.value) { this.value = value; NotifyPropertyChanged(); } }
        }

        private BigInteger currentXP { get; set; }
        public BigInteger CurrentXP
        {
            get { return this.currentXP; }
            set {
                if (value != this.currentXP)
                {
                    this.currentXP = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("XPPercent");
                }
            }
        }

        private BigInteger nextLevel { get; set; }
        public BigInteger NextLevel
        {
            get { return this.nextLevel; }
            set { if (value != this.nextLevel) { this.nextLevel = value; NotifyPropertyChanged(); } }
        }

        public int XPPercent { get { return (int)(this.CurrentXP * 100 / this.NextLevel); } }

        public PlayerStat(string name)
        {
            Name = name;
            Value = rng.Next(2, 10);
            CurrentXP = 10;
            NextLevel = Value * 10;
        }

        public void AddXP(int gain)
        {
            if (CurrentXP + gain > nextLevel)
            {
                Value += 1;
                CurrentXP -= (NextLevel - gain);
                NextLevel += 10;
            }
            else
            {
                CurrentXP += gain;
            }
        }
    }
}
