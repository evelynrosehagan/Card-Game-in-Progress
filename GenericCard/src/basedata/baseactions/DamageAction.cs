using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.cardsystem;
using GenericCard.src.basegame.cardsystem.action;
using GenericCard.src.basegame.charactersystem;

namespace GenericCard.src.basedata.baseactions 
{
    public class DamageAction : AbstractAttackAction
    {
        int damage;
        public DamageAction(AbstractPlayer input_source, List<AbstractPlayer> input_targets, int in_damage) : base(input_source, input_targets)
        {
            damage = in_damage;
        }

        public override void update()
        {
            foreach(AbstractPlayer player in targets)
            {
                player.Damage(damage);
            }
        }

    }
}
