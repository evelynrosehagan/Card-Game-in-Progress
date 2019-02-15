using GeonBit.UI;
using GeonBit.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc.view
{
    class CombatView : GameEntity
    {
        RichParagraph player_health;
        RichParagraph enemy_health;
        public void GetReferences()
        {
            player_health = UserInterface.Active.Root.Find<RichParagraph>("player_health"); 
            enemy_health = UserInterface.Active.Root.Find<RichParagraph>("enemy_health"); 
        }
        public void UpdatePlayerHealth(int value)
        {
            player_health.Text = value.ToString();
        }
        public void UpdateEnemyHealth(int value)
        {
            enemy_health.Text = value.ToString();
        }
    }
}
