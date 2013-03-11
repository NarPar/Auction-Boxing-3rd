using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace Auction_Boxing_3.Screens
{
    class Image_MenuItem : MenuItem
    {
        Texture2D image;
        int width, height;

        public Image_MenuItem(Vector2 pos, Texture2D image, int width, int height) 
            : base(pos)
        {
            this.image = image;
            this.width = width;
            this.height = height;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, new Rectangle((int)(currPosX - width / 2), (int)(currPosY - height / 2), width, height), Color.White);
            base.Draw(spriteBatch);
        }
    }
}
