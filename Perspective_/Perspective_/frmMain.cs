using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perspective_
{
    public partial class frmMain : Form
    {
        private double t;
        private Graphics g;

        public frmMain()
        {
            InitializeComponent();
            pbxImage.Image = new Bitmap(1280, 720);
            for (int x = 0; x < 1280; x++)
                for (int y = 0; y < 720; y++)
                    ((Bitmap)pbxImage.Image).SetPixel(x, y, Color.White);
            g = Graphics.FromImage(pbxImage.Image);
            pbxImage.Update();

            t = 0;

            tmrRender.Enabled = true;
        }

        public void TestPoint(double time)
        {
            Vector3 point = new Vector3(0, 0, 10);
            Vector2 projection = Render(70, point, new Vector2(1280, -720), new Vector3(0, 0, 0));
            if (double.IsPositiveInfinity(projection.x) || double.IsPositiveInfinity(projection.y))
                return;

            projection.x += 1280 / 2;
            projection.y += 200;
            
            g.FillRegion(new Pen(Color.White).Brush, new Region(new Rectangle(0, 0, 1280, 720)));
            g.DrawEllipse(new Pen(Color.Black), new Rectangle(projection.ToPoint(), new Size(10, 10)));
            pbxImage.Update();
            pbxImage.Refresh();
        }

        public Vector2 Render(double fov, Vector3 point, Vector2 screenRes, Vector3 cameraPos)
        {
            return Render(fov, point - cameraPos, screenRes);
        }

        public Vector2 Render(double fov, Vector3 point, Vector2 screenRes)
        {
            double c = Vector3.Distance(Vector3.Zero, point);
            
            double x = screenRes.x * GetFraction(point.x, c, fov);
            double y = screenRes.y * GetFraction(point.y, c, fov);

            return new Vector2(x, y);
        }
        
        private double GetFraction(double a, double c, double fov)
        {
            double b = (a / c);
            double alpha = Math.Asin(b);
            return ((alpha * (2 / Math.PI) * 360) / fov);
        }

        private void tmrRender_Tick(object sender, EventArgs e)
        {
            TestPoint(t);
            t += 0.1;
        }
    }
}