using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCard.src.amvcc
{
    abstract class GameEntity
    {
        protected GameApplication app
        {
            get { return GameApplication.GetInstance(); }
        }

    }
}
