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
            //State.Enemy = new Monster((int)State.Player.Stats["Level"].Value);
            State.Enemy.Level = State.Player.Stats["Level"].Value;
            State.Enemy.MaximumHP = State.Enemy.Level * 10;
            State.Enemy.CurrentHP = State.Enemy.MaximumHP;
            State.Enemy.Name = "Kobold";
            State.Enemy.DmgMax = State.Enemy.Level;
        }
    }
}
