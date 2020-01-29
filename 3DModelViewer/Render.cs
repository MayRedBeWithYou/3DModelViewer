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
        public Point4 Position = new Point4(3,3,3);

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

        public Camera() { }

        public Camera(Point4 pos)
        {
            Position = pos;
        }
        public Camera(Point4 pos, Point4 target)
        {
            Position = pos;
            Target = target;
        }
    }

    public static class Render
    {
        public static void Clear(Bitmap bitmap)
        {
            using (FastBitmap fast = bitmap.FastLock())
            {
                fast.Clear(Color.FromArgb(25,25,50));
            }
        }

        public static void DrawAxes(Bitmap bitmap, Point center, Point OX, Point OY, Point OZ)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawLine(new Pen(Color.Red, 3), center, OX);
                g.DrawLine(new Pen(Color.Green, 3), center, OY);
                g.DrawLine(new Pen(Color.Blue, 3), center, OZ);
            }
        }

        public static void Fill(Bitmap bitmap, Point[] poly, Color c, bool outline = false)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillPolygon(new SolidBrush(c), poly);
                if (outline) g.DrawPolygon(new Pen(Color.Black), poly);
            }
        }



        public static void FillScanline(Bitmap bitmap, List<Point4> points, Color color)
        {
            points.Sort((p, r) => p.Y.CompareTo(r.Y));
            Point4 v1 = points[0];
            Point4 v2 = points[1];
            Point4 v3 = points[2];

            using (FastBitmap fast = bitmap.FastLock())
            {
                if (v2.Y == v3.Y)
                {
                    float invslope1 = (v2.X - v1.X) / (v2.Y - v1.Y);
                    float invslope2 = (v3.X - v1.X) / (v3.Y - v1.Y);

                    float curX1 = v1.X;
                    float curX2 = v1.X;

                    for (int scanlineY = (int)v1.Y; scanlineY <= v2.Y; scanlineY++)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            fast.SetPixel(i, scanlineY, color);
                        }
                        curX1 += invslope1;
                        curX2 += invslope2;
                    }
                }
                else if (v1.Y == v2.Y)
                {
                    float invslope1 = (v3.X - v1.X) / (v3.Y - v1.Y);
                    float invslope2 = (v3.X - v2.X) / (v3.Y - v2.Y);

                    float curX1 = v3.X;
                    float curX2 = v3.X;

                    for (int scanlineY = (int)v3.Y; scanlineY > v1.Y; scanlineY--)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            fast.SetPixel(i, scanlineY, color);
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

                    float curX1 = v1.X;
                    float curX2 = v1.X;

                    for (int scanlineY = (int)v1.Y; scanlineY <= v2.Y; scanlineY++)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            fast.SetPixel(i, scanlineY, color);
                        }
                        curX1 += invslope1;
                        curX2 += invslope2;
                    }

                    invslope1 = (v3.X - v2.X) / (v3.Y - v2.Y);
                    invslope2 = (v3.X - v4.X) / (v3.Y - v4.Y);

                    curX1 = v3.X;
                    curX2 = v3.X;

                    for (int scanlineY = (int)v3.Y; scanlineY > v2.Y; scanlineY--)
                    {
                        for (int i = (int)curX1; i < curX2; i++)
                        {
                            fast.SetPixel(i, scanlineY, color);
                        }
                        curX1 -= invslope1;
                        curX2 -= invslope2;
                    }
                }
            }
        
        }
    }
}
