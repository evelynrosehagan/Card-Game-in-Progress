using GenericCard.src.basegame.battlesystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc.controller.combat
{
    class ArenaController : GameEntity
    {
        public void Notify(string notification, Object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch (separated_path[2])
            {
                case "process":
                    Process();
                    break;
            }
        }
        void Process()
        {
            AbstractArena.actionManager.Process();
            app.Notify(notifications.CombatEventNotification.UpdateBattleView, this, null);
        }
    }
}
