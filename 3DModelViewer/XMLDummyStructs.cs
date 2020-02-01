using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _3DModelViewer
{
    [XmlType(TypeName = "xml")]
    public class DummyXML
    {
        public List<CameraXML> Cameras;

        public List<LightXML> Lights;

        public List<CuboidXML> Cuboids;

        public List<SphereXML> Spheres;

        public List<CylinderXML> Cylinders;

        public List<ConeXML> Cones;
    }

    [XmlType(TypeName = "Camera")]
    public class CameraXML
    {
        [XmlIgnore]
        public Point4 Pos;

        [XmlIgnore]
        public Point4 Tar;

        public int FOV;

        public float N;

        public float F;

        public CameraXML()
        {
        }

        public CameraXML(Camera camera)
        {
            Pos = camera.Position;
            Tar = camera.Target;
            FOV = camera.FOV;
            N = camera.N;
            F = camera.F;
        }

        public string Position
        {
            get
            {
                return $"{Pos.X};{Pos.Y};{Pos.Z};{Pos.W}";
            }
            set
            {
                string[] pos = value.Split(';');
                Pos = new Point4(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]), float.Parse(pos[3]));
            }
        }

        public string Target
        {
            get
            {
                return $"{Tar.X};{Tar.Y};{Tar.Z};{Tar.W}";
            }
            set
            {
                string[] tar = value.Split(';');
                Tar = new Point4(float.Parse(tar[0]), float.Parse(tar[1]), float.Parse(tar[2]), float.Parse(tar[3]));
            }
        }
    }

    [XmlType(TypeName = "Light")]
    public class LightXML
    {
        [XmlIgnore]
        public Point4 Pos;

        public float Intensity;

        public float Range;

        [XmlIgnore]
        public Color Col;

        public LightXML() { }

        public LightXML(Light light)
        {
            Pos = light.Position;
            Intensity = light.Intensity;
            Range = light.Range;
            Col = light.Color;
        }

        public string Position
        {
            get
            {
                return $"{Pos.X};{Pos.Y};{Pos.Z};{Pos.W}";
            }
            set
            {
                string[] pos = value.Split(';');
                Pos = new Point4(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]), float.Parse(pos[3]));
            }
        }

        public string Color
        {
            get => Col.Name;
            set
            {
                Col = System.Drawing.Color.FromName(value);
            }
        }
    }

    [XmlType(TypeName = "Cuboid")]
    public class CuboidXML
    {
        [XmlIgnore]
        public Point4 C { get; set; }

        [XmlIgnore]
        public Point4 S;

        [XmlIgnore]
        public Point4 R;

        [XmlIgnore]
        public Color Col;

        public float X;

        public float Y;

        public float Z;

        public bool Visibility { get; set; }

        public CuboidXML()
        {
        }

        public CuboidXML(Cuboid c)
        {
            C = c.Center;
            X = c.X;
            Y = c.Y;
            Z = c.Z;
            S = new Point4();
            S.V = c.Scale;
            R = new Point4();
            R.V = c.Rotation;
            Col = c.Color;
            Visibility = c.Visibility;
        }

        public string Color
        {
            get => Col.Name;
            set
            {
                Col = System.Drawing.Color.FromName(value);
            }
        }

        public string Center
        {
            get
            {
                return $"{C.X};{C.Y};{C.Z};{C.W}";
            }
            set
            {
                string[] c = value.Split(';');
                C = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Scale
        {
            get
            {
                return $"{S.X};{S.Y};{S.Z};{S.W}";
            }
            set
            {
                string[] c = value.Split(';');
                S = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Rotation
        {
            get
            {
                return $"{R.X};{R.Y};{R.Z};{R.W}";
            }
            set
            {
                string[] c = value.Split(';');
                R = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }
    }

    [XmlType(TypeName = "Sphere")]
    public class SphereXML
    {
        [XmlIgnore]
        public Point4 C { get; set; }

        [XmlIgnore]
        public Point4 S;

        [XmlIgnore]
        public Point4 R;

        [XmlIgnore]
        public Color Col;

        public bool Visibility { get; set; }

        public float Radius { get; set; }

        public int Lat { get; set; }

        public int Lon { get; set; }

        public SphereXML()
        {
        }

        public SphereXML(Sphere c)
        {
            C = c.Center;
            S = new Point4();
            S.V = c.Scale;
            R = new Point4();
            R.V = c.Rotation;
            Col = c.Color;
            Visibility = c.Visibility;
            Radius = c.Radius;
            Lat = c.Lat;
            Lon = c.Lon;
        }

        public string Color
        {
            get => Col.Name;
            set
            {
                Col = System.Drawing.Color.FromName(value);
            }
        }

        public string Center
        {
            get
            {
                return $"{C.X};{C.Y};{C.Z};{C.W}";
            }
            set
            {
                string[] c = value.Split(';');
                C = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Scale
        {
            get
            {
                return $"{S.X};{S.Y};{S.Z};{S.W}";
            }
            set
            {
                string[] c = value.Split(';');
                S = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Rotation
        {
            get
            {
                return $"{R.X};{R.Y};{R.Z};{R.W}";
            }
            set
            {
                string[] c = value.Split(';');
                R = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }
    }

    [XmlType(TypeName = "Cylinder")]
    public class CylinderXML
    {
        [XmlIgnore]
        public Point4 C { get; set; }

        [XmlIgnore]
        public Point4 S;

        [XmlIgnore]
        public Point4 R;

        [XmlIgnore]
        public Color Col;

        public bool Visibility { get; set; }

        public float Radius { get; set; }

        public float Height { get; set; }

        public int Division { get; set; }

        public CylinderXML()
        {
        }

        public CylinderXML(Cylinder c)
        {
            C = c.Center;
            S = new Point4();
            S.V = c.Scale;
            R = new Point4();
            R.V = c.Rotation;
            Col = c.Color;
            Visibility = c.Visibility;
            Radius = c.Radius;
            Height = c.Height;
            Division = c.Division;
        }

        public string Color
        {
            get => Col.Name;
            set
            {
                Col = System.Drawing.Color.FromName(value);
            }
        }

        public string Center
        {
            get
            {
                return $"{C.X};{C.Y};{C.Z};{C.W}";
            }
            set
            {
                string[] c = value.Split(';');
                C = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Scale
        {
            get
            {
                return $"{S.X};{S.Y};{S.Z};{S.W}";
            }
            set
            {
                string[] c = value.Split(';');
                S = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Rotation
        {
            get
            {
                return $"{R.X};{R.Y};{R.Z};{R.W}";
            }
            set
            {
                string[] c = value.Split(';');
                R = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }
    }

    [XmlType(TypeName = "Cone")]
    public class ConeXML
    {
        [XmlIgnore]
        public Point4 C { get; set; }

        [XmlIgnore]
        public Point4 S;

        [XmlIgnore]
        public Point4 R;

        [XmlIgnore]
        public Color Col;

        public bool Visibility { get; set; }

        public float Radius { get; set; }

        public float Height { get; set; }

        public int Division { get; set; }

        public ConeXML()
        {
        }

        public ConeXML(Cone c)
        {
            C = c.Center;
            S = new Point4();
            S.V = c.Scale;
            R = new Point4();
            R.V = c.Rotation;
            Col = c.Color;
            Visibility = c.Visibility;
            Radius = c.Radius;
            Height = c.Height;
            Division = c.Division;
        }

        public string Color
        {
            get => Col.Name;
            set
            {
                Col = System.Drawing.Color.FromName(value);
            }
        }

        public string Center
        {
            get
            {
                return $"{C.X};{C.Y};{C.Z};{C.W}";
            }
            set
            {
                string[] c = value.Split(';');
                C = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Scale
        {
            get
            {
                return $"{S.X};{S.Y};{S.Z};{S.W}";
            }
            set
            {
                string[] c = value.Split(';');
                S = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }

        public string Rotation
        {
            get
            {
                return $"{R.X};{R.Y};{R.Z};{R.W}";
            }
            set
            {
                string[] c = value.Split(';');
                R = new Point4(float.Parse(c[0]), float.Parse(c[1]), float.Parse(c[2]), float.Parse(c[3]));
            }
        }
    }
}
