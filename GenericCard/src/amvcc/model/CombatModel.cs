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
        public CombatModel(AbstractPlayerCharacter PC, AbstractMonster monster, AbstractEnvironment environment)
        {
            PlayerCharacter = PC;
            MonsterCharacter = monster;
            EnvironmentCharacter = environment;

            Arena = new DEBUG_Arena(PC, monster, environment);
        }
        AbstractPlayerCharacter PlayerCharacter;
        AbstractMonster MonsterCharacter;
        AbstractEnvironment EnvironmentCharacter;

        public AbstractArena Arena;

        public override void Notify(string notification, object event_target, params object[] event_data)
        {
            throw new NotImplementedException();
        }
    }
}
