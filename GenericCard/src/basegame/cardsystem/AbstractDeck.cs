using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.basegame.cardsystem
{
    public abstract class AbstractDeck
    {
        protected string CardPool = "";
        Queue<AbstractCard> CardQueue;

        public string GetCardPool()
        {
            return CardPool;
        }
    }
}
