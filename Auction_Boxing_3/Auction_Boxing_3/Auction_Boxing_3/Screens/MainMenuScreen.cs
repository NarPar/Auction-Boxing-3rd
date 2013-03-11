using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

using Auction_Boxing_3.Easing;

namespace Auction_Boxing_3.Screens
{
    class MainMenuScreen : MenuScreen
    {
        Image_MenuItem glove;
        Image_MenuItem butlerHand;
        Image_MenuItem platter;
        Image_MenuItem picture;

        public MainMenuScreen(Rectangle clientBounds)
            : base(clientBounds)
        {

        }

        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            glove = new Image_MenuItem(new Vector2(clientBounds.X + clientBounds.Width / 4, clientBounds.Y + 3 * clientBounds.Height / 4),
                content.Load<Texture2D>("Menu/Punch_Glove"), 200, 200);

            butlerHand = new Image_MenuItem(new Vector2(clientBounds.X + clientBounds.Width / 4, clientBounds.Y + 3 * clientBounds.Height / 4),
                content.Load<Texture2D>("Menu/ButlerHand_Idle"), 200, 200);

            items.Add(glove);
            items.Add(butlerHand);
            
            base.LoadContent(content);
        }

        /// <summary>
        /// Tell all the items to transition on
        /// </summary>
        public override void SetTransitionOn(double time)
        {

            glove.SetTransitionOn(time, new Vector2(clientBounds.X + clientBounds.Width / 4, clientBounds.Y + 3 * clientBounds.Height / 4), new Vector2(0, clientBounds.Y + 3 * clientBounds.Height / 4),
               1.0f, EasingFunctions.QuadEaseIn, EasingFunctions.Linear);

            butlerHand.SetTransitionOn(time, new Vector2(clientBounds.Width, clientBounds.Y + 5 * clientBounds.Height / 6),
                new Vector2(clientBounds.X + 3 * clientBounds.Width / 4, clientBounds.Y + 3 * clientBounds.Height / 4), 1.0f, EasingFunctions.Linear, EasingFunctions.Linear);
           
            base.SetTransitionOn(time);
        }

        /// <summary>
        /// Tell all the items to transition off
        /// </summary>
        public override void SetTransitionOff(double time)
        {
            base.SetTransitionOff(time);
        }
    }
}
