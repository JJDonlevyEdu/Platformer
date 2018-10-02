using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    class Player
    {
        Sprite playerSprite = new Sprite();

        public Player()
        {

        }

        public void Load(ContentManager content)
        {
            playerSprite.Load(content, "hero");
        }
        public void Update(float deltaTime)
        {
            playerSprite.Update(deltaTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            playerSprite.Draw(spriteBatch);
        }
    }
}
