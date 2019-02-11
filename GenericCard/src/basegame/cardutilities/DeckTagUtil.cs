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
            return IsFactionInPool( input_deck, CardIDUtilities.GetCardFaction(input_card));
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
		
		public static bool IsFactionInPool(AbstractDeck input_deck, string faction)
		{
			if(!IsValidCardPool(input_deck))
				return false;
			string[] faction_list = GetListDeckFactions(input_deck);
			foreach(string comparitor_faction in faction_list)
			{
				if(faction == comparitor_faction)
					return true;
			}
			return false;
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
