using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKongFinalProject.Assets
{
    internal class Vent : ILethals
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public bool active { get; set; }
        public CanvasBitmap currentPhoto { get; set; }
        public CanvasBitmap inactiveImage { get; set; }
        public CanvasBitmap activeImage { get; set; }

        private Stopwatch ventStopWatch = new Stopwatch();

        public (int top, int bottom, int left, int right) getBounds()
        {
            return (top: (int)Y, bottom: (int)Y + height, left: X, right: X + width);
        }

        public bool isActive()
        {
            return active;
        }

        public void checkVentStatus()
        {
            if (!ventStopWatch.IsRunning)
            {
                ventStopWatch.Start();
            }
            else if (ventStopWatch.Elapsed.Seconds > 2)
            {
                ventStopWatch.Reset();
            }
            else if (ventStopWatch.Elapsed.Seconds > 1)
            {
                currentPhoto = activeImage;
                active = true;
            }
            else
            {
                currentPhoto = inactiveImage;
                active = false;
            }
        }

        
    }
}
