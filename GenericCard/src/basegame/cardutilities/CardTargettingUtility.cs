using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.charactersystem;
using GenericCard.src.basegame.cardsystem;

namespace GenericCard.src.basegame.cardutilities
{
    class CardTargettingUtility
    {
        public static List<AbstractPlayer> GetPCTargets(AbstractCard Card, AbstractPlayer Self, AbstractPlayer Enemy, AbstractEnvironment Environment)
        {
            List<AbstractPlayer> Targets = new List<AbstractPlayer>();
            switch(Card.GetCardTarget())
            {
                case AbstractCard.CardTarget.All:
                    Targets.Add(Self);
                    Targets.Add(Enemy);
                    Targets.Add(Environment);
                    break;
                case AbstractCard.CardTarget.Enemy:
                    Targets.Add(Enemy);
                    break;
                case AbstractCard.CardTarget.Environment:
                    Targets.Add(Environment);
                    break;
                case AbstractCard.CardTarget.Self:
                    Targets.Add(Self);
                    break;
            }
            return Targets;
        }
    }
}
