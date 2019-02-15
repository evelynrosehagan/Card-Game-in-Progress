using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.cardsystem;
namespace GenericCard.src.basegame.cardutilities
{
    public class DeckSearchUtility
    {
        public static bool DeckHasCard(AbstractCard card, AbstractDeck deck)
        {
            if (card == null)
                throw new exceptions.NullCardException();
            AbstractCard[] CardList = deck.GetArrayOfCardsInDeck();
            for (int i = 0; i < CardList.Length; i++)
                if (CardList[i].GetID() == card.GetID())
                    return true;
            return false;
        }
    }
}
