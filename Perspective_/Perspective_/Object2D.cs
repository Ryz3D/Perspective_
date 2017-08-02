using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspective_
{
    public class Object2D
    {
        public Vector2 Position;

        public double Rotation;

        public Object2D() : this(Vector2.Zero, 0) { }

        public Object2D(Vector2 pos, double rot)
        {
            Position = pos;
            Rotation = rot;
        }
    }
}