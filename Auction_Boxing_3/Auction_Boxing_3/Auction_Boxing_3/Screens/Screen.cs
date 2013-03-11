using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Auction_Boxing_3.Screens
{

    public class Screen
    {
        public TransState state;

        // Constructor
        public Screen()
        {

        }

        // Load Content
        public virtual void LoadContent(ContentManager content)
        {

        }

        // Update
        public virtual void Update(GameTime gameTime)
        {

        }

        // Render
        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

        /// <summary>
        /// Tell the screen to start transitioning on
        /// </summary>
        public virtual void SetTransitionOn(double time)
        {
            state = TransState.On;
        }

        /// <summary>
        /// Tell the screen to start transitioning off
        /// </summary>
        public virtual void SetTransitionOff(double time)
        {
            state = TransState.Off;
        }
    }


}
