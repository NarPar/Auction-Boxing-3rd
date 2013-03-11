using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;
using Auction_Boxing_3.Easing;

namespace Auction_Boxing_3.Screens
{
    public enum TransState
    {
        On,
        Idle,
        Off
    }

    class MenuItem
    {
        public delegate double EasingFunction(double t, double b, double c, double d);

        Vector2 startPos;
        protected Vector2 currPos;
        protected double currPosX;
        protected double currPosY;
        Vector2 targPos;
        double startTime;
        float transDuration;
        TransState state;

        EasingFunction easeX;
        EasingFunction easeY;

        public MenuItem(Vector2 pos)
        {
            currPos = pos;
            currPosX = (double)pos.X;
            currPosY = (double)pos.Y;
            state = TransState.Idle;
        }


        public virtual void Update(GameTime gameTime)
        {
            if (state == TransState.On || state == TransState.Off)
            {
                Transition(gameTime);
            }
            /*TransitionOn(gameTime);
        }
        else if (state == TransState.Off)
        {
            TransitionOff(gameTime);
        }*/
            else if (state == TransState.Idle)
            {
                UpdateIdle();
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
        }

        
        protected void Transition(GameTime gameTime)
        {
            double dt = gameTime.TotalGameTime.TotalSeconds - startTime;

            if (dt >= transDuration)
                state = TransState.Idle;

     

            // Ease X
            currPosX = easeX(dt, (double)startPos.X, (double)targPos.X, (double)transDuration);//EasingFunctions.BounceEaseOut(dt, (double)startPos.X, (double)targPos.X, (double)transDuration);

            //Ease Y
            currPosY = easeY(dt, (double)startPos.Y, (double)targPos.Y, (double)transDuration);//EasingFunctions.Linear(dt, (double)startPos.Y, (double)targPos.Y, (double)transDuration);

            


            //Debug.WriteLine("item moved! " + currPosX + ", " + currPosY);
        }
        /*
        protected void TransitionOn(GameTime gameTime)
        {
            // Ease X
            currPos.X = (float)EasingFunctions.BounceEaseOut(gameTime.ElapsedGameTime.TotalSeconds, (double)startPos.X, (double)targPos.X, (double)transDuration);

            //Ease Y
            currPos.Y = (float)EasingFunctions.BounceEaseOut(gameTime.ElapsedGameTime.TotalSeconds, (double)startPos.Y, (double)targPos.Y, (double)transDuration);
        }

        protected void TransitionOff(GameTime gameTime)
        {
            // Ease X
            currPos.X = (float)EasingFunctions.BounceEaseOut(gameTime.ElapsedGameTime.TotalSeconds, (double)startPos.X, (double)targPos.X, (double)transDuration);

            //Ease Y
            currPos.Y = (float)EasingFunctions.BounceEaseOut(gameTime.ElapsedGameTime.TotalSeconds, (double)startPos.Y, (double)targPos.Y, (double)transDuration);
        }*/

        protected void UpdateIdle()
        {

        }

        public void SetTransitionOn(double time, Vector2 start, Vector2 end, float dur, EasingFunction funcX, EasingFunction funcY)
        {
            startPos = start;
            targPos = end;
            currPos = startPos;
            currPosX = (double)startPos.X;
            currPosY = (double)startPos.Y;

            easeX = funcX;
            easeY = funcY;

            startTime = time;
            transDuration = dur;

            state = TransState.On;

            Debug.WriteLine("Item Set to transition on!");
        }

        public void SetTransitionOff(double time, Vector2 start, Vector2 end, float dur, EasingFunction funcX, EasingFunction funcY)
        {
            startPos = start;
            targPos = end;
            currPos = startPos;
            currPosX = (double)startPos.X;
            currPosY = (double)startPos.Y;

            easeX = funcX;
            easeY = funcY;

            startTime = time;
            transDuration = dur;

            state = TransState.Off;
        }

    }
}
