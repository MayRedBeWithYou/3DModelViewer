using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DModelViewer
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Render.Clear(bitmap);
            Canvas.Image = bitmap;
            Point3 p1 = new Point3(0, 2, 1);
            Point3 p2 = new Point3(2, 0, 1);
            Point3 p3 = new Point3(0, 0, 1);
            Triangle t = new Triangle(p1, p2, p3);
            Color c = Color.Red;
            Morph(t);
        }

        public void Morph(Triangle t)
        {
            Color c = Color.Red;

            List<Point> points = new List<Point>();
            Vector up = new Vector(0, 1, 0, 0);
            Point3 pos = new Point3(0, -2, -2);
            Point3 T = new Point3(1, 1, 0);
            Vector D = pos.V - T.V;
            Vector R = Vector.Cross(up, D);
            Vector U = Vector.Cross(D, R);

            Matrix View = new Matrix(R.X, U.Y, D.Z, 1);
            View[0, 1] = R.Y;
            View[0, 2] = R.Z;
            View[1, 0] = U.X;
            View[1, 2] = U.Z;
            View[2, 0] = D.X;
            View[2, 1] = D.Y;
            View = View * Matrix.Translate(pos.V);

            Matrix Proj = Matrix.Proj(60, 0.1f, 100f, Canvas.Width / Canvas.Height);
            Matrix Rot = Matrix.RotateX(45f / 360f) * Matrix.RotateY(45f / 360f) * Matrix.RotateZ(45f / 360f);
            Matrix MVP = View * Proj;
            foreach (Point3 p in t.Points)
            {
                Vector r = MVP * p.V;
                points.Add(new Point((int)r.X, (int)r.Y));
            }
            Render.Fill(bitmap, points.ToArray(), c);
            Canvas.Refresh();
        }
    }
}
