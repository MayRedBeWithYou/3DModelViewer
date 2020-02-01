using System.Drawing;


namespace _3DModelViewer
{
    public class Light
    {
        public string DisplayName => $"Light (X:{Position.X.ToString("f2")}, Y:{Position.Y.ToString("f2")}, Z:{Position.Z.ToString("f2")})";

        public Point4 Position { get; set; } = new Point4(0, 7, 7);

        public Color Color { get; set; } = Color.White;

        public float Intensity { get; set; } = 2f;

        public float Range { get; set; } = 5f;

        public Light() { }
        public Light(LightXML l)
        {
            Position = l.Pos;
            Color = l.Col;
            Intensity = l.Intensity;
            Range = l.Range;
        }
    }
}
