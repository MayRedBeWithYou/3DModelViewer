using System.Numerics;

namespace _3DModelViewer
{
    public static class Vector
    {
        public static Vector4 Cross(Vector4 vector1, Vector4 vector2)
        {
            return new Vector4(
                vector1.Y * vector2.Z - vector1.Z * vector2.Y,
                vector1.Z * vector2.X - vector1.X * vector2.Z,
                vector1.X * vector2.Y - vector1.Y * vector2.X,
                vector1.W * vector2.W);
        }
    }
}
