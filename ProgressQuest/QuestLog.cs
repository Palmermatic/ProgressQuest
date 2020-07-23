using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressQuest
{
    public class QuestLog
    {
        public BindingList<string> Log { get; set; }
        public string NextLog { get; set; }
        public Action NextReward { get; set; }

        public QuestLog()
        {
            Log = new BindingList<string>
            {
                "Beginning opening exposition..."
            };
        }

        public void Add(string text, Action reward = null)
        {
            NextReward?.Invoke();
            Log.Insert(0,text);
            NextReward = reward;
        }
    }
}
