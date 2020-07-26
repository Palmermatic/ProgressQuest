using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressQuest.Models.UI
{
    public class QuestLog : DisplayedItem
    {
        public BindingList<CheckBox> Log { get; set; }
        public int CurrentActNumber { get; set; }
        public int CurrentChapterNumber { get; set; }
        public int CurrentQuestNumber { get; set; }
        public int CurrentQuestPercent { get { if (maxMonstersLeft == 0) { return 0; } return monstersLeft * 100 / maxMonstersLeft; } }
        private int maxMonstersLeft;
        public int MaxMonstersLeft { get { return maxMonstersLeft; } set { if (maxMonstersLeft != value) { maxMonstersLeft = value; NotifyPropertyChanged(); NotifyPropertyChanged("CurrentQuestPercent"); } } }
        private int monstersLeft;
        public int MonstersLeft { get { return monstersLeft; } set { if (monstersLeft != value) { monstersLeft = value; NotifyPropertyChanged(); NotifyPropertyChanged("CurrentQuestPercent"); } } }

        public QuestLog()
        {
            Log = new BindingList<CheckBox> { new CheckBox { Name = "Intro", Text = "Intro" } };
            CurrentActNumber = 0;
            CurrentChapterNumber = 0;
            CurrentQuestNumber = 0;
        }

        public void GetNextQuest()
        {
            var quest = new CheckBox { Name = "", Text = "" };
        }
    }
}
