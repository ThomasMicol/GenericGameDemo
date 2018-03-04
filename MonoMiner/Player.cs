using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MonoMiner
{
    class Player : Entity
    {

        public Player(Location aLocation, Game aContext)
        {
            MyTexturePath = "Graphics\\player";
            base.Initialize(MyTexturePath, aLocation, aContext);
        }

        public override void Update()
        {
            Console.WriteLine(MyTexturePath);
        }
    }
}
