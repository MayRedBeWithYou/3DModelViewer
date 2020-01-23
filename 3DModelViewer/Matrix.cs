using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DModelViewer
{
    public class Vector
    {
        private double[] fields = new double[4];
        public double this[int i]
        {
            get => fields[i];
            set
            {
                fields[i] = value;
            }
        }

        public Vector(Vector m)
        {
            fields = m.fields;
        }

        public Vector(double x = 0, double y = 0, double z = 0, double w = 0)
        {
            fields[0] = x;
            fields[1] = y;
            fields[2] = z;
            fields[3] = w;
        }

    }


    public class Matrix
    {
        private double[,] fields = new double[4, 4];
        public double this[int x, int y]
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

        public Matrix(double x = 0, double y = 0, double z = 0, double w = 0)
        {
            fields[0, 0] = x;
            fields[1, 1] = y;
            fields[2, 2] = z;
            fields[3, 3] = w;
        }

        public static Matrix Scale(double x, double y, double z)
        {
            return new Matrix(x, y, z, 1);
        }

        public static Matrix Translate(double x, double y, double z)
        {
            Matrix N = new Matrix(1, 1, 1, 1);
            N[0, 3] = x;
            N[1, 3] = y;
            N[2, 3] = z;
            return N;
        }

        public static Matrix RotateX(int deg)
        {
            Matrix N = new Matrix(1, Math.Cos(deg), Math.Cos(deg), 1);
            N[1, 2] = -Math.Sin(deg);
            N[2, 1] = Math.Sin(deg);
            return N;
        }

        public static Matrix RotateY(int deg)
        {
            Matrix N = new Matrix(Math.Cos(deg), 1, Math.Cos(deg), 1);
            N[0, 2] = -Math.Sin(deg);
            N[2, 0] = Math.Sin(deg);
            return N;
        }

        public static Matrix RotateZ(int deg)
        {
            Matrix N = new Matrix(Math.Cos(deg), Math.Cos(deg), 1, 1);
            N[0, 1] = -Math.Sin(deg);
            N[1, 0] = Math.Sin(deg);
            return N;
        }

        public static Matrix Proj(double fov, double n, double f, double aspect)
        {
            double ctg = 1d / Math.Tan(fov / 2d);
            Matrix N = new Matrix(ctg / aspect, ctg, (f + n) / (f - n), 0);
            N[3, 2] = 1;
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

        public static Matrix operator *(double k, Matrix N)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    result[i, j] = k * N[i, j];
            return result;
        }

        public static Vector operator *(Vector v, Matrix N)
        {
            Vector result = new Vector();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                        result[i] = result[i] + v[j] * N[i, j];
            return result;
        }
    }
}
