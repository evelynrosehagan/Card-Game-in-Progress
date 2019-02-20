using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.charactersystem;
namespace GenericCard.src.basegame.battlesystem
{
    abstract class AbstractArena
    {
        public AbstractPlayerCharacter PlayerCharacter;
        public AbstractMonster Enemy;
        public AbstractEnvironment Environment;

        public static ActionManager actionManager;

        public AbstractArena(AbstractPlayerCharacter PC, AbstractMonster enemy, AbstractEnvironment envi)
        {
            actionManager = new ActionManager();
            PlayerCharacter = PC;
            Enemy = enemy;
            Environment = envi;

        }
    }
}
