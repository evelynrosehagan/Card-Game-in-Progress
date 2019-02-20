using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.amvcc.controller.combat;
namespace GenericCard.src.amvcc.controller
{
    class CombatController : GameEntity
    {
        CombatCardController card_combat_controller;
        ArenaController arena_controller;
        CombatViewController combat_view_controller;
        public CombatController()
        {
            card_combat_controller = new CombatCardController();
            arena_controller = new ArenaController();
            combat_view_controller = new CombatViewController();
        }
        public override void Notify(string notification, Object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch(separated_path[1])
            {
                case "card":
                    card_combat_controller.Notify(notification, event_target, event_data);
                    break;
                case "arena":
                    arena_controller.Notify(notification, event_target, event_data);
                    break;
                case "view":
                    combat_view_controller.Notify(notification, event_target, event_data);
                    break;

            }
        }
        
    }
}
