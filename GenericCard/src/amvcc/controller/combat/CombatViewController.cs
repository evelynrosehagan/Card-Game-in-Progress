using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc.controller.combat
{
    class CombatViewController : GameEntity
    {
        public void Notify(string notification, Object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch(separated_path[1])
            {
                case "update":
                    Update();
                    break;

            }
        }
        void Update()
        {
            app.view.combat_view.UpdateEnemyHealth(app.model.combat_model.)
        }
    }
}
