using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspective_
{
    public class Object3D
    {
        public Vector3 Position, Rotation;

        public Object3D() : this(Vector3.Zero, Vector3.Zero) { }

        public Object3D(Vector3 pos, Vector3 rot)
        {
            Position = pos;
            Rotation = rot;
        }
    }
}