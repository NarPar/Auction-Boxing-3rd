using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Auction_Boxing_3.Screens
{
    class MenuScreen : Screen
    {
        Texture2D bg; // the Background of the menu
        Rectangle bg_Rect; // the screen dimensions
        protected Rectangle clientBounds;
        protected List<MenuItem> items = new List<MenuItem>(); // list of items available on the menu

        // Constructor
        public MenuScreen(Rectangle clientBounds)
            : base()
        {
            this.clientBounds = clientBounds;
            bg_Rect = clientBounds; // save the dimensions of the screen.
        }

        // Load Content
        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            bg = content.Load<Texture2D>("Menu/Menu_bg");

            base.LoadContent(content);
        }

        // Update
        public override void Update(GameTime gameTime)
        {
            foreach (MenuItem item in items)
            {
                item.Update(gameTime);
            }
            base.Update(gameTime);
        }

        // Render
        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(bg, bg_Rect, Color.White); // draw the background
            foreach (MenuItem item in items) // draw the menu items
            {
                item.Draw(spriteBatch);
            }

            base.Draw(spriteBatch);
        }
    }
}
