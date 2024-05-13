using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKongFinalProject
{
    internal class flyingLethal : ILethals
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public (int top, int bottom, int left, int right) getBounds()
        {
            return (top: (int)Y, bottom: (int)Y + height, left: X, right: X + width);
        }

        public bool isActive()
        {
            return true;
        }
    }
}
