using GraphicsAdapter.Drawing.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Shapes
{
    public class Line : Shape
    {
        public Line(Vector2 from, Vector2 to)
        {
            From = from;
            To = to;
        }

        public override void Draw(CommonGraphic graphic)
        {
            Draw(graphic, From, To);
        }

        protected override void Draw(CommonGraphic graphic, Vector2 from, Vector2 to)
        {
            graphic.DrawLine(from, to);

        }
    }
}
