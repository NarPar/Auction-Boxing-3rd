using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Auction_Boxing_3.Screens
{
    class Text_MenuItem : MenuItem
    {
        string text;
        SpriteFont font;
        Color colour;

        public Text_MenuItem(Vector2 pos, string text, Color colour, SpriteFont font)
            : base(pos)
        {
            this.text = text;
            this.font = font;
            this.colour = colour;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, text, currPos, colour);
            base.Draw(spriteBatch);
        }
    }
}
