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
        AbstractPlayerCharacter PlayerCharacter;
        AbstractMonster Enemy;
        AbstractEnvironment Environment;

        public static ActionManager actionManager;
    }
}
