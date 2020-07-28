using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameStrings;

namespace ProgressQuest.Models
{
    public class LootItem
    {
        public string Name { get; set; }
        public BigInteger Value { get; set; }

        public LootItem() { }

        public LootItem(string name, BigInteger value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name + " ($" + Value + ")";
        }
    }
}
