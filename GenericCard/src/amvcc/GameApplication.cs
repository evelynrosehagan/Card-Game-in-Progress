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

        }
    }
}
