using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.amvcc.controller;
using GenericCard.src.notifications;
namespace GenericCard.src.amvcc
{
    class GameController : GameEntity
    {
        SystemController systemController;
        SceneController sceneController;
        CombatController combatController;
        public GameController()
        {
            sceneController = new SceneController();
            combatController = new CombatController();
            systemController = new SystemController();
        }
        public override void Notify(string notification, Object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch(separated_path[0])
            {
                case "scene":
                    sceneController.Notify(notification, event_target, event_data);
                    break;
                case "combat":
                    combatController.Notify(notification, event_target, event_data);
                    break;
                case "system":
                    systemController.Notify(notification, event_target, event_data);
                    break;
            }
        }
    }
}
