using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastBitmapLib;


namespace _3DModelViewer
{
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
        public static bool FillTriangles = true;

        public static bool BackfaceCulling = true;

        public static bool ZBuffering = false;

        private static float[][] Depth;

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

        public static void DrawObjects(Bitmap bitmap, List<RenderInfo> infos, List<Light> lights)
        {
            if (ZBuffering)
            {
                Depth = new float[bitmap.Width][];
                Depth[0] = new float[bitmap.Height];
                for (int i = 0; i < bitmap.Height; i++) Depth[0][i] = float.MaxValue;
                for (int i = 1; i < bitmap.Width; i++)
                {
                    Depth[i] = new float[bitmap.Height];
                    Array.Copy(Depth[0], 0, Depth[i], 0, bitmap.Height);
                }
            }

            using (FastBitmap fast = bitmap.FastLock())
            {
                foreach (RenderInfo info in infos)
                {
                    foreach (Triangle t in info.triangles)
                    {
                        if (FillTriangles)
                        {
                            FillScanline(fast, t.Points.ToList(), info.color, lights);
                        }
                        else Outlines(fast, t.Points.ToList(), info.color);
                    }
                }
            }
        }

        private static void FillFlatTopTriangle(FastBitmap fast, Point4 v1, Point4 v2, Point4 v3, Color color)
        {
            float invslope1 = (v3.X - v1.X) / (v3.Y - v1.Y);
            float invslope2 = (v3.X - v2.X) / (v3.Y - v2.Y);
            float zslope1 = (v3.Z - v1.Z) / (v3.Y - v1.Y);
            float zslope2 = (v3.Z - v2.Z) / (v3.Y - v2.Y);

            if (v1.X > v2.X)
            {
                Swap(ref invslope1, ref invslope2);
                Swap(ref zslope1, ref zslope2);
            }
            float curX1 = v3.X;
            float curX2 = v3.X;

            float zL = v3.Z;
            float zR = v3.Z;

            for (int scanlineY = (int)v3.Y; scanlineY > v1.Y; scanlineY--)
            {
                float curZ = zL;
                float curQ = 1 / (float)((int)curX2 - (int)curX1);
                if (scanlineY > 0 && scanlineY < fast.Height)
                {
                    for (int i = (int)curX1; i < curX2; i++)
                    {
                        if (ZBuffering)
                        {
                            if (i > 0 && i < fast.Width)
                            {
                                if (curZ <= Depth[i][scanlineY])
                                {
                                    fast.SetPixel(i, scanlineY, color);
                                    Depth[i][scanlineY] = curZ;
                                }
                            }
                            float q = curQ * (i - (int)curX1);
                            curZ = zL * (1f - q) + zR * q;
                        }
                        else
                        {
                            if (i > 0 && i < fast.Width)
                            {
                                fast.SetPixel(i, scanlineY, color);
                            }
                        }
                    }
                }
                zL -= zslope1;
                zR -= zslope2;
                curX1 -= invslope1;
                curX2 -= invslope2;
            }
        }

        private static void FillFlatBottomTriangle(FastBitmap fast, Point4 v1, Point4 v2, Point4 v3, Color color)
        {
            float invslope1 = (v2.X - v1.X) / (v2.Y - v1.Y);
            float invslope2 = (v3.X - v1.X) / (v3.Y - v1.Y);
            float zslope1 = (v2.Z - v1.Z) / (v2.Y - v1.Y);
            float zslope2 = (v3.Z - v1.Z) / (v3.Y - v1.Y);
            if (v2.X > v3.X)
            {
                Swap(ref invslope1, ref invslope2);
                Swap(ref zslope1, ref zslope2);
            }
            float curX1 = v1.X;
            float curX2 = v1.X;

            float zL = v1.Z;
            float zR = v1.Z;

            for (int scanlineY = (int)v1.Y; scanlineY <= v2.Y; scanlineY++)
            {
                if (scanlineY > 0 && scanlineY < fast.Height)
                {
                    float curZ = zL;
                    float curQ = 1 / (float)((int)curX2 - (int)curX1);
                    for (int i = (int)curX1; i < curX2; i++)
                    {
                        if (ZBuffering)
                        {
                            if (i > 0 && i < fast.Width)
                            {
                                if (curZ <= Depth[i][scanlineY])
                                {
                                    fast.SetPixel(i, scanlineY, color);
                                    Depth[i][scanlineY] = curZ;
                                }
                            }
                            float q = curQ * (i - (int)curX1);
                            curZ = zL * (1f - q) + zR * q;
                        }
                        else
                        {
                            if (i > 0 && i < fast.Width)
                            {
                                fast.SetPixel(i, scanlineY, color);
                            }
                        }
                    }
                }
                zL += zslope1;
                zR += zslope2;
                curX1 += invslope1;
                curX2 += invslope2;
            }
        }

        public static void FillScanline(FastBitmap fast, List<Point4> points, Color color, List<Light> lights)
        {
            points.Sort((p, r) => p.Y.CompareTo(r.Y));
            Point4 v1 = points[0];
            Point4 v2 = points[1];
            Point4 v3 = points[2];

            if (v2.Y == v3.Y)
            {
                FillFlatBottomTriangle(fast, v1, v2, v3, color);
            }
            else if (v1.Y == v2.Y)
            {
                FillFlatTopTriangle(fast, v1, v2, v3, color);
            }
            else
            {
                float z4 = v1.Z + (v2.Y - v1.Y) * (v3.Z - v1.Z) / (v3.Y - v1.Y);
                Point4 v4 = new Point4((int)(v1.X + ((float)(v2.Y - v1.Y) / (float)(v3.Y - v1.Y)) * (v3.X - v1.X)), (int)v2.Y, z4);
                FillFlatBottomTriangle(fast, v1, v2, v4, color);
                FillFlatTopTriangle(fast, v2, v4, v3, color);
            }
            //Outlines(fast, points, Color.Black);
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
