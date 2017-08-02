using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspective_
{
    public class Vector2
    {
        public double x, y;

        public Vector2() : this(0, 0) { }
        
        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point ToPoint()
        {
            return new Point((int)Math.Round(x), (int)Math.Round(y));
        }

        public static double Distance(Vector2 a, Vector2 b)
        {
            Vector2 s = b - a;
            return Math.Sqrt(Math.Pow(s.x, 2) + Math.Pow(s.y, 2));
        }

        public static Vector2 Average(Vector2 a, Vector2 b)
        {
            return new Vector2((a.x + a.x) / 2, (a.y + a.y) / 2);
        }

        public static Vector2 operator +(Vector2 a, double d)
        {
            return new Vector2(a.x + d, a.y + d);
        }

        public static Vector2 operator -(Vector2 a, double d)
        {
            return new Vector2(a.x - d, a.y - d);
        }

        public static Vector2 operator *(Vector2 a, double d)
        {
            return new Vector2(a.x * d, a.y * d);
        }

        public static Vector2 operator /(Vector2 a, double d)
        {
            return new Vector2(a.x / d, a.y / d);
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator *(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x * b.x, a.y * b.y);
        }

        public static Vector2 operator /(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x / b.x, a.y / b.y);
        }

        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return a.x != b.x && a.y != b.y;
        }

        public static readonly Vector2 Zero = new Vector2();
        public static readonly Vector2 One = new Vector2(1, 1);
        public static readonly Vector2 Infinity = One * double.PositiveInfinity;
    }
}