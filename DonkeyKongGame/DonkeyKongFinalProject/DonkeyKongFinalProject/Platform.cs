using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI;

namespace DonkeyKongFinalProject
{
    internal class Platform : IDrawable, ICollidable
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int newX { get; set; }
        private int newY { get; set; }
        public int Width { get; set; } = 100;
        public int Height { get; set; } = 20;
        public Color color { get; set; } = Colors.Red;
        public int brushWidth { get; set; } = 4;

        public bool CheckCollision(ICollidable other, out CollisionType type)
        {
            type = CollisionType.None;
            return false; // not implemented yet
        }

        public void Draw(CanvasDrawingSession drawingSession)
        {
            
            drawingSession.DrawRectangle(X, Y, Width, Height, color, brushWidth);
            drawingSession.DrawLine(X, Y + Height, X + Width / 4, Y, color, brushWidth);
            drawingSession.DrawLine(X + Width / 4, Y, X + Width / 2, Y + Height, color, brushWidth);
            drawingSession.DrawLine(X + Width / 2, Y + Height, X + Width/4 + Width/2, Y, color, brushWidth);
            drawingSession.DrawLine(X + Width / 4 + Width / 2, Y, X + Width, Y + Height, color, brushWidth);

        }

        public (int top, int bottom, int left, int right) getBounds()
        {
            return (top: Y, bottom: Y + Height, left: X, right: X + Width);
        }

    }
}
