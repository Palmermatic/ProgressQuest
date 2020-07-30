using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQuest.Models
{
    public class Monster : INotifyPropertyChanged
    {
        private string name { get; set; }
        public string Name { get { return name; } set { if (name != value) { name = value; NotifyPropertyChanged(); } } }
        private BigInteger maximumHP { get; set; }
        public BigInteger MaximumHP { get { return maximumHP; } set { if (maximumHP != value) { maximumHP = value; NotifyPropertyChanged("HPPercent"); NotifyPropertyChanged("HPLabel"); } } }
        private BigInteger currentHP { get; set; }
        public BigInteger CurrentHP { get { return currentHP; } set { if (currentHP != value) { currentHP = value; NotifyPropertyChanged("HPPercent"); NotifyPropertyChanged("HPLabel"); } } }
        public int HPPercent { get { if (maximumHP == 0) return 0; return (int)(currentHP * 100 / maximumHP); } }
        public string HPLabel { get { return CurrentHP + " / " + MaximumHP; } }
        private BigInteger level { get; set; }
        public BigInteger Level { get { return level; } set { if (level != value) { level = value; NotifyPropertyChanged(); } } }
        private BigInteger dmgMin { get; set; }
        public BigInteger DmgMin { get { return dmgMin; } set { if (dmgMin != value) { dmgMin = value; NotifyPropertyChanged(); } } }
        private BigInteger dmgMax { get; set; }
        public BigInteger DmgMax { get { return dmgMax; } set { if (dmgMax != value) { dmgMax = value; NotifyPropertyChanged(); } } }
        
        public Monster() { }

        public Monster(int level)
        {
            Name = "baddie";
            Level = level;
            MaximumHP = 10 * Level;
            CurrentHP = MaximumHP;
            DmgMin = Level;
            DmgMax = DmgMin + 3;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
