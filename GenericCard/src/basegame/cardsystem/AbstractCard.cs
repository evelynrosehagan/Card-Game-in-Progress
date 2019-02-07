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
        private readonly string card_name;
        private readonly CardRarity card_rarity;
        private readonly CardType card_type;
        private readonly CardTarget card_target;
        private readonly int card_cost;
        private readonly string card_description;
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

        public enum CardTarget
        {
            Self,
            Enemy,
            All,
            Environment,
            None
        }
        #endregion

        #region Constructors and Getters/Setters
        public AbstractCard(string inp_ID, CardRarity crarity, CardType ctype, CardTarget ctarget, int ccost, string cdescription)
        {
            ID = inp_ID;
            card_rarity = crarity;
            card_target = ctarget;
            card_type = ctype;
            card_cost = ccost;
            card_description = cdescription;

            if (cardutilities.CardIDUtilities.IsValidCardID(this))
                card_name = ID.Split(':')[1];
        }

        public string GetID()
        {
            return ID;
        }
        #endregion

    }
}
