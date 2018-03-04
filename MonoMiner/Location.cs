using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoMiner
{
    class Location
    {
        protected int x;
        protected int y;
        protected Game myContext;

        public int X { get; set; }
        public int Y { get; set; }

        public Location(int inX, int inY, Game aContext)
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
    }
}
