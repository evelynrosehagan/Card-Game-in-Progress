using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeonBit.UI;
using GeonBit.UI.Entities;
using Microsoft.Xna.Framework;

namespace GenericCard.UI
{
    class menu_DebugMenu1
    {
        public bool has_drawn = false;
        bool serialized = false;
        public void Draw()
        {
            if (has_drawn)
                return;
            UserInterface.Active.Clear();
            Panel panel = new Panel(new Vector2(300, 400));
            UserInterface.Active.AddEntity(panel);

            Button btn_scene_1 = new Button("Open Scene 1");
            btn_scene_1.OnClick = (Entity btn) =>
            {
                Console.WriteLine("Opening Demo Scene 1");
            };
            panel.AddChild(btn_scene_1);

            Button btn_scene_2 = new Button("Open Scene 2");
            btn_scene_2.OnClick = (Entity btn) =>
             {
                 Console.WriteLine("Opening Demo Scene 2");
             };
            panel.AddChild(btn_scene_2);

            Button btn_scene_3 = new Button("Open Scene 3");
            btn_scene_3.OnClick = (Entity btn) =>
             {
                 Console.WriteLine("Opening Demo Scene 3");
             };
            panel.AddChild(btn_scene_3);

            Button btn_scene_4 = new Button("Open Scene 4");
            btn_scene_4.OnClick = (Entity btn) =>
             {
                 Console.WriteLine("Opening Demo Scene 4");
             };
            panel.AddChild(btn_scene_4);

            Button btn_scene_5 = new Button("Open Scene 5");
            btn_scene_5.OnClick = (Entity btn) =>
             {
                 Console.WriteLine("Opening Demo Scene 5");
             };
            panel.AddChild(btn_scene_5);
            has_drawn = true;
        }
        public void Serialize()
        {
            if (serialized)
                return;
            UserInterface.Active.Serialize("debug_menu_1.xml");
            serialized = true;
        }
    }
}
