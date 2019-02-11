using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeonBit.UI;
using GeonBit.UI.Entities;

namespace GenericCard.UI
{
    class debug_CombatTester : UIScene
    {
        public override void Draw()
        {
            if (has_drawn)
                return;
            UserInterface.Active.Clear();
            RichParagraph player_health = new RichParagraph("{{RED}}player_health", Anchor.BottomLeft);
            UserInterface.Active.AddEntity(player_health);

            RichParagraph enemy_health = new RichParagraph("{{RED}}enemy_health", Anchor.BottomRight);
            UserInterface.Active.AddEntity(enemy_health);

            Button rtn_menu = new Button("Return to Debug1", ButtonSkin.Fancy, Anchor.TopCenter);
            rtn_menu.OnClick = (Entity btn) =>
            {
                Console.WriteLine("Opening Debug Menu 1");
                app.Notify(src.notifications.UINotifications.LoadNewScene, this, "debug.menu1");
            };
            UserInterface.Active.AddEntity(rtn_menu);
            has_drawn = true;
        }
    }
}
