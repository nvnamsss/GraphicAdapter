using GraphicsAdapter.Drawing.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Effects
{
    public class Shadow : Effect
    {
        public Shadow(Shapes.Shape shape) : base(shape)
        {
            
        }


        protected override void AddEffect(CommonGraphic graphic)
        {
            CommonGraphic g = graphic.Clone() as CommonGraphic;

            Shape.From += new Vector2(5, 5);
            Shape.To += new Vector2(5, 5);
            g.Color = System.Drawing.Color.Gray;
            g.Background = System.Drawing.Color.Gray;
            Shape.Draw(g);
            Shape.From -= new Vector2(5, 5);
            Shape.To -= new Vector2(5, 5);
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
