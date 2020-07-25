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

        public override string ToString()
        {
            return Name + " ($" + Value + ")";
        }
    }
}
