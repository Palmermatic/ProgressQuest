using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameStrings;

namespace ProgressQuest.Models
{
    public class Player
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name { get; set; }
        public string Name { get { return name; } set { if (!string.IsNullOrWhiteSpace(name) && name != value) { name = value; NotifyPropertyChanged(); } } }
        public Dictionary<string, PlayerStat> Stats;
        private BigInteger hp { get; set; }
        public BigInteger HP
        {
            get { return hp; }
            set { if (value != hp) { hp = value; NotifyPropertyChanged(); NotifyPropertyChanged("HPPercent"); } }
        }
        private BigInteger maxHP { get; set; }
        public BigInteger MaxHP
        {
            get { return maxHP; }
            set { if (value != maxHP) { maxHP = value; NotifyPropertyChanged(); NotifyPropertyChanged("HPPercent"); } }
        }
        public int HPPercent { get { return (int)(hp * 100 / maxHP); } }

        private BigInteger cash { get; set; }
        public BigInteger Cash { get { return cash; } set { if (cash != value) { cash = value; NotifyPropertyChanged(); } } }
        private BigInteger dmgMin { get; set; }
        public BigInteger DmgMin { get { return dmgMin; } set { if (dmgMin != value) { dmgMin = value; NotifyPropertyChanged(); } } }
        private BigInteger dmgMax { get; set; }
        public BigInteger DmgMax { get { return dmgMax; } set { if (dmgMax != value) { dmgMax = value; NotifyPropertyChanged(); } } }

        public BindingList<LootItem> Inventory { get; set; }
        public Equipment Equipment { get; set; }

        public Player()
        {
            Equipment = new Equipment();
            Equipment.Equip(new ArmorItem { Name = "a stupid hat", Value = 0 });
            Inventory = new BindingList<LootItem> { new LootItem { Name = "small piece of shit", Value = 1 } };
            MaxHP = 10;
            HP = 10;
            Cash = 1;
            Stats = new Dictionary<string, PlayerStat>();
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
