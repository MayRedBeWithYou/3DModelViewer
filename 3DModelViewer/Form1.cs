using FastBitmapLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace _3DModelViewer
{
    public partial class Form1 : Form
    {
        public Camera SelectedCamera { get; set; }

        public BindingList<Camera> Cameras = new BindingList<Camera>();

        public Light SelectedLight { get; set; }

        public readonly BindingList<Light> Lights = new BindingList<Light>();

        Bitmap bitmap;

        Point LastMousePos = Point.Empty;

        public readonly BindingList<IFigure> Figures = new BindingList<IFigure>();

        public IFigure SelectedFigure { get; set; }

        Point4 OC { get; } = new Point4();
        Point4 OX { get; } = new Point4(5, 0, 0);
        Point4 OY { get; } = new Point4(0, 5, 0);
        Point4 OZ { get; } = new Point4(0, 0, 5);

        Timer RefreshTimer = new Timer();

        DateTime frametime;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Render.Clear(bitmap);
            Canvas.Image = bitmap;
            Figures.Add(new Cuboid() { Center = new Point4(3, 0, 3) });
            Figures.Add(new Sphere() { Center = new Point4(-3, 0, -3) });
            Figures.Add(new Cone() { Center = new Point4(-3, 0, 3) });
            Figures.Add(new Cylinder() { Center = new Point4(3, 0, -3) });
            FigureDataGrid.DataSource = Figures;

            SelectedCamera = new Camera();
            Cameras.Add(SelectedCamera);
            CameraListBox.DataSource = Cameras;
            CameraListBox.DisplayMember = "DisplayName";
            CameraListBox.SelectedIndex = 0;

            LightColor.Image = new Bitmap(LightColor.Width, LightColor.Height);
            LightColor.Refresh();

            SelectedLight = new Light();
            Lights.Add(SelectedLight);
            LightListBox.DataSource = Lights;
            LightListBox.DisplayMember = "DisplayName";
            LightListBox.SelectedIndex = 0;

            RefreshTimer.Tick += RefreshTimer_Tick;
            RefreshTimer.Interval = 8;
            RefreshTimer.Start();
            frametime = DateTime.Now;

            Render.ZBuffering = zbufferingToolStripMenuItem.Checked;
            Render.FillTriangles = fillTrianglesToolStripMenuItem.Checked;
            Render.BackfaceCulling = backfaceCullingToolStripMenuItem.Checked;

            CuboidColor.Image = new Bitmap(CuboidColor.Width, CuboidColor.Height);
            CuboidColor.Refresh();

            SphereColor.Image = new Bitmap(SphereColor.Width, SphereColor.Height);
            SphereColor.Refresh();

            CylinderColor.Image = new Bitmap(CylinderColor.Width, CylinderColor.Height);
            CylinderColor.Refresh();

            ConeColor.Image = new Bitmap(ConeColor.Width, ConeColor.Height);
            ConeColor.Refresh();
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
            Matrix Proj = Matrix.Proj(SelectedCamera.FOV * (float)Math.PI / 180f, SelectedCamera.N, SelectedCamera.F, Canvas.Width / (float)Canvas.Height);
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
                        r = new Vector4(r.X / r.W, r.Y / r.W, r.Z / r.W, 1f);
                        r = new Vector4((r.X + 1) * Canvas.Width / 2f, (r.Y + 1) * Canvas.Height / 2f, (r.Z - 1f) / 2f, 1f);
                        points3.Add(new Point4((int)r.X, (int)r.Y, r.Z, r.W));
                    }
                    Triangle projectedTriangle = new Triangle(points3[0], points3[1], points3[2]);
                    if (Render.BackfaceCulling
                        && Vector4.Dot(new Vector4(D.X, D.Y, Math.Abs(D.Z), D.W), projectedTriangle.Normal) > 0) continue;
                    projected.Add(projectedTriangle);
                }
                infos.Add(new RenderInfo(projected, figure.Color, SelectedFigure == figure));
            }
            Render.DrawObjects(bitmap, infos);
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
            FOVLabel.Text = SelectedCamera.FOV.ToString();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = bitmap;
            PrepareRender();
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
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            LastMousePos = Point.Empty;
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
            CameraN.Value = (decimal)SelectedCamera.N;
            CameraF.Value = (decimal)SelectedCamera.F;
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

        private void fillTrianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Render.FillTriangles = !Render.FillTriangles;
            fillTrianglesToolStripMenuItem.Checked = Render.FillTriangles;
        }
        private void backfaceCullingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Render.BackfaceCulling = !Render.BackfaceCulling;
            backfaceCullingToolStripMenuItem.Checked = Render.BackfaceCulling;
        }

        private void zbufferingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Render.ZBuffering = !Render.ZBuffering;
            zbufferingToolStripMenuItem.Checked = Render.ZBuffering;
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

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figures.Add(new Sphere());
            FigureDataGrid.ClearSelection();
            FigureDataGrid.Rows[Figures.Count - 1].Selected = true;
            if (Figures.Count > 0) RemoveFigureButton.Enabled = true;
        }

        private void cylinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figures.Add(new Cylinder());
            FigureDataGrid.ClearSelection();
            FigureDataGrid.Rows[Figures.Count - 1].Selected = true;
            if (Figures.Count > 0) RemoveFigureButton.Enabled = true;
        }

        private void coneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figures.Add(new Cone());
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
            CylinderGroupBox.Visible = false;
            ConeGroupBox.Visible = false;
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

                    CuboidRotX.Value = (decimal)(cube.RotX * 180f / Math.PI);
                    CuboidRotY.Value = (decimal)(cube.RotY * 180f / Math.PI);
                    CuboidRotZ.Value = (decimal)(cube.RotZ * 180f / Math.PI);

                    using (FastBitmap fast = ((Bitmap)CuboidColor.Image).FastLock())
                    {
                        fast.Clear(cube.Color);
                    }
                    CuboidColor.Refresh();
                }
                else if (SelectedFigure is Sphere)
                {
                    SphereGroupBox.Visible = true;
                    Sphere sphere = SelectedFigure as Sphere;
                    SpherePosX.Value = (decimal)sphere.Center.X;
                    SpherePosY.Value = (decimal)sphere.Center.Y;
                    SpherePosZ.Value = (decimal)sphere.Center.Z;

                    SphereDimX.Value = (decimal)sphere.DimX;
                    SphereDimY.Value = (decimal)sphere.DimY;
                    SphereDimZ.Value = (decimal)sphere.DimZ;

                    SphereRotX.Value = (decimal)(sphere.RotX * 180f / Math.PI);
                    SphereRotY.Value = (decimal)(sphere.RotY * 180f / Math.PI);
                    SphereRotZ.Value = (decimal)(sphere.RotZ * 180f / Math.PI);

                    SphereLat.Value = (decimal)sphere.Lat;
                    SphereLon.Value = (decimal)sphere.Lon;
                    SphereRadius.Value = (decimal)sphere.Radius;

                    using (FastBitmap fast = ((Bitmap)SphereColor.Image).FastLock())
                    {
                        fast.Clear(sphere.Color);
                    }
                    SphereColor.Refresh();
                }
                else if (SelectedFigure is Cylinder)
                {
                    CylinderGroupBox.Visible = true;
                    Cylinder cylinder = SelectedFigure as Cylinder;
                    CylinderPosX.Value = (decimal)cylinder.Center.X;
                    CylinderPosY.Value = (decimal)cylinder.Center.Y;
                    CylinderPosZ.Value = (decimal)cylinder.Center.Z;

                    CylinderDimX.Value = (decimal)cylinder.DimX;
                    CylinderDimY.Value = (decimal)cylinder.DimY;
                    CylinderDimZ.Value = (decimal)cylinder.DimZ;

                    CylinderRotX.Value = (decimal)(cylinder.RotX * 180f / Math.PI);
                    CylinderRotY.Value = (decimal)(cylinder.RotY * 180f / Math.PI);
                    CylinderRotZ.Value = (decimal)(cylinder.RotZ * 180f / Math.PI);

                    CylinderDiv.Value = (decimal)cylinder.Division;
                    CylinderHeight.Value = (decimal)cylinder.Height;
                    CylinderRadius.Value = (decimal)cylinder.Radius;

                    using (FastBitmap fast = ((Bitmap)CylinderColor.Image).FastLock())
                    {
                        fast.Clear(cylinder.Color);
                    }
                    CylinderColor.Refresh();
                }
                else if (SelectedFigure is Cone)
                {
                    ConeGroupBox.Visible = true;
                    Cone cone = SelectedFigure as Cone;
                    ConePosX.Value = (decimal)cone.Center.X;
                    ConePosY.Value = (decimal)cone.Center.Y;
                    ConePosZ.Value = (decimal)cone.Center.Z;

                    ConeDimX.Value = (decimal)cone.DimX;
                    ConeDimY.Value = (decimal)cone.DimY;
                    ConeDimZ.Value = (decimal)cone.DimZ;

                    ConeRotX.Value = (decimal)(cone.RotX * 180f / Math.PI);
                    ConeRotY.Value = (decimal)(cone.RotY * 180f / Math.PI);
                    ConeRotZ.Value = (decimal)(cone.RotZ * 180f / Math.PI);

                    ConeDiv.Value = (decimal)cone.Division;
                    ConeHeight.Value = (decimal)cone.Height;
                    ConeRadius.Value = (decimal)cone.Radius;

                    using (FastBitmap fast = ((Bitmap)ConeColor.Image).FastLock())
                    {
                        fast.Clear(cone.Color);
                    }
                    ConeColor.Refresh();
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

        private void SpherePosX_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.Center.X = (float)SpherePosX.Value;
            FigureDataGrid.Refresh();
        }

        private void SpherePosY_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.Center.Y = (float)SpherePosY.Value;
            FigureDataGrid.Refresh();
        }

        private void SpherePosZ_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.Center.Z = (float)SpherePosZ.Value;
            FigureDataGrid.Refresh();
        }

        private void SphereDimX_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.DimX = (float)SphereDimX.Value;
            FigureDataGrid.Refresh();
        }

        private void SphereDimY_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.DimY = (float)SphereDimY.Value;
            FigureDataGrid.Refresh();
        }

        private void SphereDimZ_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.DimZ = (float)SphereDimZ.Value;
            FigureDataGrid.Refresh();
        }



        private void SphereRotX_ValueChanged(object sender, EventArgs e)
        {
            if (SphereRotX.Value < 0) SphereRotX.Value += 360;
            else if (SphereRotX.Value == 360) SphereRotX.Value = 0;
            Sphere sphere = SelectedFigure as Sphere;
            sphere.RotX = (float)SphereRotX.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void SphereRotY_ValueChanged(object sender, EventArgs e)
        {
            if (SphereRotY.Value < 0) SphereRotY.Value += 360;
            else if (SphereRotY.Value == 360) SphereRotY.Value = 0;
            Sphere sphere = SelectedFigure as Sphere;
            sphere.RotY = (float)SphereRotY.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void SphereRotZ_ValueChanged(object sender, EventArgs e)
        {
            if (SphereRotZ.Value < 0) SphereRotZ.Value += 360;
            else if (SphereRotZ.Value == 360) SphereRotZ.Value = 0;
            Sphere sphere = SelectedFigure as Sphere;
            sphere.RotZ = (float)SphereRotZ.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void SphereLat_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.Lat = (int)SphereLat.Value;
            FigureDataGrid.Refresh();
        }

        private void SphereLon_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.Lon = (int)SphereLon.Value;
            FigureDataGrid.Refresh();
        }

        private void SphereRadius_ValueChanged(object sender, EventArgs e)
        {
            Sphere sphere = SelectedFigure as Sphere;
            sphere.Radius = (float)SphereRadius.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderPosX_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.Center.X = (float)CylinderPosX.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderPosY_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.Center.Y = (float)CylinderPosY.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderPosZ_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.Center.Z = (float)CylinderPosZ.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderDimX_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.DimX = (float)CylinderDimX.Value;
            FigureDataGrid.Refresh();
        }
        private void CylinderDimY_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.DimY = (float)CylinderDimY.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderDimZ_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.DimZ = (float)CylinderDimZ.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderRotX_ValueChanged(object sender, EventArgs e)
        {
            if (CylinderRotX.Value < 0) CylinderRotX.Value += 360;
            else if (CylinderRotX.Value == 360) CylinderRotX.Value = 0;
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.RotX = (float)CylinderRotX.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void CylinderRotY_ValueChanged(object sender, EventArgs e)
        {
            if (CylinderRotY.Value < 0) CylinderRotY.Value += 360;
            else if (CylinderRotY.Value == 360) CylinderRotY.Value = 0;
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.RotY = (float)CylinderRotY.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void CylinderRotZ_ValueChanged(object sender, EventArgs e)
        {
            if (CylinderRotZ.Value < 0) CylinderRotZ.Value += 360;
            else if (CylinderRotZ.Value == 360) CylinderRotZ.Value = 0;
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.RotZ = (float)CylinderRotZ.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void CylinderDiv_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.Division = (int)CylinderDiv.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderHeight_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.Height = (float)CylinderHeight.Value;
            FigureDataGrid.Refresh();
        }

        private void CylinderRadius_ValueChanged(object sender, EventArgs e)
        {
            Cylinder cylinder = SelectedFigure as Cylinder;
            cylinder.Radius = (float)CylinderRadius.Value;
            FigureDataGrid.Refresh();
        }

        private void ConePosX_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.Center.X = (float)ConePosX.Value;
            FigureDataGrid.Refresh();
        }

        private void ConePosY_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.Center.Y = (float)ConePosY.Value;
            FigureDataGrid.Refresh();
        }

        private void ConePosZ_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.Center.Z = (float)ConePosZ.Value;
            FigureDataGrid.Refresh();
        }

        private void ConeDimX_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.DimX = (float)ConeDimX.Value;
            FigureDataGrid.Refresh();
        }
        private void ConeDimY_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.DimY = (float)ConeDimY.Value;
            FigureDataGrid.Refresh();
        }

        private void ConeDimZ_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.DimZ = (float)ConeDimZ.Value;
            FigureDataGrid.Refresh();
        }

        private void ConeRotX_ValueChanged(object sender, EventArgs e)
        {
            if (ConeRotX.Value < 0) ConeRotX.Value += 360;
            else if (ConeRotX.Value == 360) ConeRotX.Value = 0;
            Cone cone = SelectedFigure as Cone;
            cone.RotX = (float)ConeRotX.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void ConeRotY_ValueChanged(object sender, EventArgs e)
        {
            if (ConeRotY.Value < 0) ConeRotY.Value += 360;
            else if (ConeRotY.Value == 360) ConeRotY.Value = 0;
            Cone cone = SelectedFigure as Cone;
            cone.RotY = (float)ConeRotY.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void ConeRotZ_ValueChanged(object sender, EventArgs e)
        {
            if (ConeRotZ.Value < 0) ConeRotZ.Value += 360;
            else if (ConeRotZ.Value == 360) ConeRotZ.Value = 0;
            Cone cone = SelectedFigure as Cone;
            cone.RotZ = (float)ConeRotZ.Value * (float)Math.PI / 180f;
            FigureDataGrid.Refresh();
        }

        private void ConeDiv_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.Division = (int)ConeDiv.Value;
            FigureDataGrid.Refresh();
        }

        private void ConeHeight_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.Height = (float)ConeHeight.Value;
            FigureDataGrid.Refresh();
        }

        private void ConeRadius_ValueChanged(object sender, EventArgs e)
        {
            Cone cone = SelectedFigure as Cone;
            cone.Radius = (float)ConeRadius.Value;
            FigureDataGrid.Refresh();
        }

        private void CameraN_ValueChanged(object sender, EventArgs e)
        {
            if (CameraN.Value >= CameraF.Value) CameraN.Value = CameraF.Value - CameraN.Increment;
            SelectedCamera.N = (float)CameraN.Value;
        }

        private void CameraF_ValueChanged(object sender, EventArgs e)
        {
            if (CameraF.Value <= CameraN.Value) CameraF.Value = CameraN.Value + CameraF.Increment;
            SelectedCamera.F = (float)CameraF.Value;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CylinderColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFigure.Color = dialog.Color;
                using (FastBitmap fast = ((Bitmap)CylinderColor.Image).FastLock())
                {
                    fast.Clear(dialog.Color);
                }
                CylinderColor.Refresh();
            }
        }

        private void SphereColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFigure.Color = dialog.Color;
                using (FastBitmap fast = ((Bitmap)SphereColor.Image).FastLock())
                {
                    fast.Clear(dialog.Color);
                }
                SphereColor.Refresh();
            }
        }

        private void CuboidColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFigure.Color = dialog.Color;
                using (FastBitmap fast = ((Bitmap)CuboidColor.Image).FastLock())
                {
                    fast.Clear(dialog.Color);
                }
                CuboidColor.Refresh();
            }
        }

        private void ConeColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFigure.Color = dialog.Color;
                using (FastBitmap fast = ((Bitmap)ConeColor.Image).FastLock())
                {
                    fast.Clear(dialog.Color);
                }
                ConeColor.Refresh();
            }
        }

        private void AddLightButton_Click(object sender, EventArgs e)
        {
            Lights.Add(new Light());
            SelectedLight = Lights.Last();
            LightListBox.SelectedItem = SelectedLight;
            RemoveLightButton.Enabled = true;
            LightGroupBox.Enabled = true;
            Lights.ResetBindings();
        }

        private void LightListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lights.Count == 0) return;
            SelectedLight = (Light)LightListBox.SelectedItem;
            using (FastBitmap fast = ((Bitmap)LightColor.Image).FastLock())
            {
                fast.Clear(SelectedLight.Color);
            }
            LightIntensity.Value = (decimal)SelectedLight.Intensity;
            LightRange.Value = (decimal)SelectedLight.Range;
            LightPosX.Value = (decimal)SelectedLight.Position.X;
            LightPosY.Value = (decimal)SelectedLight.Position.Y;
            LightPosZ.Value = (decimal)SelectedLight.Position.Z;

            LightColor.Refresh();
        }

        private void RemoveLightButton_Click(object sender, EventArgs e)
        {
            int index = LightListBox.SelectedIndex;
            Lights.Remove(SelectedLight);
            if (index == Lights.Count)
            {
                if (Lights.Count == 0)
                {
                    SelectedLight = null;
                    RemoveLightButton.Enabled = false;
                    LightGroupBox.Enabled = false;
                    using (FastBitmap fast = ((Bitmap)LightColor.Image).FastLock())
                    {
                        fast.Clear(Color.White);
                    }
                }
                else SelectedLight = Lights.Last();
            }
            else SelectedLight = Lights[index == 0 ? index : index - 1];
            Lights.ResetBindings();
        }

        private void LightPosX_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.Position.X = (float)LightPosX.Value;
            Lights.ResetBindings();
        }

        private void LightPosY_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.Position.Y = (float)LightPosY.Value;
            Lights.ResetBindings();
        }

        private void LightPosZ_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.Position.Z = (float)LightPosZ.Value;
            Lights.ResetBindings();
        }

        private void LightIntensity_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.Intensity = (float)LightIntensity.Value;
            Lights.ResetBindings();
        }

        private void LightRange_ValueChanged(object sender, EventArgs e)
        {
            SelectedLight.Range = (float)LightRange.Value;
            Lights.ResetBindings();
        }

        private void LightColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedLight.Color = dialog.Color;
                using (FastBitmap fast = ((Bitmap)LightColor.Image).FastLock())
                {
                    fast.Clear(dialog.Color);
                }
                LightColor.Refresh();
            }
        }

        private void saveSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "xml files (*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<CameraXML> cams = new List<CameraXML>();
                foreach (Camera c in Cameras)
                {
                    cams.Add(new CameraXML(c));
                }
                List<LightXML> l = new List<LightXML>();
                foreach (Light light in Lights)
                {
                    l.Add(new LightXML(light));
                }

                List<CuboidXML> cuboids = new List<CuboidXML>();
                List<SphereXML> spheres = new List<SphereXML>();
                List<CylinderXML> cylinders = new List<CylinderXML>();
                List<ConeXML> cones = new List<ConeXML>();
                foreach (IFigure f in Figures)
                {
                    if (f is Cuboid) cuboids.Add(new CuboidXML(f as Cuboid));
                    else if (f is Sphere) spheres.Add(new SphereXML(f as Sphere));
                    else if (f is Cylinder) cylinders.Add(new CylinderXML(f as Cylinder));
                    else if (f is Cone) cones.Add(new ConeXML(f as Cone));
                }
                DummyXML xml = new DummyXML { Cameras = cams, Lights = l, Cuboids = cuboids, Spheres = spheres, Cylinders = cylinders, Cones = cones };
                XmlSerializer ser = new XmlSerializer(typeof(DummyXML), new Type[] { typeof(CuboidXML), typeof(SphereXML), typeof(CylinderXML), typeof(ConeXML) });
                TextWriter writer = new StreamWriter(dialog.FileName);
                ser.Serialize(writer, xml);
                writer.Close();
            }
        }

        private void loadSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "xml files (*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer ser = new XmlSerializer(typeof(DummyXML));
                FileStream fs = new FileStream(dialog.FileName, FileMode.Open);
                DummyXML xml = (DummyXML)ser.Deserialize(fs);
                RefreshTimer.Stop();
                BindingList<Camera> newCameras = new BindingList<Camera>();
                Lights.Clear();
                Figures.Clear();
                xml.Cameras.ForEach(c => newCameras.Add(new Camera(c)));
                xml.Lights.ForEach(l => Lights.Add(new Light(l)));
                xml.Cuboids.ForEach(f => Figures.Add(new Cuboid(f)));
                xml.Spheres.ForEach(f => Figures.Add(new Sphere(f)));
                xml.Cylinders.ForEach(f => Figures.Add(new Cylinder(f)));
                xml.Cones.ForEach(f => Figures.Add(new Cone(f)));
                Cameras = newCameras;
                CameraListBox.DataSource = Cameras;
                CameraListBox.ClearSelected();
                CameraListBox.SetSelected(0, true);
                SelectedCamera = Cameras.First();
                if (Cameras.Count == 1)
                {
                    RemoveCameraButton.Enabled = false;
                }
                else RemoveCameraButton.Enabled = true;
                if (Lights.Count != 0)
                {
                    LightListBox.ClearSelected();
                    LightListBox.SetSelected(0, true);
                    SelectedLight = Lights[0];
                    LightGroupBox.Enabled = true;
                    RemoveLightButton.Enabled = true;
                }
                else
                {
                    SelectedLight = null;
                    LightListBox.ClearSelected();
                    LightGroupBox.Enabled = false;
                    RemoveLightButton.Enabled = false;
                }
                Lights.ResetBindings();
                CameraListBox.SelectedIndex = 0;
                FigureDataGrid.Refresh();
                RefreshTimer.Start();
            }
        }
    }
}
