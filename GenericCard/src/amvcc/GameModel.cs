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

        CombatModel combat_model;
        OverworldModel overworld_model;

        public enum CurrentModelState
        {
            Overworld,
            Combat,
            Shop
        }
    }
}
