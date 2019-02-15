using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.notifications
{
    public static class CardUseNotifications
    {
        public const string DeckCardDraw = "combat.deck.draw";
        public const string HandDiscardChoice = "combat.hand.discardchoice";
        public const string HandDiscardRandom = "combat.hand.discardrandom";
        //param setup: {AbstractCard, AbstractPlayer self, AbstractPlayer enemy, AbstractPlayer environment}
        public const string PlayCombatCard = "combat.card.play";

    }
}
