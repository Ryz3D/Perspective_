using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspective_
{
    public class MathHelper
    {
        public static double GetFraction(double a, double distance, double fov)
        {
            double b = (a / distance);
            double alpha = Math.Asin(b);
            return (alpha * 2 / Math.PI * 360) / fov;
        }
    }
}