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
        Point3 Center { get; set; }

        Color Color { get; set; }

        string DisplayName { get; }

        bool Visibility { get; set; }

        Vector4 Scale { get; set; }

        Vector4 Rotation { get; set; }
}

    public class Cuboid : IFigure
    {
        public List<Triangle> Triangles { get; } = new List<Triangle>();

        public Point3 Center { get; set; } = new Point3();

        public float DimX { get; set; } = 2f;
        public float DimY { get; set; } = 2f;
        public float DimZ { get; set; } = 2f;

        public Vector4 Scale { get; set; } = new Vector4(1, 1, 1, 0);

        public Vector4 Rotation { get; set; } = new Vector4(0, 0, 0, 0);

        public Color Color { get; set; } = Color.Gold;

        public bool Visibility { get; set; } = true;

        public string DisplayName => $"Cuboid (X:{Center.X.ToString("f2")}, Y:{Center.Y.ToString("f2")}, Z:{Center.Z.ToString("f2")})";

        public Cuboid()
        {
            CreateTriangles();
        }
        public Cuboid(Point3 C)
        {
            Center = new Point3(C);
            CreateTriangles();
        }

        public Cuboid(float x = 2f, float y = 2f, float z = 2f)
        {
            DimX = x;
            DimY = y;
            DimY = z;
            CreateTriangles();
        }

        public Cuboid(Point3 C, float x = 2f, float y = 2f, float z = 2f)
        {
            Center = new Point3(C);
            DimX = x;
            DimY = y;
            DimY = z;
            CreateTriangles();
        }

        private void CreateTriangles()
        {
            ///Lower vertices
            Point3 P1 = new Point3(Center.X + DimX / 2f, Center.Y - DimY / 2f, Center.Z + DimZ / 2f);
            Point3 P2 = new Point3(Center.X - DimX / 2f, Center.Y - DimY / 2f, Center.Z + DimZ / 2f);
            Point3 P3 = new Point3(Center.X - DimX / 2f, Center.Y - DimY / 2f, Center.Z - DimZ / 2f);
            Point3 P4 = new Point3(Center.X + DimX / 2f, Center.Y - DimY / 2f, Center.Z - DimZ / 2f);

            ///Higher vertices
            Point3 P5 = new Point3(Center.X + DimX / 2f, Center.Y + DimY / 2f, Center.Z + DimZ / 2f);
            Point3 P6 = new Point3(Center.X - DimX / 2f, Center.Y + DimY / 2f, Center.Z + DimZ / 2f);
            Point3 P7 = new Point3(Center.X - DimX / 2f, Center.Y + DimY / 2f, Center.Z - DimZ / 2f);
            Point3 P8 = new Point3(Center.X + DimX / 2f, Center.Y + DimY / 2f, Center.Z - DimZ / 2f);

            ///Front
            Triangles.Add(new Triangle(new Point3(P1), new Point3(P2), new Point3(P5)));
            Triangles.Add(new Triangle(new Point3(P2), new Point3(P6), new Point3(P5)));

            ///Back
            Triangles.Add(new Triangle(new Point3(P4), new Point3(P3), new Point3(P8)));
            Triangles.Add(new Triangle(new Point3(P3), new Point3(P7), new Point3(P8)));

            ///Up
            Triangles.Add(new Triangle(new Point3(P5), new Point3(P6), new Point3(P8)));
            Triangles.Add(new Triangle(new Point3(P6), new Point3(P7), new Point3(P8)));

            ///Down
            Triangles.Add(new Triangle(new Point3(P1), new Point3(P2), new Point3(P4)));
            Triangles.Add(new Triangle(new Point3(P2), new Point3(P3), new Point3(P4)));

            ///Left
            Triangles.Add(new Triangle(new Point3(P5), new Point3(P6), new Point3(P8)));
            Triangles.Add(new Triangle(new Point3(P6), new Point3(P7), new Point3(P8)));

            ///Right
            Triangles.Add(new Triangle(new Point3(P2), new Point3(P3), new Point3(P6)));
            Triangles.Add(new Triangle(new Point3(P7), new Point3(P6), new Point3(P3)));

        }
    }
}
