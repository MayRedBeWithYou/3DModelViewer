using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3DModelViewer
{
    public interface IFigure
    {
        List<Triangle> Triangles { get; }
        Point4 Center { get; set; }

        Color Color { get; set; }

        string DisplayName { get; }

        bool Visibility { get; set; }

        Vector4 Scale { get; set; }

        Vector4 Rotation { get; set; }
    }

    public class Cuboid : IFigure
    {
        public List<Triangle> Triangles { get; } = new List<Triangle>();

        public Point4 Center { get; set; } = new Point4();

        public float DimX { get; set; } = 2f;

        public float DimY { get; set; } = 2f;

        public float DimZ { get; set; } = 2f;
        public Vector4 Scale
        {
            get
            {
                return new Vector4(DimX / 2f, DimY / 2f, DimZ / 2f, 0);
            }
            set
            {
                DimX = value.X * 2f;
                DimY = value.Y * 2f;
                DimZ = value.Z * 2f;
            }
        }

        public float RotX { get; set; } = 0f;
        public float RotY { get; set; } = 0f;
        public float RotZ { get; set; } = 0f;

        public Vector4 Rotation
        {
            get
            {
                return new Vector4(RotX, RotY, RotZ, 0);
            }
            set
            {
                RotX = value.X;
                RotY = value.Y;
                RotZ = value.Z;
            }
        }

        public Color Color { get; set; } = Color.Gold;

        public bool Visibility { get; set; } = true;

        public string DisplayName => $"Cuboid (X:{Center.X.ToString("f2")}, Y:{Center.Y.ToString("f2")}, Z:{Center.Z.ToString("f2")})";

        public Cuboid()
        {
            CreateTriangles();
        }
        public Cuboid(Point4 C)
        {
            Center = new Point4(C);
            CreateTriangles();
        }

        public Cuboid(float x = 2f, float y = 2f, float z = 2f)
        {
            DimX = x;
            DimY = y;
            DimY = z;
            CreateTriangles();
        }

        public Cuboid(Point4 C, float x = 2f, float y = 2f, float z = 2f)
        {
            Center = new Point4(C);
            DimX = x;
            DimY = y;
            DimY = z;
            CreateTriangles();
        }

        private void CreateTriangles()
        {
            Triangles.Clear();
            ///Lower vertices
            Point4 P1 = new Point4(DimX / 2f, -DimY / 2f, DimZ / 2f);
            Point4 P2 = new Point4(-DimX / 2f, -DimY / 2f, DimZ / 2f);
            Point4 P3 = new Point4(-DimX / 2f, -DimY / 2f, -DimZ / 2f);
            Point4 P4 = new Point4(DimX / 2f, -DimY / 2f, -DimZ / 2f);

            ///Higher vertices
            Point4 P5 = new Point4(DimX / 2f, DimY / 2f, DimZ / 2f);
            Point4 P6 = new Point4(-DimX / 2f, DimY / 2f, DimZ / 2f);
            Point4 P7 = new Point4(-DimX / 2f, DimY / 2f, -DimZ / 2f);
            Point4 P8 = new Point4(DimX / 2f, DimY / 2f, -DimZ / 2f);

            ///Front
            Triangles.Add(new Triangle(new Point4(P5), new Point4(P2), new Point4(P1)));
            Triangles.Add(new Triangle(new Point4(P5), new Point4(P6), new Point4(P2)));

            ///Back
            Triangles.Add(new Triangle(new Point4(P7), new Point4(P4), new Point4(P3)));
            Triangles.Add(new Triangle(new Point4(P7), new Point4(P8), new Point4(P4)));

            ///Up
            Triangles.Add(new Triangle(new Point4(P8), new Point4(P6), new Point4(P5)));
            Triangles.Add(new Triangle(new Point4(P8), new Point4(P7), new Point4(P6)));

            ///Down
            Triangles.Add(new Triangle(new Point4(P1), new Point4(P2), new Point4(P4)));
            Triangles.Add(new Triangle(new Point4(P2), new Point4(P3), new Point4(P4)));

            ///Left
            Triangles.Add(new Triangle(new Point4(P6), new Point4(P3), new Point4(P2)));
            Triangles.Add(new Triangle(new Point4(P6), new Point4(P7), new Point4(P3)));

            ///Right
            Triangles.Add(new Triangle(new Point4(P8), new Point4(P1), new Point4(P4)));
            Triangles.Add(new Triangle(new Point4(P8), new Point4(P5), new Point4(P1)));

        }
    }

    public class Sphere : IFigure
    {
        private float radius = 2f;
        private int lat = 12;
        private int lon = 12;

        public List<Triangle> Triangles { get; } = new List<Triangle>();

        public Point4 Center { get; set; } = new Point4();

        public Color Color { get; set; } = Color.CornflowerBlue;

        public string DisplayName => $"Sphere (X:{Center.X.ToString("f2")}, Y:{Center.Y.ToString("f2")}, Z:{Center.Z.ToString("f2")})";

        public bool Visibility { get; set; } = true;

        public Sphere()
        {
            CreateTriangles();
        }

        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                CreateTriangles();
            }
        }

        public int Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                CreateTriangles();
            }
        }

        public int Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                CreateTriangles();
            }
        }

        public float DimX { get; set; } = 1f;

        public float DimY { get; set; } = 1f;

        public float DimZ { get; set; } = 1f;

        public Vector4 Scale
        {
            get
            {
                return new Vector4(DimX, DimY, DimZ, 0);
            }
            set
            {
                DimX = value.X;
                DimY = value.Y;
                DimZ = value.Z;
            }
        }

        public float RotX { get; set; } = 0f;
        public float RotY { get; set; } = 0f;
        public float RotZ { get; set; } = 0f;

        public Vector4 Rotation
        {
            get
            {
                return new Vector4(RotX, RotY, RotZ, 0);
            }
            set
            {
                RotX = value.X;
                RotY = value.Y;
                RotZ = value.Z;
            }
        }

        private float Sin(float rad)
        {
            return (float)Math.Sin(rad);
        }

        private float Cos(float rad)
        {
            return (float)Math.Cos(rad);
        }

        private void CreateTriangles()
        {
            Triangles.Clear();

            for (float p = 0; p < lat; p++)
            {
                float phi1 = (float)(p / lat * 2f * Math.PI);
                float phi2 = (float)((p + 1) / lat * 2f * Math.PI);

                for (float m = 0; m < lon; m++)
                {
                    float theta1 = (float)(m / lon * Math.PI);
                    float theta2 = (float)((m + 1) / lon * Math.PI);

                    Point4 p1 = new Point4(radius * Sin(theta1) * Cos(phi1), radius * Cos(theta1), radius * Sin(theta1) * Sin(phi1), 1);
                    Point4 p2 = new Point4(radius * Sin(theta1) * Cos(phi2), radius * Cos(theta1), radius * Sin(theta1) * Sin(phi2), 1);
                    Point4 p3 = new Point4(radius * Sin(theta2) * Cos(phi2), radius * Cos(theta2), radius * Sin(theta2) * Sin(phi2), 1);
                    Point4 p4 = new Point4(radius * Sin(theta2) * Cos(phi1), radius * Cos(theta2), radius * Sin(theta2) * Sin(phi1), 1);

                    if (m == 0)
                        Triangles.Add(new Triangle(new Point4(p1), new Point4(p3), new Point4(p4)));
                    else if (m + 1 == lon)
                        Triangles.Add(new Triangle(new Point4(p3), new Point4(p1), new Point4(p2)));
                    else
                    {
                        Triangles.Add(new Triangle(new Point4(p1), new Point4(p2), new Point4(p4)));
                        Triangles.Add(new Triangle(new Point4(p2), new Point4(p3), new Point4(p4)));
                    }
                }
            }
        }
    }
}
