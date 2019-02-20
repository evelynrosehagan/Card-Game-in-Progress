using GenericCard.src.basegame.charactersystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.basegame.battlesystem
{
    class DEBUG_Arena : AbstractArena
    {
        public DEBUG_Arena(AbstractPlayerCharacter PC, AbstractMonster enemy, AbstractEnvironment envi) :
            base(PC, enemy, envi)
        {

        }
    }
}
