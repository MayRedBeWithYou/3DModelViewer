using System.Numerics;


namespace _3DModelViewer
{
    public class Camera
    {
        private Point4 defaultPosition = new Point4(7, 8, 9);

        public Point4 Position { get; set; }

        public string DisplayName => $"Camera (X:{Position.X.ToString("f2")}, Y:{Position.Y.ToString("f2")}, Z:{Position.Z.ToString("f2")})";

        public Point4 Target = new Point4();

        public int FOV = 60;

        public float N = 0.1f;

        public float F = 100f;

        public Vector4 Normal
        {
            get
            {
                return Vector4.Normalize(Target.V - Position.V);
            }
        }

        public Vector4 Tangent
        {
            get
            {
                return Vector4.Normalize(Vector.Cross(Normal, Vector4.UnitY));
            }
        }

        public Vector4 Binormal
        {
            get
            {
                return Vector4.Normalize(Vector.Cross(Normal, Tangent));
            }
        }

        public Camera()
        {
            Position = new Point4(defaultPosition);
        }

        public Camera(Point4 pos)
        {
            Position = pos;
        }
        public Camera(Point4 pos, Point4 target)
        {
            Position = pos;
            Target = target;
        }

        public Camera(CameraXML c)
        {
            Position = c.Pos;
            Target = c.Tar;
            FOV = c.FOV;
            N = c.N;
            F = c.F;
        }

        public void Reset()
        {
            Position = new Point4(defaultPosition);
            Target = new Point4();
            FOV = 60;
            N = 0.1f;
            F = 100f;
        }
    }
}
