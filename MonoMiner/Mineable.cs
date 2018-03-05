using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoMiner
{
    class Mineable : Entity
    {
        protected int myHealth;

        public virtual void Mine(int pickStrength)
        {
            myHealth -= pickStrength;
        }
    }
}
