using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.UI
{
    abstract class UIScene
    {
        protected bool has_drawn = false;
        public abstract void Draw();
            
    }
}
