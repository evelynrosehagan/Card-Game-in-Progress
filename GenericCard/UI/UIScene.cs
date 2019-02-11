using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCard.src.amvcc;
namespace GenericCard.UI
{
    abstract class UIScene : GameEntity
    {

        protected bool has_drawn = false;
        public abstract void Draw();
            
    }
}
