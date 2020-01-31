using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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

    public class Matrix
    {
        private readonly float[,] fields = new float[4, 4];
        public float this[int x, int y]
        {
            get => fields[x, y];
            set
            {
                fields[x, y] = value;
            }
        }

        public Matrix(Matrix m)
        {
            fields = m.fields;
        }

        public Matrix(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            fields[0, 0] = x;
            fields[1, 1] = y;
            fields[2, 2] = z;
            fields[3, 3] = w;
        }

        public static Matrix Scale(float x, float y, float z)
        {
            return new Matrix(x, y, z, 1);
        }

        public static Matrix Scale(Vector4 v)
        {
            return new Matrix(v.X, v.Y, v.Z, 1);
        }

        public static Matrix Translate(float x, float y, float z)
        {
            Matrix N = new Matrix(1, 1, 1, 1);
            N[0, 3] = x;
            N[1, 3] = y;
            N[2, 3] = z;
            return N;
        }

        public static Matrix Translate(Vector4 v)
        {
            Matrix N = new Matrix(1, 1, 1, 1);
            N[0, 3] = v.X;
            N[1, 3] = v.Y;
            N[2, 3] = v.Z;
            return N;
        }

        public static Matrix RotateX(double deg)
        {
            float cos = (float)Math.Cos(deg);
            float sin = (float)Math.Sin(deg);
            Matrix N = new Matrix(1, cos, cos, 1);
            N[1, 2] = -sin;
            N[2, 1] = sin;
            return N;
        }

        public static Matrix RotateY(double deg)
        {
            float cos = (float)Math.Cos(deg);
            float sin = (float)Math.Sin(deg);
            Matrix N = new Matrix(cos, 1, cos, 1);
            N[0, 2] = -sin;
            N[2, 0] = sin;
            return N;
        }

        public static Matrix RotateZ(double deg)
        {
            float cos = (float)Math.Cos(deg);
            float sin = (float)Math.Sin(deg);
            Matrix N = new Matrix(cos, cos, 1, 1);
            N[0, 1] = -sin;
            N[1, 0] = sin;
            return N;
        }

        public static Matrix Proj(float fov, float n, float f, float aspect)
        {
            float ctg = (float)(1 / Math.Tan(fov / 2d));
            Matrix N = new Matrix(ctg / aspect, ctg, -(f + n) / (f - n), 0);
            N[3, 2] = -1;
            N[2, 3] = (-2 * f * n) / (f - n);
            return N;
        }

        public static Matrix operator +(Matrix M, Matrix N)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    result[i, j] = M[i, j] + N[i, j];
            return result;
        }

        public static Matrix operator -(Matrix M, Matrix N)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    result[i, j] = M[i, j] - N[i, j];
            return result;
        }

        public static Matrix operator *(Matrix M, Matrix N)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        result[i, j] = result[i, j] + M[i, k] * N[k, j];

            return result;
        }

        public static Matrix operator *(float k, Matrix N)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    result[i, j] = k * N[i, j];
            return result;
        }

        public static Vector4 operator *(Matrix M, Vector4 V)
        {
            Vector4 R = new Vector4
            {
                X = (float)(M[0, 0] * V.X + M[0, 1] * V.Y + M[0, 2] * V.Z + M[0, 3] * V.W),
                Y = (float)(M[1, 0] * V.X + M[1, 1] * V.Y + M[1, 2] * V.Z + M[1, 3] * V.W),
                Z = (float)(M[2, 0] * V.X + M[2, 1] * V.Y + M[2, 2] * V.Z + M[2, 3] * V.W),
                W = (float)(M[3, 0] * V.X + M[3, 1] * V.Y + M[3, 2] * V.Z + M[3, 3] * V.W)
            };
            return R;
        }

        public Matrix Transpose()
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result[j, i] = this[i, j];
                }
            }
            return result;
        }

        public Matrix Inverse()
        {
            Matrix4x4 matrix = new Matrix4x4(
                this[0, 0], this[0, 1], this[0, 2], this[0, 3],
                this[1, 0], this[1, 1], this[1, 2], this[1, 3],
                this[2, 0], this[2, 1], this[2, 2], this[2, 3],
                this[3, 0], this[3, 1], this[3, 2], this[3, 3]);
            Matrix4x4.Invert(matrix, out matrix);
            Matrix result = new Matrix();
            result[0, 0] = matrix.M11;
            result[0, 1] = matrix.M12;
            result[0, 2] = matrix.M13;
            result[0, 3] = matrix.M14;
            result[1, 0] = matrix.M21;
            result[1, 1] = matrix.M22;
            result[1, 2] = matrix.M23;
            result[1, 3] = matrix.M24;
            result[2, 0] = matrix.M11;
            result[2, 1] = matrix.M12;
            result[2, 2] = matrix.M13;
            result[2, 3] = matrix.M14;
            result[1, 0] = matrix.M21;
            result[1, 1] = matrix.M22;
            result[1, 2] = matrix.M23;
            result[1, 3] = matrix.M24;
            return result;
        }
    }
}
