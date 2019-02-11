using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.notifications
{
    public static class GameStateNotifications
    {
        public const string PlayerDeath = "player.death";
        public const string GameClose = "game.close";
        public const string GamePause = "game.pause";
        public const string GameUnpause = "game.unpause";
    }
}
