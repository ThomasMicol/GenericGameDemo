using System;
using Microsoft.Xna.Framework;

namespace MonoMiner
{
    class World1 : World
    {
        public World1(Game1 aContext)
        {
            context = aContext;
            BuildWorld();
        }

        protected override void BuildWorld()
        {
            myEntities.Add(new Stone(new Location(3, 5, context), context));
            myEntities.Add(new Player(new Location(60, 40, context), context));
        }

    }
}
