using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericCard.src.basegame.cardutilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.charactersystem;
using GenericCard.src.basegame.charactersystem.DEBUG;
using GenericCard.src.basegame.cardsystem;

namespace GenericCard.src.basegame.cardutilities.Tests.CardUtilities
{
    [TestClass()]
    public class CardTargettingUtilityTests
    {
        [TestMethod()]
        public void GetPCTargetsTest_Empty()
        {
            //arrange
            AbstractPlayer PC = new DEBUG_PC();
            AbstractPlayer Monster = new DEBUG_Monster();
            AbstractPlayer Environment = new DEBUG_Environment();
            AbstractCard tmp_card = new DEBUG_Card("TEST", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.None, 1, "TEST");
 
            int expected_size = 0;
            //act
            int actual_size = CardTargettingUtility.GetPCTargets(tmp_card, PC, Monster, (AbstractEnvironment)Environment).Count;
            //assert
            Assert.AreEqual(expected_size, actual_size);
        }

        [TestMethod()]
        public void GetPCTargetsTest_SELF()
        {
            //arrange
            AbstractPlayer PC = new DEBUG_PC();
            AbstractPlayer Monster = new DEBUG_Monster();
            AbstractPlayer Environment = new DEBUG_Environment();
            AbstractCard tmp_card = new DEBUG_Card("TEST", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.Self, 1, "TEST");

            List<AbstractPlayer> expected_list = new List<AbstractPlayer>
            {
                PC
            };

            bool expected_equal = true;
            //act
            List<AbstractPlayer> result_list  = CardTargettingUtility.GetPCTargets(tmp_card, PC, Monster, (AbstractEnvironment)Environment);
            bool actual_equal = true;
            for (int i = 0; i < result_list.Count; i++)
            {
                if (!expected_list.Contains(result_list[i]))
                    actual_equal = false;
            }
            for (int i = 0; i < expected_list.Count; i++)
            {
                if (!result_list.Contains(expected_list[i]))
                    actual_equal = false;
            }
            //assert
            Assert.AreEqual(expected_equal, actual_equal);
        }
        [TestMethod()]
        public void GetPCTargetsTest_ALL()
        {
            //arrange
            AbstractPlayer PC = new DEBUG_PC();
            AbstractPlayer Monster = new DEBUG_Monster();
            AbstractPlayer Environment = new DEBUG_Environment();
            AbstractCard tmp_card = new DEBUG_Card("TEST", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.All, 1, "TEST");

            List<AbstractPlayer> expected_list = new List<AbstractPlayer>
            {
                PC,
                Monster,
                Environment
            };
            bool expected_equal = true;
            //act
            List<AbstractPlayer> result_list = CardTargettingUtility.GetPCTargets(tmp_card, PC, Monster, (AbstractEnvironment)Environment);
            bool actual_equal = true;
            for (int i = 0; i < result_list.Count; i++)
            {
                if (!expected_list.Contains(result_list[i]))
                    actual_equal = false;
            }
            for (int i = 0; i < expected_list.Count; i++)
            {
                if (!result_list.Contains(expected_list[i]))
                    actual_equal = false;
            }
            //assert
            Assert.AreEqual(expected_equal, actual_equal);
        }
        [TestMethod()]
        public void GetPCTargetsTest_ENVIRONMENT()
        {
            //arrange
            AbstractPlayer PC = new DEBUG_PC();
            AbstractPlayer Monster = new DEBUG_Monster();
            AbstractPlayer Environment = new DEBUG_Environment();
            AbstractCard tmp_card = new DEBUG_Card("TEST", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.Environment, 1, "TEST");

            List<AbstractPlayer> expected_list = new List<AbstractPlayer>
            {
                Environment
            };
            bool expected_equal = true;
            //act
            List<AbstractPlayer> result_list = CardTargettingUtility.GetPCTargets(tmp_card, PC, Monster, (AbstractEnvironment)Environment);
            bool actual_equal = true;
            for (int i = 0; i < result_list.Count; i++)
            {
                if (!expected_list.Contains(result_list[i]))
                    actual_equal = false;
            }
            for (int i = 0; i < expected_list.Count; i++)
            {
                if (!result_list.Contains(expected_list[i]))
                    actual_equal = false;
            }
            //assert
            Assert.AreEqual(expected_equal, actual_equal);
        }
        [TestMethod()]
        public void GetPCTargetsTest_ENEMY()
        {
            //arrange
            AbstractPlayer PC = new DEBUG_PC();
            AbstractPlayer Monster = new DEBUG_Monster();
            AbstractPlayer Environment = new DEBUG_Environment();
            AbstractCard tmp_card = new DEBUG_Card("TEST", AbstractCard.CardRarity.Common, AbstractCard.CardType.Attack, AbstractCard.CardTarget.Enemy, 1, "TEST");

            List<AbstractPlayer> expected_list = new List<AbstractPlayer>
            {
                Monster
            };
            bool expected_equal = true;
            //act
            List<AbstractPlayer> result_list = CardTargettingUtility.GetPCTargets(tmp_card, PC, Monster, (AbstractEnvironment)Environment);
            bool actual_equal = true;
            for (int i = 0; i < result_list.Count; i++)
            {
                if (!expected_list.Contains(result_list[i]))
                    actual_equal = false;
            }
            for (int i = 0; i < expected_list.Count; i++)
            {
                if (!result_list.Contains(expected_list[i]))
                    actual_equal = false;
            }
            //assert
            Assert.AreEqual(expected_equal, actual_equal);
        }
    }
}