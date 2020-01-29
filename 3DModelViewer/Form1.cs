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

        public readonly BindingList<Camera> Cameras = new BindingList<Camera>();

        Bitmap bitmap;

        Point LastMousePos = Point.Empty;

        readonly List<Triangle> Triangles = new List<Triangle>();

        public readonly BindingList<IFigure> Figures = new BindingList<IFigure>();

        Point4 OC { get; } = new Point4();
        Point4 OX { get; } = new Point4(5, 0, 0);
        Point4 OY { get; } = new Point4(0, 5, 0);
        Point4 OZ { get; } = new Point4(0, 0, 5);

        Timer RefreshRate = new Timer();

        DateTime frametime;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Render.Clear(bitmap);
            Canvas.Image = bitmap;
            //Point3 p1 = new Point3(0, 0.5f, 0);
            //Point3 p2 = new Point3(0.5f, 0, 0.5f);
            //Point3 p3 = new Point3(-0.5f, 0, 0.5f);
            //Triangles.Add(new Triangle(p1, p2, p3));
            Figures.Add(new Cuboid());
            Figures.Add(new Cuboid { Visibility = false });
            SelectedCamera = new Camera();
            FigureDataGrid.DataSource = Figures;
            Cameras.Add(SelectedCamera);
            CameraListBox.DataSource = Cameras;
            CameraListBox.DisplayMember = "DisplayName";
            CameraListBox.SelectedItem = SelectedCamera;
            RefreshRate.Tick += RefreshRate_Tick;
            RefreshRate.Interval = 8;
            RefreshRate.Start();
            frametime = DateTime.Now;
        }

        private void RefreshRate_Tick(object sender, EventArgs e)
        {
            TimeSpan time = DateTime.Now - frametime;
            int FPS = (int)(1 / time.TotalSeconds);
            FPSLabel.Text = $"{FPS} FPS";
            frametime = DateTime.Now;
            PrepareRender();
        }

        public void PrepareRender()
        {
            Vector4 up = new Vector4(0, 1, 0, 0);
            Vector4 D = SelectedCamera.Normal;
            Vector4 R = Vector4.Normalize(Vector.Cross(up, D));
            Vector4 U = Vector4.Normalize(Vector.Cross(D, R));

            Matrix View = new Matrix(R.X, U.Y, D.Z, 1);
            View[0, 1] = R.Y;
            View[0, 2] = R.Z;
            View[1, 0] = U.X;
            View[1, 2] = U.Z;
            View[2, 0] = D.X;
            View[2, 1] = D.Y;
            View *= Matrix.Translate(SelectedCamera.Position.V);
            Matrix Proj = Matrix.Proj(SelectedCamera.FOV * (float)Math.PI / 180f, 0.1f, 100f, Canvas.Width / Canvas.Height);
            Matrix PV = Proj * View;

            Render.Clear(bitmap);
            CalculateAndDrawAxes(PV);

            foreach (IFigure figure in Figures)
            {
                if (figure.Visibility == false) continue;
                Matrix Trans = Matrix.Translate(figure.Center.V);
                Matrix Rot = Matrix.RotateX(figure.Rotation.X) * Matrix.RotateY(figure.Rotation.Y) * Matrix.RotateZ(figure.Rotation.Z);
                Matrix Scale = Matrix.Scale(figure.Scale);
                Matrix Model = Trans * Rot * Scale;
                Matrix PVM = PV * Model;

                foreach (Triangle t in figure.Triangles)
                {
                    List<Point> points = new List<Point>();
                    List<Point4> points3 = new List<Point4>();
                    foreach (Point4 p in t.Points)
                    {
                        Vector4 r = PVM * p.V;
                        r = new Vector4(r.X / r.W, r.Y / r.W, r.Z / r.W, 1);
                        r = new Vector4((r.X + 1) * Canvas.Width / 2f, (r.Y + 1) * Canvas.Height / 2f, (r.Z + 1) / 2f, 1);
                        points.Add(new Point((int)r.X, (int)r.Y));
                        points3.Add(new Point4((int)r.X, (int)r.Y, r.Z, r.W));
                    }
                    //Render.FillTriangle(bitmap, points3, figure.Color);
                    //Render.Fill(bitmap, points.ToArray(), figure.Color);
                    Render.FillScanline(bitmap, points3, figure.Color);
                }
            }
            Canvas.Refresh();
        }

        public void TestRender()
        {
            Vector4 up = new Vector4(0, 1, 0, 0);
            Vector4 D = SelectedCamera.Normal;
            Vector4 R = Vector4.Normalize(Vector.Cross(up, D));
            Vector4 U = Vector4.Normalize(Vector.Cross(D, R));

            Matrix View = new Matrix(R.X, U.Y, D.Z, 1);
            View[0, 1] = R.Y;
            View[0, 2] = R.Z;
            View[1, 0] = U.X;
            View[1, 2] = U.Z;
            View[2, 0] = D.X;
            View[2, 1] = D.Y;
            View *= Matrix.Translate(SelectedCamera.Position.V);

            Matrix Proj = Matrix.Proj(SelectedCamera.FOV * (float)Math.PI / 180f, 0.1f, 100f, Canvas.Width / Canvas.Height);
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
                foreach (Point4 p in t.Points)
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
            SelectedCamera.FOV = FOVSlider.Value;
            if (SelectedCamera.FOV == 120) FOVLabel.Text = "Quake\nPro";
            else FOVLabel.Text = SelectedCamera.FOV.ToString();
            //PrepareRender();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = bitmap;
            //PrepareRender();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                float dx = e.X - LastMousePos.X;
                float dy = e.Y - LastMousePos.Y;
                dx /= 100;
                dy /= 100;
                dx = dx * SelectedCamera.FOV / 60f;
                dy = dy * SelectedCamera.FOV / 60f;
                Vector4 tan = SelectedCamera.Tangent;
                Vector4 b = SelectedCamera.Binormal;

                SelectedCamera.Position.V += dx * tan + dy * b;
                //SelectedCamera.Target.V += dx * tan + dy * b;
                LastMousePos = new Point(e.X, e.Y);
                Cameras.ResetBindings();
                //PrepareRender();
            }
            else if (e.Button == MouseButtons.Right)
            {
                float dx = e.X - LastMousePos.X;
                float dy = e.Y - LastMousePos.Y;
                dx /= 100;
                dy /= 100;
                dx = dx * SelectedCamera.FOV / 60f;
                dy = dy * SelectedCamera.FOV / 60f;
                Vector4 tan = SelectedCamera.Tangent;
                Vector4 b = SelectedCamera.Binormal;

                SelectedCamera.Position.V += dx * tan + dy * b;
                SelectedCamera.Target.V += dx * tan + dy * b;
                LastMousePos = new Point(e.X, e.Y);
                Cameras.ResetBindings();
                //PrepareRender();
            }
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle || e.Button == MouseButtons.Right)
            {
                LastMousePos = new Point(e.X, e.Y);

                //Cursor.Hide();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            LastMousePos = Point.Empty;
            //Cursor.Show();
        }

        private void Canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && (SelectedCamera.Target.V - SelectedCamera.Position.V).Length() < 0.3f) return;
            SelectedCamera.Position.V += e.Delta / 120 * 0.1f * SelectedCamera.Normal;
            Cameras.ResetBindings();
            //PrepareRender();
        }

        private void AddCameraButton_Click(object sender, EventArgs e)
        {
            Cameras.Add(new Camera());
            SelectedCamera = Cameras.Last();
            Cameras.ResetBindings();
            CameraListBox.SelectedItem = SelectedCamera;
            if (Cameras.Count > 1) RemoveCameraButton.Enabled = true;
            //PrepareRender();

        }

        private void CameraListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCamera = (Camera)CameraListBox.SelectedItem;
            FOVSlider.Value = SelectedCamera.FOV;
            //PrepareRender();
        }

        private void RemoveCameraButton_Click(object sender, EventArgs e)
        {
            int index = CameraListBox.SelectedIndex;
            Cameras.Remove(SelectedCamera);
            SelectedCamera = index == Cameras.Count ? Cameras[index - 1] : Cameras[index];
            if (Cameras.Count == 1) RemoveCameraButton.Enabled = false;
            //PrepareRender();
        }

        private void ResetCameraButton_Click(object sender, EventArgs e)
        {
            SelectedCamera.Position = new Point4(3, 3, 3);
            SelectedCamera.Target = new Point4();
            SelectedCamera.FOV = 60;
            FOVSlider.Value = 60;
            Cameras.ResetBindings();
            //PrepareRender();
        }

        private void FigureDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FigureDataGrid.EndEdit();
        }
    }
}
