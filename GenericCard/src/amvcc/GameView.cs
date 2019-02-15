using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.amvcc.view;
using GenericCard.UI;
namespace GenericCard.src.amvcc
{
    class GameView : GameEntity
    {
        public UIScene uiscene;
        public CombatView combat_view;
        public void LoadScene(UIScene newscene)
        {
            try
            {
                uiscene = newscene;
                uiscene.Draw();
                combat_view = new CombatView();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("ERROR >> new scene is null");
            }
        }
    }
}
