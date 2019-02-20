using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.cardsystem;
using GenericCard.src.basegame.charactersystem;
using GenericCard.src.basegame.battlesystem;
using GenericCard.src.basegame.cardutilities;

using GenericCard.src.basedata.baseactions;

namespace GenericCard.src.basedata.basecards
{
    public class Punch : AbstractCard
    {
        public readonly static string CARD_ID = "Basic:Punch";
        private readonly static CardRarity RARITY = CardRarity.Common;
        private readonly static CardType CARDTYPE = CardType.Attack;
        private readonly static CardTarget TARGET = CardTarget.Enemy;
        private readonly static int BASECOST = 1;
        private readonly static string BASEDESCRIPTION = "Deal ##damage## damage";
        private readonly static int BASEDAMAGE = 11;

        public Punch() :
            base(CARD_ID, RARITY, CARDTYPE, TARGET, BASECOST, BASEDESCRIPTION)
        {
            this.damage = BASEDAMAGE;
        }
        public override void use(AbstractPlayer Self, AbstractPlayer Enemy, AbstractEnvironment Environment)
        {
            AbstractArena.actionManager.Add(new DamageAction(Self, CardTargettingUtility.GetPCTargets(this, Self, Enemy, Environment), BASEDAMAGE));
        }
    }
}
 