using Microsoft.VisualBasic.Logging;
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
    public class QuestLog : DisplayedItem
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
            MaxMonstersKilled = INTRO_STEPS.Length;
        }

        public static string[] INTRO_STEPS =
        {
            "Beginning opening exposition...",
            "Terrible visions fill your head.",
            "You awaken with a fierce resolve.",
            "You gather your finest possessions.",
            "You bravely venture outside."
        };

        public static Action[] INTRO_ACTIONS =
        {
            () => { State.Player.MaxHP = 10; },
            () => { State.Player.HP = 10; },
            () => { State.QuestLog.Location = "Town"; },
            () => { State.Player.Inventory.Add(new LootItem("a small pile of shit", 1)); State.Player.Cash = 3; },
            () => { State.QuestLog.Quests.First().IsChecked = true; }
        };

        public void DoIntro()
        {
            if (State.QuestLog.MonstersKilled == MaxMonstersKilled)
            {
                GetNextQuest();
            }
            else
            {
                GameManager.Log.Add(INTRO_STEPS[MonstersKilled], INTRO_ACTIONS[MonstersKilled]);
                State.QuestLog.MonstersKilled++;
            }
        }

        public void GetNextQuest()
        {
            var quest = new Quest();

            if (CurrentActNumber == 0 || CurrentChapterNumber >= 3) // act complete
            {
                CurrentActNumber++; CurrentChapterNumber = 1; CurrentQuestNumber = 0;
            }
            if (CurrentQuestNumber >= 3) // chapter complete
            {
                CurrentChapterNumber++; CurrentQuestNumber = 0;
            }
            CurrentQuestNumber++;
            DeleteQuests();
            Quests.Add(new Quest { Text = $"Act {CurrentActNumber}, Chapter {CurrentChapterNumber}" });


            quest.Text = $"Quest {CurrentQuestNumber}: Slay {MaxMonstersKilled} baddies";

            Quests.Add(quest);
        }

        private void DeleteQuests()
        {
            var quest = Quests.Last();
            while (quest.Text.StartsWith("Q"))
            {
                Quests.Remove(quest);
                quest = Quests.Last();
            }
            Quests.Last().IsChecked = false;
        }
    }
}
