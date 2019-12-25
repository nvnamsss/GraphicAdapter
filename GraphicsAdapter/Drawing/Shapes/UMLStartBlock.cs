using GraphicsAdapter.Drawing.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Shapes
{
    public class UMLStartBlock : StartBlock
    {
        public UMLStartBlock(Vector2 from, Vector2 to)
        {
            From = from;
            To = to;
        }
        public override void Draw(CommonGraphic graphic)
        {
            CommonGraphic g = graphic.Clone() as CommonGraphic;
            g.Color = System.Drawing.Color.Black;
            g.Background = System.Drawing.Color.Black;
            graphic.DrawEllipse(From, To);
        }
    }
}
