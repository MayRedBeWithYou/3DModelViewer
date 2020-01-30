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

        public IFigure SelectedFigure { get; set; }

        Point4 OC { get; } = new Point4();
        Point4 OX { get; } = new Point4(5, 0, 0);
        Point4 OY { get; } = new Point4(0, 5, 0);
        Point4 OZ { get; } = new Point4(0, 0, 5);

        Timer RefreshTimer = new Timer();

        DateTime frametime;

        public bool FillTriangles = true;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Render.Clear(bitmap);
            Canvas.Image = bitmap;
            Figures.Add(new Cuboid());
            SelectedCamera = new Camera();
            FigureDataGrid.DataSource = Figures;
            Cameras.Add(SelectedCamera);
            CameraListBox.DataSource = Cameras;
            CameraListBox.DisplayMember = "DisplayName";
            CameraListBox.SelectedItem = SelectedCamera;
            RefreshTimer.Tick += RefreshTimer_Tick;
            RefreshTimer.Interval = 8;
            RefreshTimer.Start();
            frametime = DateTime.Now;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
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
            View *= Matrix.Translate(-SelectedCamera.Position.V);
            Matrix Proj = Matrix.Proj(SelectedCamera.FOV * (float)Math.PI / 180f, 0.1f, 100f, Canvas.Width / Canvas.Height);
            Matrix PV = Proj * View;

            Render.Clear(bitmap);
            CalculateAndDrawAxes(PV);
            List<RenderInfo> infos = new List<RenderInfo>();
            foreach (IFigure figure in Figures)
            {
                if (figure.Visibility == false) continue;
                Matrix Trans = Matrix.Translate(figure.Center.V);
                Matrix Rot = Matrix.RotateX(figure.Rotation.X) * Matrix.RotateY(figure.Rotation.Y) * Matrix.RotateZ(figure.Rotation.Z);
                Matrix Scale = Matrix.Scale(figure.Scale);
                Matrix Model = Trans * Rot * Scale;
                Matrix PVM = PV * Model;

                List<Triangle> projected = new List<Triangle>();
                List<Point4> points3 = new List<Point4>();

                foreach (Triangle t in figure.Triangles)
                {
                    points3.Clear();
                    foreach (Point4 p in t.Points)
                    {
                        Vector4 r = PVM * p.V;
                        r = new Vector4(r.X / r.W, r.Y / r.W, r.Z / r.W, 1);
                        r = new Vector4((r.X + 1) * Canvas.Width / 2f, (r.Y + 1) * Canvas.Height / 2f, (r.Z + 1) / 2f, 1);
                        points3.Add(new Point4((int)r.X, (int)r.Y, r.Z, r.W));
                    }
                    Triangle projectedTriangle = new Triangle(points3[0], points3[1], points3[2]);
                    projected.Add(projectedTriangle);
                }
                infos.Add(new RenderInfo(projected, figure.Color, SelectedFigure == figure));
            }
            Render.DrawObjects(bitmap, infos, FillTriangles);
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
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = bitmap;
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

                SelectedCamera.Position.V -= dx * tan + dy * b;
                //SelectedCamera.Target.V += dx * tan + dy * b;
                LastMousePos = new Point(e.X, e.Y);
                Cameras.ResetBindings();
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

                SelectedCamera.Position.V -= dx * tan + dy * b;
                SelectedCamera.Target.V -= dx * tan + dy * b;
                LastMousePos = new Point(e.X, e.Y);
                Cameras.ResetBindings();
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

        }

        private void AddCameraButton_Click(object sender, EventArgs e)
        {
            Cameras.Add(new Camera());
            SelectedCamera = Cameras.Last();
            Cameras.ResetBindings();
            CameraListBox.SelectedItem = SelectedCamera;
            if (Cameras.Count > 1) RemoveCameraButton.Enabled = true;


        }

        private void CameraListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCamera = (Camera)CameraListBox.SelectedItem;
            FOVSlider.Value = SelectedCamera.FOV;

        }

        private void RemoveCameraButton_Click(object sender, EventArgs e)
        {
            int index = CameraListBox.SelectedIndex;
            Cameras.Remove(SelectedCamera);
            SelectedCamera = index == Cameras.Count ? Cameras[index - 1] : Cameras[index];
            if (Cameras.Count == 1) RemoveCameraButton.Enabled = false;

        }

        private void ResetCameraButton_Click(object sender, EventArgs e)
        {
            SelectedCamera.Reset();
            FOVSlider.Value = SelectedCamera.FOV;
            Cameras.ResetBindings();

        }

        private void FigureDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FigureDataGrid.EndEdit();
        }

        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            AddFigureMenu.Show(AddFigureButton, new Point(0, AddFigureButton.Height));
        }

        private void cuboidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figures.Add(new Cuboid());
            FigureDataGrid.ClearSelection();
            FigureDataGrid.Rows[Figures.Count - 1].Selected = true;
            if (Figures.Count > 0) RemoveFigureButton.Enabled = true;
        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            if (FigureDataGrid.SelectedRows.Count != 0)
                Figures.Remove((IFigure)FigureDataGrid.SelectedRows[0].DataBoundItem);
            if (Figures.Count == 0)
            {
                RemoveFigureButton.Enabled = false;
            }
            else if (FigureDataGrid.SelectedRows.Count == 0)
            {
                FigureDataGrid.Rows[Figures.Count - 1].Selected = true;
            }
        }

        private void FigureDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            CuboidGroupBox.Visible = false;
            SphereGroupBox.Visible = false;
            if (FigureDataGrid.SelectedRows.Count != 0)
            {
                SelectedFigure = (IFigure)FigureDataGrid.SelectedRows[0].DataBoundItem;
                if (SelectedFigure is Cuboid)
                {
                    Cuboid cube = SelectedFigure as Cuboid;
                    CuboidGroupBox.Visible = true;
                    CuboidPosX.Value = (decimal)cube.Center.X;
                    CuboidPosY.Value = (decimal)cube.Center.Y;
                    CuboidPosZ.Value = (decimal)cube.Center.Z;

                    CuboidDimX.Value = (decimal)cube.DimX;
                    CuboidDimY.Value = (decimal)cube.DimY;
                    CuboidDimZ.Value = (decimal)cube.DimZ;
                }
                else if (SelectedFigure is Sphere)
                {
                    SphereGroupBox.Visible = true;
                }
            }
        }

        private void CuboidPosX_ValueChanged(object sender, EventArgs e)
        {
            Cuboid cube = SelectedFigure as Cuboid;
            cube.Center.X = (float)CuboidPosX.Value;
            FigureDataGrid.Refresh();
        }

        private void CuboidPosY_ValueChanged(object sender, EventArgs e)
        {
            Cuboid cube = SelectedFigure as Cuboid;
            cube.Center.Y = (float)CuboidPosY.Value;
            FigureDataGrid.Refresh();
        }

        private void CuboidPosZ_ValueChanged(object sender, EventArgs e)
        {
            Cuboid cube = SelectedFigure as Cuboid;
            cube.Center.Z = (float)CuboidPosZ.Value;
            FigureDataGrid.Refresh();
        }

        private void CuboidDimX_ValueChanged(object sender, EventArgs e)
        {
            Cuboid cube = SelectedFigure as Cuboid;
            cube.DimX = (float)CuboidDimX.Value;
            FigureDataGrid.Refresh();
        }

        private void CuboidDimY_ValueChanged(object sender, EventArgs e)
        {
            Cuboid cube = SelectedFigure as Cuboid;
            cube.DimY = (float)CuboidDimY.Value;
            FigureDataGrid.Refresh();
        }

        private void CuboidDimZ_ValueChanged(object sender, EventArgs e)
        {
            Cuboid cube = SelectedFigure as Cuboid;
            cube.DimZ = (float)CuboidDimZ.Value;
            FigureDataGrid.Refresh();
        }

        private void fillTrianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillTriangles = !FillTriangles;
            fillTrianglesToolStripMenuItem.Checked = FillTriangles;
        }

        private void CuboidRotX_ValueChanged(object sender, EventArgs e)
        {
            if (CuboidRotX.Value < 0) CuboidRotX.Value += 360;
            else if (CuboidRotX.Value == 360) CuboidRotX.Value = 0;
            Cuboid cube = SelectedFigure as Cuboid;
            cube.RotX = (float)CuboidRotX.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void CuboidRotY_ValueChanged(object sender, EventArgs e)
        {
            if (CuboidRotY.Value < 0) CuboidRotY.Value += 360;
            else if (CuboidRotY.Value == 360) CuboidRotY.Value = 0;
            Cuboid cube = SelectedFigure as Cuboid;
            cube.RotY = (float)CuboidRotY.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void CuboidRotZ_ValueChanged(object sender, EventArgs e)
        {
            if (CuboidRotZ.Value < 0) CuboidRotZ.Value += 360;
            else if (CuboidRotZ.Value == 360) CuboidRotZ.Value = 0;
            Cuboid cube = SelectedFigure as Cuboid;
            cube.RotZ = (float)CuboidRotZ.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figures.Add(new Sphere());
            FigureDataGrid.ClearSelection();
            FigureDataGrid.Rows[Figures.Count - 1].Selected = true;
            if (Figures.Count > 0) RemoveFigureButton.Enabled = true;
        }
    }
}
