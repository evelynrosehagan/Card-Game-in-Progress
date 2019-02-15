using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericCard.src.basegame.cardutilities;
using GenericCard.src.basegame.cardsystem;
using GenericCard.src.basedata.basecards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.basegame.cardutilities.Tests.CardUtilities
{
    [TestClass()]
    public class DeckSearchUtilityTests
    {
        [TestMethod()]
        public void DeckHasCardTest_FOUND()
        {
            //arrange
            AbstractDeck test_deck = new DEBUG_Deck();
            AbstractCard card_one = new Punch();
            AbstractCard card_two = new DEBUG_Card("Basic:Test1", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.None, 2, "Test card 1");
            AbstractCard card_three = new DEBUG_Card("Basic:Test2", AbstractCard.CardRarity.Rare, AbstractCard.CardType.Magic, AbstractCard.CardTarget.None, 2, "Test card 2");
            AbstractCard card_four = new Punch();

            test_deck.AddCard(card_one);
            test_deck.AddCard(card_two);
            test_deck.AddCard(card_three);
            test_deck.AddCard(card_four);

            AbstractCard search_card = new Punch();

            bool expected_result = true;
            //act
            bool result = DeckSearchUtility.DeckHasCard(search_card, test_deck);
            //assert
            Assert.AreEqual(result, expected_result);
        }
        [TestMethod()]
        public void DeckHasCardTest_NOTFOUND1()
        {
            //arrange
            AbstractDeck test_deck = new DEBUG_Deck();
            AbstractCard card_one = new Punch();
            AbstractCard card_two = new DEBUG_Card("Basic:Test1", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.None, 2, "Test card 1");
            AbstractCard card_three = new DEBUG_Card("Basic:Test2", AbstractCard.CardRarity.Rare, AbstractCard.CardType.Magic, AbstractCard.CardTarget.None, 2, "Test card 2");
            AbstractCard card_four = new Punch();

            test_deck.AddCard(card_one);
            test_deck.AddCard(card_two);
            test_deck.AddCard(card_three);
            test_deck.AddCard(card_four);

            AbstractCard serach_card = new DEBUG_Card("Basic:Test3", AbstractCard.CardRarity.Rare, AbstractCard.CardType.Magic, AbstractCard.CardTarget.None, 2, "Test card 2");

            bool expected_result = false;
            //act
            bool result = DeckSearchUtility.DeckHasCard(serach_card, test_deck);
            //assert
            Assert.AreEqual(result, expected_result);
        }
        [TestMethod()]
        public void DeckHasCardTest_NOTFOUND2()
        {
            //arrange
            AbstractDeck test_deck = new DEBUG_Deck();
            AbstractCard card_one = new DEBUG_Card("Basic:Test1", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.None, 2, "Test card 1");
            AbstractCard card_two = new DEBUG_Card("Basic:Test1", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.None, 2, "Test card 1");
            AbstractCard card_three = new DEBUG_Card("Basic:Test2", AbstractCard.CardRarity.Rare, AbstractCard.CardType.Magic, AbstractCard.CardTarget.None, 2, "Test card 2");
            AbstractCard card_four = new DEBUG_Card("Basic:Test2", AbstractCard.CardRarity.Rare, AbstractCard.CardType.Magic, AbstractCard.CardTarget.None, 2, "Test card 2");

            test_deck.AddCard(card_one);
            test_deck.AddCard(card_two);
            test_deck.AddCard(card_three);
            test_deck.AddCard(card_four);

            AbstractCard serach_card = new Punch();

            bool expected_result = false;
            //act
            bool result = DeckSearchUtility.DeckHasCard(serach_card, test_deck);
            //assert
            Assert.AreEqual(result, expected_result);
        }
        [TestMethod()]
        [ExpectedException(typeof(exceptions.NullCardException))]
        public void DeckHasCardTest_NULLCARD()
        {
            //arrange
            AbstractDeck test_deck = new DEBUG_Deck();
            AbstractCard card_one = new DEBUG_Card("Basic:Test1", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.None, 2, "Test card 1");
            AbstractCard card_two = new DEBUG_Card("Basic:Test1", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.None, 2, "Test card 1");
            AbstractCard card_three = new DEBUG_Card("Basic:Test2", AbstractCard.CardRarity.Rare, AbstractCard.CardType.Magic, AbstractCard.CardTarget.None, 2, "Test card 2");
            AbstractCard card_four = new DEBUG_Card("Basic:Test2", AbstractCard.CardRarity.Rare, AbstractCard.CardType.Magic, AbstractCard.CardTarget.None, 2, "Test card 2");

            test_deck.AddCard(card_one);
            test_deck.AddCard(card_two);
            test_deck.AddCard(card_three);
            test_deck.AddCard(card_four);

            AbstractCard serach_card = null;

            //act
            DeckSearchUtility.DeckHasCard(serach_card, test_deck);
            //assert
        }
    }
}