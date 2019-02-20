using GenericCard.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc.controller
{
    class SystemController : GameEntity
    {
        public override void Notify(string notification, object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch(separated_path[1])
            {
                case "game":
                    NotifyGame(notification, event_target, event_data);
                    break;
            }
        }
        public void NotifyGame(string notification, object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch (separated_path[2])
            {
                case "combat":
                    StartCombat();
                    break;
                case "debugcombat":
                    StartDebugCombat();
                    break;
            }
        }

        void StartCombat()
        { 
            throw new NotImplementedException();

        }
        void StartDebugCombat()
        {
            app.model.SetModelState(GameModel.ModelState.Combat);
            app.Notify(notifications.UINotifications.LoadNewScene, this, "debug.combat1");
            app.model.InitializeCombat(new basegame.charactersystem.AbstractPlayerCharacter(),
                new basegame.charactersystem.AbstractMonster(),
                new basegame.charactersystem.AbstractEnvironment());
            app.view.combat_view.GetReferences();
            app.Notify(notifications.CombatEventNotification.UpdateBattleView, this, null);
        }
    }
}
