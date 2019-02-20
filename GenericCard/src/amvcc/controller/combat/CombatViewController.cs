using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc.controller.combat
{
    class CombatViewController : GameEntity
    {
        public override void Notify(string notification, Object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch(separated_path[2])
            {
                case "update":
                    Update();
                    break;

            }
        }
        void Update()
        {
            app.view.combat_view.UpdateEnemyHealth(app.model.combat_model.Arena.Enemy.GetHealth());
            app.view.combat_view.UpdatePlayerHealth(app.model.combat_model.Arena.PlayerCharacter.GetHealth());

        }
    }
}
