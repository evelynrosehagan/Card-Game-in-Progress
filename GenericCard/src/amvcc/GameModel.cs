using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.amvcc.model;
using GenericCard.src.basegame.battlesystem;
using GenericCard.src.basegame.charactersystem;
namespace GenericCard.src.amvcc
{
    class GameModel : GameEntity
    {
        public AbstractPlayerCharacter player_character;

        public CombatModel combat_model;
        public OverworldModel overworld_model;
        ModelState current_model_state;
        public enum ModelState
        {
            Overworld,
            Combat,
            Shop
        }
        public void SetModelState(ModelState input_state)
        {
            current_model_state = input_state;
        }
        public void InitializeCombat(AbstractPlayerCharacter PC, AbstractMonster Monster, AbstractEnvironment Environment)
        {
            SetModelState(ModelState.Combat);
            combat_model = new CombatModel(PC, Monster, Environment);
        }

    }
}
