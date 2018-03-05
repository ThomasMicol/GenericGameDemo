using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;

namespace MonoMiner
{
    class Location
    {
        protected Game1 myContext;

        public int X { get; set; }
        public int Y { get; set; }

        public Location(int inX, int inY, Game1 aContext)
        {
            myContext = aContext;
            X = inX;
            Y = inY;
        }

        public Vector2 GetVector2()
        {
            Vector2 vect = new Vector2(X, Y);
            return vect;
        }

        public void Move(Directions aDir, int moveSpeed)
        {
            if(aDir == Directions.North)
            {
                Y -= moveSpeed;
            }
            if (aDir == Directions.East)
            {
                X += moveSpeed;
            }
            if (aDir == Directions.South)
            {
                Y += moveSpeed;
            }
            if (aDir == Directions.West)
            {
                X -= moveSpeed;
            }
            X = MathHelper.Clamp(X, 0, myContext.GraphicsDevice.Viewport.Width - 105);
            Y = MathHelper.Clamp(Y, 0, myContext.GraphicsDevice.Viewport.Height - 155);
        }

        public bool CheckIfInRange(Location aLocation)
        {
            if(Enumerable.Range(X-20, X+20).Contains(aLocation.X) && Enumerable.Range(Y - 20, Y + 20).Contains(aLocation.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
