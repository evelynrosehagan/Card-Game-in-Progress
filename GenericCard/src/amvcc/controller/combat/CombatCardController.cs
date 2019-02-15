using GenericCard.src.basegame.cardsystem;
using GenericCard.src.basegame.charactersystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc.controller.combat
{
    class CombatCardController : GameEntity
    {
        public void Notify(string notification, Object event_target, params object[] event_data)
        {
            string[] separated_path = notification.Split('.');
            switch(separated_path[2])
            {
                case "play":
                    PlayCard(notification, event_target, event_data);
                    break;
            }

        }

        void PlayCard(string notification, Object event_target, params object[] event_data)
        {
            AbstractCard card = (AbstractCard)event_data[0];
            AbstractPlayer player = (AbstractPlayer)event_data[1];
            AbstractPlayer enemy = (AbstractPlayer)event_data[2];
            AbstractEnvironment environment = (AbstractEnvironment)event_data[3];

            card.use(player, enemy, environment);
            app.Notify(notifications.CombatEventNotification.ProcessActions, this, null);
        }
    }
}
