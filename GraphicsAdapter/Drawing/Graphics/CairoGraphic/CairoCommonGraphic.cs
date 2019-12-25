using Cairo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Graphics.CairoGraphic
{
    public class CairoCommonGraphic : CommonGraphic
    {
        protected Context Context { get; set; }
        protected Surface Surface { get; }
        public CairoCommonGraphic()
        {

            Surface = new ImageSurface(Format.RGB24, 120, 120);
            Context = new Context(Surface);
            
        }

        public override void DrawLine(Vector2 from, Vector2 to)
        {
            Context.MoveTo(from.x, from.y);
            Context.LineTo(to.x, to.y);
            Context.Stroke();
        }

        public override void DrawRectangle(Vector2 from, Vector2 to)
        {
            double width = to.x - from.x;
            double height = to.y - from.y;

            Context.Rectangle(from.x, from.y, width, height);
            Context.Stroke();
        }

        public override void DrawEllipse(Vector2 from, Vector2 to)
        {
            double width = to.x - from.x;
            double height = to.y - from.y;
            double radius = 0;
            Context.Scale(width, height);
            Context.Arc(from.x, from.y, radius, 0, 0);
            Context.Stroke();
        }

        public override object Clone()
        {
            throw new NotImplementedException();
        }

        protected override void PropertyChanged()
        {
            throw new NotImplementedException();
        }
    }
}
