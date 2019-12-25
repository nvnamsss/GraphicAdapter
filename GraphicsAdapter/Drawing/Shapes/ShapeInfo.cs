using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Shapes
{
    public class ShapeInfo
    {
        
        public double Width { get; set; }
        public double Height { get; set; }
        public Vector2 Location { get; set; }
        public Vector2 Rotation { get; set; }

        public ShapeInfo()
        {
            Width = 0;
            Height = 0;
            Location = Vector2.zero;
            Rotation = Vector2.zero;
        }
    }

}
