using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using FastBitmapLib;


namespace _3DModelViewer
{
    public class Camera
    {
        private Point4 defaultPosition = new Point4(3, 3, 4);

        public Point4 Position;

        public string DisplayName => $"Camera (X:{Position.X.ToString("f2")}, Y:{Position.Y.ToString("f2")}, Z:{Position.Z.ToString("f2")})";

        public Point4 Target = new Point4();

        public int FOV = 60;

        public Vector4 Normal
        {
            get
            {
                return Vector4.Normalize(Target.V - Position.V);
            }
        }

        public Vector4 Tangent
        {
            get
            {
                return Vector4.Normalize(Vector.Cross(Normal, Vector4.UnitY));
            }
        }

        public Vector4 Binormal
        {
            get
            {
                return Vector4.Normalize(Vector.Cross(Normal, Tangent));
            }
        }

        public Camera()
        {
            Position = new Point4(defaultPosition);
        }

        public Camera(Point4 pos)
        {
            Position = pos;
        }
        public Camera(Point4 pos, Point4 target)
        {
            Position = pos;
            Target = target;
        }

        public void Reset()
        {
            Position = new Point4(defaultPosition);
            Target = new Point4();
            FOV = 60;
        }
    }

    public class RenderInfo
    {
        public List<Triangle> triangles;
        public Color color;
        public bool outline;

        public RenderInfo(List<Triangle> triangles, Color color, bool outline)
        {
            this.triangles = triangles;
            this.color = color;
            this.outline = outline;
        }
    }

    public static class Render
    {
        public static void Clear(Bitmap bitmap)
        {
            using (FastBitmap fast = bitmap.FastLock())
            {
                fast.Clear(Color.FromArgb(25, 25, 50));
            }
        }

        public static void DrawAxes(Bitmap bitmap, Point center, Point OX, Point OY, Point OZ)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                try
                {
                    g.DrawLine(new Pen(Color.Red, 3), center, OX);
                    g.DrawLine(new Pen(Color.Green, 3), center, OY);
                    g.DrawLine(new Pen(Color.Blue, 3), center, OZ);
                }
                catch { }
            }
        }

        private static void Swap(ref float a, ref float b)
        {
            float tmp = a;
            a = b;
            b = tmp;
        }

        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void DrawObjects(Bitmap bitmap, List<RenderInfo> infos, bool filling)
        {
            using (FastBitmap fast = bitmap.FastLock())
            {
                foreach (RenderInfo info in infos)
                {
                    foreach (Triangle t in info.triangles)
                    {
                        if (filling)
                        {
                            FillScanline(fast, t.Points.ToList(), info.color);
                        }
                        //else Outlines(fast, t.Points.ToList(), info.outline ? Color.White : info.color);
                        else Outlines(fast, t.Points.ToList(), info.color);
                    }
                    //if(info.outline)
                    //{
                    //    foreach(Triangle t in info.triangles)
                    //    {
                    //        Outlines(fast, t.Points.ToList(), Color.White);
                    //    }
                    //}
                }
            }
        }

        public static void FillScanline(FastBitmap fast, List<Point4> points, Color color)
        {
            points.Sort((p, r) => p.Y.CompareTo(r.Y));
            Point4 v1 = points[0];
            Point4 v2 = points[1];
            Point4 v3 = points[2];
            if (v2.Y == v3.Y)
            {
                float invslope1 = (v2.X - v1.X) / (v2.Y - v1.Y);
                float invslope2 = (v3.X - v1.X) / (v3.Y - v1.Y);

                if (v2.X > v3.X) Swap(ref invslope1, ref invslope2);

                float curX1 = v1.X;
                float curX2 = v1.X;

                for (int scanlineY = (int)v1.Y; scanlineY <= v2.Y; scanlineY++)
                {
                    if (scanlineY > 0 && scanlineY < fast.Height)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            if (i > 0 && i < fast.Width)
                                fast.SetPixel(i, scanlineY, color);
                        }
                    }
                    curX1 += invslope1;
                    curX2 += invslope2;
                }
            }
            else if (v1.Y == v2.Y)
            {
                float invslope1 = (v3.X - v1.X) / (v3.Y - v1.Y);
                float invslope2 = (v3.X - v2.X) / (v3.Y - v2.Y);

                if (v1.X > v2.X) Swap(ref invslope1, ref invslope2);
                float curX1 = v3.X;
                float curX2 = v3.X;

                for (int scanlineY = (int)v3.Y; scanlineY > v1.Y; scanlineY--)
                {
                    if (scanlineY > 0 && scanlineY < fast.Height)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            if (i > 0 && i < fast.Width)
                                fast.SetPixel(i, scanlineY, color);
                        }
                    }
                    curX1 -= invslope1;
                    curX2 -= invslope2;
                }
            }
            else
            {

                Point v4 = new Point4(
                   (int)(v1.X + ((float)(v2.Y - v1.Y) / (float)(v3.Y - v1.Y)) * (v3.X - v1.X)), v2.Y);

                //Fill bottom triangle

                float invslope1 = (v2.X - v1.X) / (v2.Y - v1.Y);
                float invslope2 = (v4.X - v1.X) / (v4.Y - v1.Y);

                if (v2.X > v4.X) Swap(ref invslope1, ref invslope2);

                float curX1 = v1.X;
                float curX2 = v1.X;


                for (int scanlineY = (int)v1.Y; scanlineY <= v2.Y; scanlineY++)
                {
                    if (scanlineY > 0 && scanlineY < fast.Height)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            if (i > 0 && i < fast.Width)
                                fast.SetPixel(i, scanlineY, color);
                        }
                    }

                    curX1 += invslope1;
                    curX2 += invslope2;
                }

                invslope1 = (v3.X - v2.X) / (v3.Y - v2.Y);
                invslope2 = (v3.X - v4.X) / (v3.Y - v4.Y);

                if (v2.X > v4.X) Swap(ref invslope1, ref invslope2);

                curX1 = v3.X;
                curX2 = v3.X;

                for (int scanlineY = (int)v3.Y; scanlineY > v2.Y; scanlineY--)
                {
                    if (scanlineY > 0 && scanlineY < fast.Height)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            if (i > 0 && i < fast.Width)
                                fast.SetPixel(i, scanlineY, color);
                        }
                    }
                    curX1 -= invslope1;
                    curX2 -= invslope2;
                }
            }
        }

        public static void Outlines(FastBitmap fast, List<Point4> points, Color color)
        {
            DrawLine(fast, points[0], points[1], color);
            DrawLine(fast, points[1], points[2], color);
            DrawLine(fast, points[2], points[0], color);
        }

        private static void DrawLine(FastBitmap fast, Point4 v0, Point4 v1, Color color)
        {
            int x0 = (int)v0.X;
            int y0 = (int)v0.Y;
            int x1 = (int)v1.X;
            int y1 = (int)v1.Y;
            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            int dX = (x1 - x0);
            int dY = Math.Abs(y1 - y0);
            int err = (dX / 2);
            int ystep = (y0 < y1 ? 1 : -1);
            int y = y0;

            for (int x = x0; x <= x1; ++x)
            {
                if (steep)
                {
                    if (y > 0 && y < fast.Width && x > 0 && x < fast.Height)
                        fast.SetPixel(y, x, color);
                }
                else
                {
                    if (y > 0 && y < fast.Height && x > 0 && x < fast.Width)
                        fast.SetPixel(x, y, color);
                }

                err -= dY;
                if (err < 0)
                {
                    y += ystep;
                    err += dX;
                }

            }
        }
    }
}
