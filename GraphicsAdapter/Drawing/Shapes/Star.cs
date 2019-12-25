using GraphicsAdapter.Drawing.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Shapes
{
    public class Star : Shape
    {
        public Star(Vector2 from, Vector2 to)
        {
            From = from;
            To = to;
        }
        public override void Draw(CommonGraphic graphic)
        {
            float alpha = (float)(2 * Math.PI) / 10;
            float radius = 12;
            Vector2 from = new Vector2((From.x + To.x) / 2, From.y);

            for (var loop = 0; loop < 10; loop++)
            {
                alpha = (float)(2 * Math.PI) / 10;
                var r = radius * (loop % 2 + 1) / 2;
                var omega = alpha * loop;
                Vector2 to = new Vector2((float)(r * Math.Sin(omega)) + from.x, (float)(r * Math.Cos(omega)) + from.y);
                graphic.DrawLine(from, to);
            }
        }

        protected override void Draw(CommonGraphic graphic, Vector2 from, Vector2 to)
        {

        }
    }
}
