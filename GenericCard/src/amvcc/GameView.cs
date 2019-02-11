using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.UI;
namespace GenericCard.src.amvcc
{
    class GameView : GameEntity
    {
        public UIScene uiscene;

        public void LoadScene(UIScene newscene)
        {
            try
            {
                uiscene = newscene;
                uiscene.Draw();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("ERROR >> new scene is null");
            }
        }
    }
}
