using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DModelViewer
{
    public partial class Form1 : Form
    {
        public Camera SelectedCamera { get; set; }

        List<Camera> Cameras = new List<Camera>();

        Bitmap bitmap;

        int FOV = 60;

        List<Triangle> Triangles = new List<Triangle>();

        Point3 OC { get; } = new Point3();
        Point3 OX { get; } = new Point3(1, 0, 0);
        Point3 OY { get; } = new Point3(0, 1, 0);
        Point3 OZ { get; } = new Point3(0, 0, 1);

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Render.Clear(bitmap);
            Canvas.Image = bitmap;
            Point3 p1 = new Point3(0, 0.5f, 0);
            Point3 p2 = new Point3(0.5f, 0, 0.5f);
            Point3 p3 = new Point3(-0.5f, 0, 0.5f);
            Triangles.Add(new Triangle(p1, p2, p3));
            SelectedCamera = new Camera(new Point3(2, 2, 2), new Point3(0, 0, 0));
            Cameras.Add(SelectedCamera);
            PrepareBitmap();
            XLabel.Text = SelectedCamera.Position.X.ToString();
            YLabel.Text = SelectedCamera.Position.Y.ToString();
            ZLabel.Text = SelectedCamera.Position.Z.ToString();
            XSlider.Value = (int)SelectedCamera.Position.X * 10;
            YSlider.Value = (int)SelectedCamera.Position.Y * 10;
            ZSlider.Value = (int)SelectedCamera.Position.Z * 10;
        }

        public void PrepareBitmap()
        {
            Vector4 up = new Vector4(0, 1, 0, 0);
            Vector4 D = -Vector4.Normalize(SelectedCamera.Position.V - SelectedCamera.Target.V);
            Vector4 R = Vector4.Normalize(Vector.Cross(up, D));
            Vector4 U = Vector4.Normalize(Vector.Cross(D, R));

            Matrix View = new Matrix(R.X, U.Y, D.Z, 1);
            View[0, 1] = R.Y;
            View[0, 2] = R.Z;
            View[1, 0] = U.X;
            View[1, 2] = U.Z;
            View[2, 0] = D.X;
            View[2, 1] = D.Y;
            View = View * Matrix.Translate(SelectedCamera.Position.V);

            Matrix Proj = Matrix.Proj(FOV * (float)Math.PI / 180f, 0.1f, 100f, Canvas.Width / Canvas.Height);
            Matrix Trans = Matrix.Translate(0, 0, 0);
            Matrix Rot = Matrix.RotateX(0) * Matrix.RotateY(0) * Matrix.RotateZ(0);
            Matrix Scale = Matrix.Scale(1, 1, 1);
            Matrix Model = Trans * Rot * Scale;
            Matrix PVM = Proj * View * Model;

            Render.Clear(bitmap);
            CalculateAndDrawAxes(PVM);

            foreach (Triangle t in Triangles)
            {
                List<Point> points = new List<Point>();
                foreach (Point3 p in t.Points)
                {
                    Vector4 r = PVM * p.V;
                    r = new Vector4(r.X / r.W, r.Y / r.W, r.Z / r.W, 1);
                    r = new Vector4((r.X + 1) * Canvas.Width / 2f, (r.Y + 1) * Canvas.Height / 2f, (r.Z + 1) / 2f, 1);
                    points.Add(new Point((int)r.X, (int)r.Y));
                }
                Render.Fill(bitmap, points.ToArray(), Color.Gold);
            }
            Canvas.Refresh();
        }

        private void CalculateAndDrawAxes(Matrix PVM)
        {
            Vector4 tmp = PVM * OC.V;
            tmp = new Vector4(tmp.X / tmp.W, tmp.Y / tmp.W, tmp.Z / tmp.W, 1);
            tmp = new Vector4((tmp.X + 1) * Canvas.Width / 2f, (tmp.Y + 1) * Canvas.Height / 2f, (tmp.Z + 1) / 2f, 1);
            Point PVMC = new Point((int)tmp.X, (int)tmp.Y);
            tmp = PVM * OX.V;
            tmp = new Vector4(tmp.X / tmp.W, tmp.Y / tmp.W, tmp.Z / tmp.W, 1);
            tmp = new Vector4((tmp.X + 1) * Canvas.Width / 2f, (tmp.Y + 1) * Canvas.Height / 2f, (tmp.Z + 1) / 2f, 1);
            Point PVMX = new Point((int)tmp.X, (int)tmp.Y);
            tmp = PVM * OY.V;
            tmp = new Vector4(tmp.X / tmp.W, tmp.Y / tmp.W, tmp.Z / tmp.W, 1);
            tmp = new Vector4((tmp.X + 1) * Canvas.Width / 2f, (tmp.Y + 1) * Canvas.Height / 2f, (tmp.Z + 1) / 2f, 1);
            Point PVMY = new Point((int)tmp.X, (int)tmp.Y);
            tmp = PVM * OZ.V;
            tmp = new Vector4(tmp.X / tmp.W, tmp.Y / tmp.W, tmp.Z / tmp.W, 1);
            tmp = new Vector4((tmp.X + 1) * Canvas.Width / 2f, (tmp.Y + 1) * Canvas.Height / 2f, (tmp.Z + 1) / 2f, 1);
            Point PVMZ = new Point((int)tmp.X, (int)tmp.Y);
            Render.DrawAxes(bitmap, PVMC, PVMX, PVMY, PVMZ);
        }

        private void FOVSlider_ValueChanged(object sender, EventArgs e)
        {
            FOV = FOVSlider.Value;
            if (FOV == 120) FOVLabel.Text = "Quake\nPro";
            else FOVLabel.Text = FOV.ToString();
            PrepareBitmap();
        }

        private void ZSlider_ValueChanged(object sender, EventArgs e)
        {
            SelectedCamera.Position.Z = ZSlider.Value / 10f;
            ZLabel.Text = SelectedCamera.Position.Z.ToString();
            PrepareBitmap();
        }

        private void XSlider_ValueChanged(object sender, EventArgs e)
        {
            SelectedCamera.Position.X = XSlider.Value / 10f;
            XLabel.Text = SelectedCamera.Position.X.ToString();
            PrepareBitmap();
        }

        private void YSlider_ValueChanged(object sender, EventArgs e)
        {
            SelectedCamera.Position.Y = YSlider.Value / 10f;
            YLabel.Text = SelectedCamera.Position.Y.ToString();
            PrepareBitmap();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = bitmap;
            PrepareBitmap();
        }
    }
}
