using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DModelViewer
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Render.Clear(bitmap);
            Canvas.Image = bitmap;
        }
    }
}
