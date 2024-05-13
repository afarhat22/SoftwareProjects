using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Windows.Foundation;
using System.Diagnostics;

namespace DonkeyKongFinalProject
{
    internal class Character : ICollidable
    {
        public int X {  get; set; }
        public double Y {  get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool isJumping { get; set; }
        public bool goingLeft { get; set; }
        public bool goingRight { get; set; }
        public bool isOnGround { get; set; }
        public bool isDead { get; set; }

        public CanvasBitmap imageFacingLeft { get; set; }
        public CanvasBitmap imageFacingRight { get; set;}
        public CanvasBitmap currentImage { get; set; }
        public CanvasBitmap deadCharacterImage { get; set; }



        public bool CheckCollision(ICollidable other, out CollisionType type)
        {
            type = CollisionType.None;
            var myBounds = getBounds();
            var otherBounds = other.getBounds();
            

            if (myBounds.bottom > otherBounds.top && myBounds.bottom < otherBounds.bottom  && myBounds.right > otherBounds.left && myBounds.left < otherBounds.right)
            {
                type = CollisionType.Bottom;
                isOnGround = true;
                return true;
                
            }

            
            
            return false;
        }

        public bool CheckCollision(ILethals other, out CollisionType type)
        {
            type = CollisionType.None;
            var myBounds = getBounds();
            var otherBounds = other.getBounds();


            if (myBounds.bottom > otherBounds.top && myBounds.bottom < otherBounds.bottom && myBounds.right > otherBounds.left && myBounds.left < otherBounds.right)
            {
                type = CollisionType.Bottom;
                isOnGround = true;
                return true;

            } else if (myBounds.top < otherBounds.bottom && myBounds.top > otherBounds.top && myBounds.right > otherBounds.left && myBounds.left < otherBounds.right)
            {
                type = CollisionType.Top;
                return true;
            } else if (myBounds.right > otherBounds.left && myBounds.left < otherBounds.left && myBounds.bottom > otherBounds.top && myBounds.top < otherBounds.bottom)
            {
                type = CollisionType.Left;
                return true;
            }



            return false;
        }

        public void Jump()
        {
            if (isOnGround)
            {
                isOnGround = false;
            }
        }

        public (int top, int bottom, int left, int right) getBounds()
        {
            return (top: (int)Y, bottom: (int)Y + height, left: X, right: X + width);
        }

        
    }
}
