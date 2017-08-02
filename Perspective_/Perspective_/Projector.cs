using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspective_
{
    public class Projector
    {
        public static Vector2 Project(double fov, Vector3 point, Vector2 screenRes, Vector3 cameraPos, Vector3 cameraRot)
        {
            return Project(fov, point, screenRes, cameraPos);
        }

        public static Vector2 Project(double fov, Vector3 point, Vector2 screenRes, Vector3 cameraPos)
        {
            return Project(fov, point - cameraPos, screenRes);
        }

        public static Vector2 Project(double fov, Vector3 point, Vector2 screenRes)
        {
            double dist = Vector3.Distance(Vector3.Zero, point);

            double x = screenRes.x * MathHelper.GetFraction(point.x, dist, fov);
            double y = screenRes.y * MathHelper.GetFraction(point.y, dist, fov);

            return new Vector2(x, y);
        }
    }
}