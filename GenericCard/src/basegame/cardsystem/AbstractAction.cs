using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.basegame.cardsystem
{
    abstract class AbstractAction
    {
        protected bool isdone;

        public abstract void update();

        #region Getters and Setters
        public bool IsDone()
        {
            return isdone;
        }
        #endregion
    }
}
