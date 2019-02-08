using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.cardsystem;
namespace GenericCard.src.basegame.charactersystem
{
    public abstract class AbstractPlayer
    {
        int health;
        int healthmax;

        AbstractDeck player_deck;

        #region Health Functions
        public void Heal(int health_gained)
        {
            health += health_gained;
            if (health > healthmax)
                health = healthmax;
        }
        public void Damage(int health_lost)
        {
            health -= health_lost;
            if (health < 0)
                health = 0;
        }
        public void SetHealth(int health_in)
        {
            health = health_in;
            if (health > healthmax)
                health = healthmax;
        }
        public int GetHealth()
        {
            return health;
        }
        #endregion


    }
}
