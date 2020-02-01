using System.Drawing;
using System.Numerics;

namespace _3DModelViewer
{
    public class Point4
    {
        public float X;

        public float Y;

        public float Z;

        public float W = 1f;

        public Vector4 Normal = new Vector4();

        public Vector4 Binormal = new Vector4();

        public Vector4 Tangent = new Vector4();

        public Vector4 V
        {
            get
            {
                return new Vector4(X, Y, Z, 1);
            }
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        public Point4() { }

        public Point4(float x = 0, float y = 0, float z = 0, float w = 1)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public static implicit operator Point(Point4 p)
        {
            return new Point((int)p.X, (int)p.Y);
        }

        public Point4(Point4 A)
        {
            X = A.X;
            Y = A.Y;
            Z = A.Z;
            Normal = new Vector4(A.Normal.X, A.Normal.Y, A.Normal.Z, A.Normal.W);
            Binormal = new Vector4(A.Binormal.X, A.Binormal.Y, A.Binormal.Z, A.Binormal.W);
            Tangent = new Vector4(A.Tangent.X, A.Tangent.Y, A.Tangent.Z, A.Tangent.W);
        }

        public void FloorXY()
        {
            X = (int)X;
            Y = (int)Y;
        }
    }
}
