using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MonoMiner
{
    class Stone : Mineable
    {
        protected int Health { get; set; }
        
        public Stone(Location aLocation, Game1 aContext)
        {
            MyTexturePath = "Graphics\\stone";
            base.Initialize(MyTexturePath, aLocation, aContext);
        }

        public override void Update(ControlWrapper aControlWrapper)
        {
            MyTexturePath = "Graphics\\stone";
        }
        
        protected override void UpdateSprite()
        {
            throw new NotImplementedException();
        }

    }
}
