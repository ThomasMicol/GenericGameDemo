using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoMiner
{
    class Player : Entity
    {
        protected float moveMult;

        public Player(Location aLocation, Game aContext)
        {
            MyTexturePath = "Graphics\\player";
            moveMult = 5;
            base.Initialize(MyTexturePath, aLocation, aContext);
        }

        public override void Update(ControlWrapper aControlWrapper)
        {
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.D)){
                MyLocation.X += (int)Math.Round(moveMult);
                Console.WriteLine("D key pressed");
            }
        }
    }
}