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

        public void Test(double time)
        {
            Vector3 point = new Vector3(5, Math.Cos(time) * 1, 5 + Math.Sin(time) * 1);
            Vector2 projection = Projector.Project(179, point, new Vector2(1280, 720));
            if (double.IsNaN(projection.x) || double.IsNaN(projection.y))
                return;
            
            projection.x -= 1280 / 2;
            projection.y = -projection.y + 720 / 2;

            Console.WriteLine("x-{0}-y-{1}", projection.x, projection.y);

            g.FillRegion(new Pen(Color.White).Brush, new Region(new Rectangle(0, 0, 1280, 720)));
            g.DrawEllipse(new Pen(Color.Black), new Rectangle(projection.ToPoint(), new Size(10, 10)));
            pbxImage.Update();
            pbxImage.Refresh();
        }
        
        private void tmrRender_Tick(object sender, EventArgs e)
        {
            Test(t);
            t += 0.01;
        }
    }
}