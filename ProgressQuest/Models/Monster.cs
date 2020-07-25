using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProgressQuest.Models
{
    class Monster
    {
        public string Name { get; set; }
        private BigInteger maximumHP { get; set; }
        public BigInteger MaximumHP { get; set; }
        private BigInteger currentHP { get; set; }
        public BigInteger CurrentHP { get; set; }
        public int CurrentHPPercent { get { return (int)(currentHP * 100 / maximumHP); } }
    }
}
