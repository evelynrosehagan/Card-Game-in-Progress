using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.charactersystem;
using GenericCard.src.basegame.battlesystem;
namespace GenericCard.src.amvcc.model
{
    class CombatModel : GameEntity
    {
        AbstractPlayerCharacter PlayerCharacter;
        AbstractMonster MonsterCharacter;
        AbstractEnvironment EnvironmentCharacter;

        AbstractArena Arena;
    }
}
