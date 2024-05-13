using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyKongFinalProject
{
    internal interface ILethals
    {
        (int top, int bottom, int left, int right) getBounds();
        bool isActive();

    }
}
