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
                facingDirection = Directions.East;
                MyLocation.Move(facingDirection, moveMult);
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.W))
            {
                facingDirection = Directions.North;
                MyLocation.Move(facingDirection, moveMult);
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.A))
            {
                facingDirection = Directions.East;
                MyLocation.Move(facingDirection, moveMult);
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.S))
            {
                facingDirection = Directions.South;
                MyLocation.Move(facingDirection, moveMult);
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