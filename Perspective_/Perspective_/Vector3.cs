using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspective_
{
    public class Vector3
    {
        public double x, y, z;

        public Vector3() : this(0, 0, 0) { }

        public Vector3(double x, double y) : this(x, y, 0) { }

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 Average(Vector3 a, Vector3 b)
        {
            return new Vector3((a.x + a.x) / 2, (a.y + a.y) / 2, (a.z + a.z) / 2);
        }

        public static double Distance(Vector3 a, Vector3 b)
        {
            Vector3 s = b - a;
            return Math.Sqrt(Math.Pow(s.x, 2) + Math.Pow(s.y, 2) + Math.Pow(s.z, 2));
        }

        public static Vector3 operator +(Vector3 a, double d)
        {
            return new Vector3(a.x + d, a.y + d, a.z + d);
        }

        public static Vector3 operator -(Vector3 a, double d)
        {
            return new Vector3(a.x - d, a.y - d, a.z - d);
        }

        public static Vector3 operator *(Vector3 a, double d)
        {
            return new Vector3(a.x * d, a.y * d, a.z * d);
        }

        public static Vector3 operator /(Vector3 a, double d)
        {
            return new Vector3(a.x / d, a.y / d, a.z / d);
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public static Vector3 operator /(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z);
        }

        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return a.x != b.x && a.y != b.y && a.z != b.z;
        }

        public static readonly Vector3 Zero = new Vector3();
        public static readonly Vector3 One = new Vector3(1, 1, 1);
        public static readonly Vector3 Infinity = One * double.PositiveInfinity;
    }
}