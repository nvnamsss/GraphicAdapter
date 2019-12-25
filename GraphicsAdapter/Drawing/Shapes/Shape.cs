using GraphicsAdapter.Drawing.Effects;
using GraphicsAdapter.Drawing.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Shapes
{
    public abstract class Shape
    {
        public virtual Vector2 From { get; set; }
        public virtual Vector2 To { get; set; }
        public abstract void Draw(CommonGraphic graphic);
        protected abstract void Draw(CommonGraphic graphic, Vector2 from, Vector2 to);
    }
}
