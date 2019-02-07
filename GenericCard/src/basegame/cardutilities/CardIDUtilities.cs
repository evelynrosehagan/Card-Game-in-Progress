using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericCard.src.basegame.cardsystem;

namespace GenericCard.src.basegame.cardutilities
{
    public class CardIDUtilities
    {
        public static string GetCardFaction(AbstractCard input_Card)
        {
            if (IsValidCardID(input_Card))
            {
                return input_Card.GetID().Split(':')[0];
            }
            else
                Console.WriteLine("ERROR >> Invalid Card ID with \"" + input_Card.GetID());
            return "";
        }

        public static bool IsValidCardID(AbstractCard input_Card)
        {
            return (input_Card.GetID() != null && input_Card.GetID() != "" && input_Card.GetID().Contains(":"));
        }
    }
}
