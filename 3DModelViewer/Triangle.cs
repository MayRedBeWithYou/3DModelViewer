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

        public PointD(Point A)
        {
            X = A.X;
            Y = A.Y;
            Z = A.Z;
            Normal = new Vector(A.Normal);
            Binormal = new Vector(A.Binormal);
            Tangent = new Vector(A.Tangent);
        }
    }


    public class Point
    {
        public int X;
        public int Y;
        public int Z;

        public Vector Normal = new Vector();
        public Vector Binormal = new Vector();
        public Vector Tangent = new Vector();

        public Vector V => new Vector(X, Y, Z, 1);

        public Point(int x = 0, int y = 0, int z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point(Point A)
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
        private Point[] points = new Point[3];

        public Triangle(Point p1, Point p2, Point p3)
        {
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }

        public Point this[int i]
        {
            get => points[i];
            set
            {
                points[i] = value;
            }
        }
    }
}
