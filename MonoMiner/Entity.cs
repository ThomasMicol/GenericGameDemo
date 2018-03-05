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

        protected abstract void UpdateSprite();
        
        public void Initialize(string textureString, Location aLocation, Game aContext)
        { 
            MyLocation = aLocation;
            context = aContext;
            MyTexture = context.Content.Load<Texture2D>(textureString);
        }

        public abstract void Update(ControlWrapper aControlWrapper);

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(MyTexture, MyLocation.GetVector2(), null, Color.White, 0f, Vector2.Zero, 5f, SpriteEffects.None, 0f);
        }
        
        public virtual void SwitchSprite(string newPath)
        {
            MyTexturePath = newPath;
            MyTexture = context.Content.Load<Texture2D>(MyTexturePath);
        }


    }
}
