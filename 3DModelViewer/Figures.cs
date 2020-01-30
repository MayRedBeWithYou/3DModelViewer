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
        private float dimX = 2f;
        private float dimY = 2f;
        private float dimZ = 2f;

        private float rotX = 0f;
        private float rotY = 0f;
        private float rotZ = 0f;

        public List<Triangle> Triangles { get; } = new List<Triangle>();

        public Point4 Center { get; set; } = new Point4();

        public float DimX
        {
            get => dimX;
            set
            {
                dimX = value;
                CreateTriangles();
            }
        }

        public float DimY
        {
            get => dimY;
            set
            {
                dimY = value;
                CreateTriangles();
            }
        }

        public float DimZ
        {
            get => dimZ;
            set
            {
                dimZ = value;
                CreateTriangles();
            }
        }
        public Vector4 Scale
        {
            get
            {
                return new Vector4(DimX / 2f, DimY / 2f, DimZ / 2f, 0);
            }
            set
            {
                dimX = value.X * 2f;
                dimY = value.Y * 2f;
                dimZ = value.Z * 2f;
                CreateTriangles();
            }
        }

        public float RotX { get => rotX; set => rotX = value; }
        public float RotY { get => rotY; set => rotY = value; }
        public float RotZ { get => rotZ; set => rotZ = value; }

        public Vector4 Rotation
        {
            get
            {
                return new Vector4(rotX, rotY, rotZ, 0);
            }
            set
            {
                rotX = value.X;
                rotY = value.Y;
                rotZ = value.Z;
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
            Triangles.Add(new Triangle(new Point4(P1), new Point4(P2), new Point4(P5)));
            Triangles.Add(new Triangle(new Point4(P2), new Point4(P6), new Point4(P5)));

            ///Back
            Triangles.Add(new Triangle(new Point4(P3), new Point4(P4), new Point4(P7)));
            Triangles.Add(new Triangle(new Point4(P4), new Point4(P8), new Point4(P7)));

            ///Up
            Triangles.Add(new Triangle(new Point4(P5), new Point4(P6), new Point4(P8)));
            Triangles.Add(new Triangle(new Point4(P6), new Point4(P7), new Point4(P8)));

            ///Down
            Triangles.Add(new Triangle(new Point4(P1), new Point4(P2), new Point4(P4)));
            Triangles.Add(new Triangle(new Point4(P2), new Point4(P3), new Point4(P4)));

            ///Left
            Triangles.Add(new Triangle(new Point4(P2), new Point4(P3), new Point4(P6)));
            Triangles.Add(new Triangle(new Point4(P3), new Point4(P7), new Point4(P6)));

            ///Right
            Triangles.Add(new Triangle(new Point4(P4), new Point4(P1), new Point4(P8)));
            Triangles.Add(new Triangle(new Point4(P1), new Point4(P5), new Point4(P8)));

        }
    }

    public class Sphere : IFigure
    {
        private float radius = 2f;
        private int lat = 20;
        private int lon = 20;

        private float rotX = 0f;
        private float rotY = 0f;
        private float rotZ = 0f;

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


        public List<Triangle> Triangles { get; } = new List<Triangle>();

        public Point4 Center { get; set; } = new Point4();
        public Color Color { get; set; } = Color.CornflowerBlue;

        public string DisplayName => $"Sphere (X:{Center.X.ToString("f2")}, Y:{Center.Y.ToString("f2")}, Z:{Center.Z.ToString("f2")})";

        public bool Visibility { get; set; } = true;
        public Vector4 Scale { get; set; } = new Vector4(1, 1, 1, 0);

        public float RotX { get => rotX; set => rotX = value; }
        public float RotY { get => rotY; set => rotY = value; }
        public float RotZ { get => rotZ; set => rotZ = value; }

        public Vector4 Rotation
        {
            get
            {
                return new Vector4(rotX, rotY, rotZ, 0);
            }
            set
            {
                rotX = value.X;
                rotY = value.Y;
                rotZ = value.Z;
            }
        }

        private void CreateTriangles()
        {
            Triangles.Clear();
            for (float m = 0; m < lon; m++)
            {
                float theta1 = (float)(m / lon * Math.PI);
                float theta2 = (float)((m + 1) / lon * Math.PI);

                for (float p = 0; p < lat; p++)
                {
                    float phi1 = (float)(p / lat * 2f * Math.PI);
                    float phi2 = (float)((p + 1) / lat * 2f * Math.PI);

                    Point4 p1 = new Point4(radius * (float)Math.Sin(theta1) * (float)Math.Cos(phi1), radius * (float)Math.Cos(phi1), radius * (float)Math.Sin(theta1) * (float)Math.Sin(phi1), 1);
                    Point4 p2 = new Point4(radius * (float)Math.Sin(theta1) * (float)Math.Cos(phi2), radius * (float)Math.Cos(phi2), radius * (float)Math.Sin(theta1) * (float)Math.Sin(phi2), 1);
                    Point4 p3 = new Point4(radius * (float)Math.Sin(theta2) * (float)Math.Cos(phi2), radius * (float)Math.Cos(phi2), radius * (float)Math.Sin(theta2) * (float)Math.Sin(phi2), 1);
                    Point4 p4 = new Point4(radius * (float)Math.Sin(theta2) * (float)Math.Cos(phi1), radius * (float)Math.Cos(phi1), radius * (float)Math.Sin(theta2) * (float)Math.Sin(phi1), 1);

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
