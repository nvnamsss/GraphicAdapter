using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Graphics.GDIs
{
    public class GDIJpegGraphic : GDICommonGraphic
    {
        public Bitmap Bitmap { get; set; }

        public GDIJpegGraphic(System.Drawing.Graphics g, System.Drawing.Color color, int thick) : 
            base(g, color, thick)
        {

        }

        public void Export(string filename)
        {
            Bitmap.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
