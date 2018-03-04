using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoMiner
{
    abstract class Entity 
    {
        protected Location MyLocation{ get; set; }
        protected Texture2D MyTexture;
        protected string MyTexturePath;
        protected Game context;
        
        public void Initialize(string textureString, Location aLocation, Game aContext)
        { 
            MyLocation = aLocation;
            context = aContext;
            MyTexture = context.Content.Load<Texture2D>(textureString);
        }

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(MyTexture, MyLocation.GetVector2(), null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
        


    }
}
