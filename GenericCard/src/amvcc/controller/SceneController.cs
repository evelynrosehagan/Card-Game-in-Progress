using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.notifications;
using GenericCard.UI;
namespace GenericCard.src.amvcc.controller
{
    class SceneController : GameEntity
    {
        public override void Notify(string notification, Object event_target, params object[] event_data)
        {
            switch(notification)
            {
                case UINotifications.LoadNewScene:
                    LoadScene((string)event_data[0]);
                    break;
            }
        }

        void LoadScene(string scene_name)
        {
            UIScene new_scene = null;
            switch(scene_name)
            {
                case "debug.menu1":
                    new_scene = new menu_DebugMenu1();
                    break;
                case "debug.combat1":
                    new_scene = new debug_CombatTester();
                    break;
                default:
                    Console.WriteLine("ERROR >> Cannot load scene with name of " + scene_name);
                    break;
            }
            app.view.LoadScene(new_scene) ;
        }
    }
}
