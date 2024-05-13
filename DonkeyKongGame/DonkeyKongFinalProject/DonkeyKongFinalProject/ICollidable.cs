using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace DonkeyKongFinalProject
{
    internal interface ICollidable
    {
        (int top, int bottom, int left, int right) getBounds();
        bool CheckCollision(ICollidable other, out CollisionType type);
    }

    public enum CollisionType
    {
        None,
        Top,
        Bottom,
        Left,
        Right
    }
}
