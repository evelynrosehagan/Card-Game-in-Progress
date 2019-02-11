using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc
{
    class GameApplication
    {
        static GameApplication app;
        public static GameApplication GetInstance()
        {
            if (app == null)
                app = new GameApplication();
            return app;
        }

        public GameModel model;
        public GameView view;
        public GameController controller;

        GameApplication()
        {
            model = new GameModel();
            view = new GameView();
            controller = new GameController();
        }

        public void Notify(string event_path, Object event_target, params object[] event_data)
        {
            controller.Notify(event_path, event_target, event_data);
        }
    }
}
