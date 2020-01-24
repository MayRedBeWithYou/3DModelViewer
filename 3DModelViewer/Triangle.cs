using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DModelViewer
{
    public class PointD
    {
        public double X;
        public double Y;
        public double Z;

        public Vector Normal = new Vector();
        public Vector Binormal = new Vector();
        public Vector Tangent = new Vector();

        public Vector V => new Vector(X, Y, Z, 1);

        public PointD(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public PointD(Point3 A)
        {
            X = A.X;
            Y = A.Y;
            Z = A.Z;
            Normal = new Vector(A.Normal);
            Binormal = new Vector(A.Binormal);
            Tangent = new Vector(A.Tangent);
        }
    }


    public class Point3
    {
        public int X;
        public int Y;
        public int Z;

        public Vector Normal = new Vector();
        public Vector Binormal = new Vector();
        public Vector Tangent = new Vector();

        public Vector V => new Vector(X, Y, Z, 1);

        public Point3(int x = 0, int y = 0, int z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator System.Drawing.Point(Point3 p)
        {
            return new System.Drawing.Point(p.X, p.Y);
        }

        public Point3(Point3 A)
        {
            X = A.X;
            Y = A.Y;
            Z = A.Z;
            Normal = new Vector(A.Normal);
            Binormal = new Vector(A.Binormal);
            Tangent = new Vector(A.Tangent);
        }
    }

    public class Triangle
    {
        private Point3[] points = new Point3[3];

        public Point3[] Points => points;

        public Triangle(Point3 p1, Point3 p2, Point3 p3)
        {
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }

        public Point3 this[int i]
        {
            get => points[i];
            set
            {
                points[i] = value;
            }
        }
    }
}
