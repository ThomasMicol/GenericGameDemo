using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoMiner
{
    class Player : Entity
    {
        protected float moveMult;
        protected Directions facingDirection;

        public Player(Location aLocation, Game aContext)
        {
            MyTexturePath = "Graphics\\player_right";
            moveMult = 5;
            facingDirection = Directions.East;
            base.Initialize(MyTexturePath, aLocation, aContext);
        }

        public override void Update(ControlWrapper aControlWrapper)
        {
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.D)){

                MyLocation.Move(facingDirection, moveMult);
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.W))
            {
                MyLocation.Y -= (int)Math.Round(moveMult);
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.A))
            {
                MyLocation.X -= (int)Math.Round(moveMult);
                SwitchSprite("Graphics\\player_left");
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.S))
            {
                MyLocation.Y += (int)Math.Round(moveMult);
            }
            UpdateSprite();
        }

        protected override void UpdateSprite()
        {
            if(facingDirection == Directions.East)
            {
                SwitchSprite("Graphics\\player_right");
            }
            if(facingDirection == Directions.West)
            {
                SwitchSprite("Graphics\\player_left");
            }
        }


    }
}