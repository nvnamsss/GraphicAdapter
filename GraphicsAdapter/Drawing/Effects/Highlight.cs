using GraphicsAdapter.Drawing.Graphics;
using GraphicsAdapter.Drawing.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Effects
{
    public class Highlight : Effect
    {
        public Highlight(Shape shape) : base(shape)
        {

        }

        protected override void AddEffect(CommonGraphic graphic)
        {
            CommonGraphic g = graphic.Clone() as CommonGraphic;
            g.Color = System.Drawing.Color.FromArgb((int)(g.Color.A * 0.6), g.Color.R, g.Color.G, g.Color.B);
            g.Thick = (int)(g.Thick * 40);
            g.Background = System.Drawing.Color.Black;
            Shape.Draw(g);
        }

        public override void Draw(CommonGraphic graphic)
        {
            AddEffect(graphic);
            Shape.Draw(graphic);
        }

        protected override void Draw(CommonGraphic graphic, Vector2 from, Vector2 to)
        {
            throw new NotImplementedException();
        }
    }
}
