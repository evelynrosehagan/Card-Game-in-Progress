using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.notifications
{
    public static class GameStateNotifications
    {
        public const string PlayerDeath = "system.player.death";
        public const string GameClose = "system.game.close";
        public const string GamePause = "system.game.pause";
        public const string GameUnpause = "system.game.unpause";

        //Start New States
        public const string StartCombat = "system.game.combat";
        public const string StartDebugCombat = "system.game.debugcombat";
    }
}
