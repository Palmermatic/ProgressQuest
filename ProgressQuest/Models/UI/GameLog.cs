﻿using ProgressQuest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressQuest
{
    public class GameLog : INotifyPropertyChanged
    {
        public BindingList<string> Log { get; set; }
        public string NextLog { get; set; }
        public Action NextReward { get; set; }
        private int ticks;
        public int TicksRequired { get { return ticks; } set { if (value != ticks) { ticks = value; NotifyPropertyChanged(); } } }

        public GameLog()
        {
            Log = new BindingList<string>();
        }

        public void Add(string text, Action reward = null, int ticksRequired = 3)
        {
            Log.Insert(0, text);
            NextReward = reward;
            TicksRequired = ticksRequired;
        }

        public void Do()
        {
            NextReward?.Invoke();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
