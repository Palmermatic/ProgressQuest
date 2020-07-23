using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using static ProgressQuest.GameManager;

namespace ProgressQuest
{
    public class PlayerStat : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
        private BigInteger _Value { get; set; }
        public BigInteger Value
        {
            get { return this._Value; }
            set { if (value != this.Value) { this.Value = value; NotifyPropertyChanged(); } }
        }
        public BigInteger CurrentXP
        {
            get { return this.Value; }
            set { if (value != this.Value) { this.Value = value; NotifyPropertyChanged(); } }
        }

        public BigInteger NextLevel
        {
            get { return this.Value; }
            set { if (value != this.Value) { this.Value = value; NotifyPropertyChanged(); } }
        }
        public int XPPercent { get { return (int)(this.CurrentXP * 100 / this.NextLevel); } }

        public PlayerStat(string name)
        {
            Name = name;
            Value = rng.Next(1, 10);
            CurrentXP = 10;
            NextLevel = Value * 10;
        }


        public void AddXP(int gain)
        {
            CurrentXP += gain;
            if (CurrentXP >= NextLevel)
            {
                Value += 1;
                CurrentXP -= NextLevel;
                NextLevel += 10;
            }
        }

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
