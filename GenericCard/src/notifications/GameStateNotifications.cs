using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.notifications
{
    public static class GameStateNotifications
    {
        public static readonly string PlayerDeath = "player.death";
        public static readonly string GameClose = "game.close";
        public static readonly string GamePause = "game.pause";
        public static readonly string GameUnpause = "game.unpause";
    }
}
