using ProgressQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameManager;

namespace ProgressQuest.Managers
{
    public static class MonsterManager
    {
        public static void GetEnemy()
        {
            State.Enemy = new Monster
            {
                Name = "baddie",
                CurrentHP = 10,
                MaximumHP = 10,
                DmgMin = 1,
                DmgMax = 3
            };
        }
    }
}
