using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoMiner
{
    abstract class World
    {
        protected List<Entity> myEntities = new List<Entity>();
        protected List<Event> myEventList = new List<Event>();
        protected Game1 context;

        protected abstract void BuildWorld();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach(Entity aEntity in myEntities)
            {
                aEntity.Draw(spriteBatch);
            }
        }

        public virtual void UpdateEntities(ControlWrapper controlWrapper)
        {
            foreach (Entity anEntity in myEntities)
            {
                anEntity.Update(controlWrapper);
            }
        }

        public virtual void AddEntity(Entity anEntity)
        {
            if (CheckForDuplicates(anEntity))
            {
                myEntities.Add(anEntity);
            }
        }

        public virtual void RemoveEntity(Entity anEntity)
        {
            myEntities.Remove(anEntity);
        }

        public virtual void ClearEntities()
        {
            myEntities.Clear();
        }

        public virtual Entity FindObject(Location aLocation, Directions aDir)
        {
            if (aDir == Directions.North)
            {
                aLocation.Y -= 20;
            }
            if (aDir == Directions.East)
            {
                aLocation.X += 20;
            }
            if (aDir == Directions.South)
            {
                aLocation.Y += 20;
            }
            if (aDir == Directions.West)
            {
                aLocation.X -= 20;
            }
            foreach (Entity aEnt in myEntities)
            {
                if (aEnt.MyLocation.CheckIfInRange(aLocation)){
                    return aEnt;
                }
            }
            return null;
        }

        protected bool CheckForDuplicates(Entity anEntity)
        {
            foreach (Entity aEntity in myEntities)
            {
                if (aEntity.Equals(anEntity))
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
