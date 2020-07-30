using ProgressQuest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProgressQuest.GameManager;
using static ProgressQuest.Models.UI.QuestLog;

namespace ProgressQuest.Managers
{
    public static class QuestManager
    {
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

        public static void DoIntro()
        {
            if (State.QuestLog.MonstersKilled == State.QuestLog.MaxMonstersKilled)
            {
                GetNextQuest();
            }
            else
            {
                GameManager.Log.Add(INTRO_STEPS[State.QuestLog.MonstersKilled], INTRO_ACTIONS[State.QuestLog.MonstersKilled], State.QuestLog.MonstersKilled);
                State.QuestLog.MonstersKilled++;
            }
        }

        public static void KilledAMonster()
        {
            State.Enemy.MaximumHP = 0;
            State.Enemy.CurrentHP = 0;
            PlayerManager.AddXP(10);
            State.QuestLog.MonstersKilled++;
            if (State.QuestLog.MonstersKilled >= State.QuestLog.MaxMonstersKilled)
            {
                GetNextQuest();
            }
        }

        public static void GetNextQuest()
        {
            State.QuestLog.Quests.Last().IsChecked = true;
            var quest = new Quest();

            if (State.QuestLog.CurrentActNumber == 0 || State.QuestLog.CurrentChapterNumber >= 3) // act complete
            {
                State.QuestLog.CurrentActNumber++;
                State.QuestLog.CurrentChapterNumber = 1;
                State.QuestLog.CurrentQuestNumber = 0;
                DeleteQuests();
                State.QuestLog.Quests.Add(new Quest { Text = $"Act {State.QuestLog.CurrentActNumber}, Chapter {State.QuestLog.CurrentChapterNumber}" });

            }
            if (State.QuestLog.CurrentQuestNumber >= 3) // chapter complete
            {
                State.QuestLog.CurrentChapterNumber++;
                State.QuestLog.CurrentQuestNumber = 0;
                DeleteQuests();
                State.QuestLog.Quests.Add(new Quest { Text = $"Act {State.QuestLog.CurrentActNumber}, Chapter {State.QuestLog.CurrentChapterNumber}" });

            }
            State.QuestLog.CurrentQuestNumber++;
            State.QuestLog.MonstersKilled = 0;
            State.QuestLog.MaxMonstersKilled = State.QuestLog.CurrentActNumber * State.QuestLog.CurrentChapterNumber * State.QuestLog.CurrentQuestNumber;
            quest.Text = $"Quest {State.QuestLog.CurrentQuestNumber}: Slay {State.QuestLog.MaxMonstersKilled} baddies";

            State.QuestLog.Quests.Add(quest);
        }

        private static void DeleteQuests()
        {
            var quest = State.QuestLog.Quests.Last();
            while (quest.Text.StartsWith("Q"))
            {
                State.QuestLog.Quests.Remove(quest);
                quest = State.QuestLog.Quests.Last();
            }
            quest.IsChecked = true;
        }
    }
}
