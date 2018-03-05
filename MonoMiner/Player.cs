using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoMiner
{
    class Player : Entity
    {
        protected int moveMult;
        protected Directions facingDirection;
        private int pickStrength = 10;

        public Player(Location aLocation, Game1 aContext)
        {
            MyTexturePath = "Graphics\\player_right";
            myWidth = 120;
            myHeight = 160;
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
                facingDirection = Directions.West;
                MyLocation.Move(facingDirection, moveMult);
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.S))
            {
                facingDirection = Directions.South;
                MyLocation.Move(facingDirection, moveMult);
            }
            if (aControlWrapper.GetKeyboardState().IsKeyDown(Keys.Space))
            {
                SwingPick();
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

        protected void SwingPick()
        {
            Console.WriteLine("You swing your pick");
            if (context.GetWorld().FindObject(MyLocation, facingDirection) is Mineable aMineableSpot)
            {
                aMineableSpot = (Mineable)context.GetWorld().FindObject(MyLocation, facingDirection);
                aMineableSpot.Mine(pickStrength);
            }else
            {
                Console.WriteLine("Your swing fails to find its mark. How embarassing!");
            }
            
        }


    }
}