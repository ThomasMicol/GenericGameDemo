using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MonoMiner
{
    class Stone : Entity
    {
        protected int Health { get; set; }
        
        public Stone(Location aLocation, Game aContext)
        {
            MyTexturePath = "Graphics\\stone";
            base.Initialize(MyTexturePath, aLocation, aContext);
        }

        public override void Update(ControlWrapper aControlWrapper)
        {
            Console.WriteLine(MyTexturePath);
        }

    }
}
