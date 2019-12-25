using GraphicsAdapter.Drawing.Graphics;
using GraphicsAdapter.Drawing.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Effects
{
    public class Border : Effect
    {
        public Border(Shapes.Shape shape) : base(shape)
        {

        }

        protected override void AddEffect(CommonGraphic graphic)
        {
            CommonGraphic g = graphic.Clone() as CommonGraphic;
            g.Color = System.Drawing.Color.CornflowerBlue;
            g.Background = System.Drawing.Color.CornflowerBlue;
            Vector2 left_mid = new Vector2(From.x, (From.y + To.y) / 2);
            Vector2 righ_mid = new Vector2(To.x, (From.y + To.y) / 2);
            Vector2 top_mid = new Vector2((From.x + To.x) / 2, From.y);
            Vector2 bot_mid = new Vector2((From.x + To.x) / 2, To.y);
            Vector2 left_top = new Vector2(From.x, From.y);
            Vector2 right_top = new Vector2(To.x, From.y);
            Vector2 left_bot = new Vector2(From.x, To.y);
            Vector2 right_bot = new Vector2(To.x, To.y);

            g.DrawRectangle(left_mid, left_mid + new Vector2(5, 5));
            g.DrawRectangle(righ_mid, righ_mid + new Vector2(5, 5));
            g.DrawRectangle(top_mid, top_mid + new Vector2(5, 5));
            g.DrawRectangle(bot_mid, bot_mid + new Vector2(5, 5));
            
            g.DrawEllipse(left_top, left_top + new Vector2(5, 5));
            g.DrawEllipse(right_top, right_top + new Vector2(5, 5));
            g.DrawEllipse(left_bot, left_bot + new Vector2(5, 5));
            g.DrawEllipse(right_bot, right_bot + new Vector2(5, 5));
        }

        public override void Draw(CommonGraphic graphic)
        {
            Shape.Draw(graphic);
            AddEffect(graphic);
        }

        protected override void Draw(CommonGraphic graphic, Vector2 from, Vector2 to)
        {
            throw new NotImplementedException();
        }
    }
}
