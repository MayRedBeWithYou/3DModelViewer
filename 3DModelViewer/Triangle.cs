using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _3DModelViewer
{
    public class Triangle
    {
        private readonly Point4[] points = new Point4[3];

        public Point4[] Points => points;

        public Triangle(Point4 p1, Point4 p2, Point4 p3)
        {
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            RecalculateNormal();
        }

        public Point4 this[int i]
        {
            get => points[i];
            set
            {
                points[i] = value;
                RecalculateNormal();
            }
        }

        public Vector4 Normal { get; set; }

        private void RecalculateNormal()
        {
            Vector4 U = points[1].V - points[0].V;
            Vector4 V = points[2].V - points[0].V;
            Normal = Vector.Cross(U, V);
        }
    }
}
