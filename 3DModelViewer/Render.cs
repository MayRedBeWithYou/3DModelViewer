using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastBitmapLib;


namespace _3DModelViewer
{
    public static class Render
    {
        public static void Clear(Bitmap bitmap)
        {
            using (FastBitmap fast = bitmap.FastLock())
            {
                fast.Clear(Color.Black);
            }
        }

        public static void Fill(Bitmap bitmap, Point[] poly, Color c)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillPolygon(new SolidBrush(c), poly);               
            }
        }

        public static void FillTriangle(Bitmap bitmap, Triangle t, Color color)
        {
            List<Point3> points = new List<Point3>();
            points.Add(t[0]);
            points.Add(t[1]);
            points.Add(t[2]);
            points.Sort((a, b) => b.Y.CompareTo(a.Y));
            Point3 A = points[0];
            Point3 B = points[1];
            Point3 C = points[2];

            double dx1;
            double dx2;
            double dx3;

            using (FastBitmap fast = bitmap.FastLock())
            {
                if (B.Y - A.Y > 0) dx1 = (B.X - A.X) / (B.Y - A.Y);
                else dx1 = 0;
                if (C.Y - A.Y > 0) dx2 = (C.X - A.X) / (C.Y - A.Y);
                else dx2 = 0;
                if (C.Y - B.Y > 0) dx3 = (C.X - B.X) / (C.Y - B.Y);
                else dx3 = 0;
                PointD S = new PointD(A);
                PointD E = new PointD(A);
                if (dx1 > dx2)
                {
                    for (; S.Y <= B.Y; S.Y++, E.Y++, S.X += dx2, E.X += dx1)
                        for (int i = (int)S.X; i < E.X; i++)
                        {
                            fast.SetPixel(i, (int)S.Y, color);
                        }
                    E = new PointD(B);
                    for (; S.Y <= C.Y; S.Y++, E.Y++, S.X += dx2, E.X += dx3)
                        for (int i = (int)S.X; i < E.X; i++)
                        {
                            fast.SetPixel(i, (int)S.Y, color);
                        }
                }
                else
                {
                    for (; S.Y <= B.Y; S.Y++, E.Y++, S.X += dx1, E.X += dx2)
                        for (int i = (int)S.X; i < E.X; i++)
                        {
                            fast.SetPixel(i, (int)S.Y, color);
                        }
                    S = new PointD(B);
                    for (; S.Y <= C.Y; S.Y++, E.Y++, S.X += dx3, E.X += dx2)
                        for (int i = (int)S.X; i < E.X; i++)
                        {
                            fast.SetPixel(i, (int)S.Y, color);
                        }
                }
            }
        }
    }
}
