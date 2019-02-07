using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.cardsystem;
using GenericCard.src.basegame.cardutilities;

namespace GenericCard.src.basegame.cardutilities
{
    public class DeckTagUtil
    {
        public static bool CardInCardPool(AbstractCard input_card, AbstractDeck input_deck)
        {
            string[] DeckFactions = GetListDeckFactions(input_deck);
            string card_faction = CardIDUtilities.GetCardFaction(input_card);
            foreach (string comparitor_faction in DeckFactions)
            {
                if (comparitor_faction == card_faction)
                    return true;
            }
            return false;
        }

        public static string[] GetListDeckFactions(AbstractDeck input_deck)
        {
            string CardPool = input_deck.GetCardPool();
            if(!IsValidCardPool(input_deck))
            {
                return new string[] { "" };
            }
            else if (!CardPool.Contains(":"))
            {
                return new string[] { CardPool };
            }
            else
            {
                return CardPool.Split(':');
            }
        }

        public static bool IsValidCardPool(AbstractDeck input_deck)
        {
            string CardPool = input_deck.GetCardPool();
            if (CardPool == "")
            {
                Console.WriteLine("ERROR >>> Card Pool is empty");
                return false;
            }
            return true;
        }
    }
}
