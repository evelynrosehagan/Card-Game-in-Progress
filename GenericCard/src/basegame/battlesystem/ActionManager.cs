using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.cardsystem;
namespace GenericCard.src.basegame.battlesystem
{
    public class ActionManager
    {
        Queue<AbstractAction> actionList;

        public ActionManager()
        {
            actionList = new Queue<AbstractAction>();
        }

        public void Add(AbstractAction input_action)
        {
            actionList.Enqueue(input_action);
        }

        public void Process()
        {
            Queue<AbstractAction> actions_incomplete = new Queue<AbstractAction>();
            while(actionList.Count>0)
            {
                AbstractAction action_to_process = actionList.Dequeue();
                action_to_process.update();
                if (!action_to_process.IsDone())
                    actions_incomplete.Enqueue(action_to_process);
            }
            actionList = actions_incomplete;
        }
    }
}
