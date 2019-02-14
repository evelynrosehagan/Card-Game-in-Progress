using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericCard.src.basegame.cardutilities;
using GenericCard.src.basedata.basecards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.cardsystem;

namespace GenericCard.src.basegame.cardutilities.Tests.CardUtilities
{
    [TestClass()]
    public class CardIDUtilitiesTests
    {
        [TestMethod()]
        public void GetCardFactionTest()
        {
            //arrange
            AbstractCard test_card = new Punch();
            string expected_result = "Basic";
            //act
            string actual_result = CardIDUtilities.GetCardFaction(test_card);
            //assert
            Assert.AreEqual(actual_result, expected_result);
        }
        [TestMethod()]
        public void GetCardFactionTest_Invalid()
        {
            //arrange
            AbstractCard test_card = new DEBUG_Card("ThisIsACardNameWow", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.All, 2, "DEBUG_CARD");
            string expected_result = "";
            //act
            string actual_result = CardIDUtilities.GetCardFaction(test_card);
            //assert
            Assert.AreEqual(actual_result, expected_result);
        }

        [TestMethod()]
        public void IsValidCardIDTest_Valid()
        {
            //arrange
            AbstractCard test_card = new Punch();
            bool expected_result = true;
            //act
            bool actual_result = CardIDUtilities.IsValidCardID(test_card);
            //assert
            Assert.AreEqual(actual_result, expected_result);
        }
        [TestMethod()]
        public void IsValidCardIDTest_NullString()
        {
            //arrange
            AbstractCard test_card = new DEBUG_Card(null, AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.All, 2, "DEBUG_CARD");
            bool expected_result = false;
            //act
            bool actual_result = CardIDUtilities.IsValidCardID(test_card);
            //assert
            Assert.AreEqual(actual_result, expected_result);
        }
        [TestMethod()]
        public void IsValidCardIDTest_InvalidString()
        {
            //arrange
            AbstractCard test_card = new DEBUG_Card("ThisIsACardNameWow", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.All, 2, "DEBUG_CARD");
            bool expected_result = false;
            //act
            bool actual_result = CardIDUtilities.IsValidCardID(test_card);
            //assert
            Assert.AreEqual(actual_result, expected_result);
        }
    }
}