using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MonoMiner
{
    abstract class Entity 
    {
        public Location MyLocation{ get; set; }
        protected Texture2D MyTexture;
        protected string MyTexturePath;
        protected Game1 context;
        
        public void Initialize(string textureString, Location aLocation, Game1 aContext)
        { 
            MyLocation = aLocation;
            context = aContext;
            MyTexture = context.Content.Load<Texture2D>(textureString);
        }

        public virtual void Update(ControlWrapper aControlWrapper)
        {
            throw new NotImplementedException();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(MyTexture, MyLocation.GetVector2(), null, Color.White, 0f, Vector2.Zero, 5f, SpriteEffects.None, 0f);
        }
        
        public virtual void SwitchSprite(string newPath)
        {
            MyTexturePath = newPath;
            MyTexture = context.Content.Load<Texture2D>(MyTexturePath);
        }

        protected virtual void UpdateSprite()
        {
            throw new NotImplementedException();
        }


    }
}
