using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.basegame.charactersystem;

namespace GenericCard.src.basegame.cardsystem
{
    public class DEBUG_Card : AbstractCard
    {
        public DEBUG_Card(string inp_ID, CardRarity crarity, CardType ctype, CardTarget ctarget, int ccost, string cdescription)
            : base(inp_ID, crarity, ctype, ctarget, ccost, cdescription)
        {
        }

        public override void use(AbstractPlayer Self, AbstractPlayer Enemy, AbstractEnvironment Environment)
        {
            throw new NotImplementedException();
        }
    }
}
