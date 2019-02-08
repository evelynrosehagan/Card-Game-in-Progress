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
    }
}
