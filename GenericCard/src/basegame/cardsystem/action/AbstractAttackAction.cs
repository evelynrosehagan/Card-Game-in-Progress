using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.charactersystem;
namespace GenericCard.src.basegame.cardsystem.action
{
    public class AbstractAttackAction : AbstractAction
    {
        AbstractPlayer source;
        protected List<AbstractPlayer> targets;
        public AbstractAttackAction(AbstractPlayer input_source, List<AbstractPlayer> input_targets)
        {
            source = input_source;
            targets = input_targets;
        }

        public override void update()
        {
            throw new NotImplementedException();
        }
    }
}
