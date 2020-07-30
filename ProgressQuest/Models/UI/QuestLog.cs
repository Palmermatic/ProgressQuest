using Microsoft.VisualBasic.Logging;
using ProgressQuest.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProgressQuest.GameManager;

namespace ProgressQuest.Models.UI
{
    public class QuestLog : INotifyPropertyChanged
    {
        public BindingList<Quest> Quests { get; set; }
        private string location;
        public string Location { get { return location; } set { if (value != location) { location = value; NotifyPropertyChanged(); } } }
        public int CurrentActNumber { get; set; }
        public int CurrentChapterNumber { get; set; }
        public int CurrentQuestNumber { get; set; }
        public int CurrentQuestPercent { get { if (maxMonstersKilled == 0) { return 0; } return monstersKilled * 100 / maxMonstersKilled; } }
        private int maxMonstersKilled;
        public int MaxMonstersKilled { get { return maxMonstersKilled; } set { if (maxMonstersKilled != value) { maxMonstersKilled = value; NotifyPropertyChanged(); NotifyPropertyChanged("CurrentQuestPercent"); } } }
        private int monstersKilled;
        public int MonstersKilled { get { return monstersKilled; } set { if (monstersKilled != value) { monstersKilled = value; NotifyPropertyChanged(); NotifyPropertyChanged("CurrentQuestPercent"); } } }

        public class Quest
        {
            public string Text { get; set; }
            public bool IsChecked { get; set; }
        }

        public QuestLog()
        {
            Quests = new BindingList<Quest>();
            Quests.Add(new Quest { Text = "Intro" });
            Location = "Dreaming";
            CurrentActNumber = 0;
            CurrentChapterNumber = 0;
            CurrentQuestNumber = 0;
            MonstersKilled = 0;
            MaxMonstersKilled = QuestManager.INTRO_STEPS.Length;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
