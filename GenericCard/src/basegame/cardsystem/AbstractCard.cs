using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.basegame.cardsystem
{
    public abstract class AbstractCard
    {
        #region Fields and Variables
        //Format: CardPool:CardName
        private readonly string ID;
        #endregion

        #region Enums and structures
        public enum CardRarity
        {
            Common,
            Uncommon,
            Rare,
            Epic,
            Legendary
        }

        public enum CardType
        {
            Attack,
            Magic,
            Skill,
            Upgrade
        }
        #endregion

        #region Constructors and Getters/Setters
        public AbstractCard(string inp_ID)
        {
            ID = inp_ID;
        }

        public string GetID()
        {
            return ID;
        }
        #endregion

    }
}
