using GraphicsAdapter.Drawing.Graphics;
using GraphicsAdapter.Drawing.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Effects
{
    public abstract class Effect : Shape
    {
        public override Vector2 From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;
                Shape.From = _from;
            }
        }

        public override Vector2 To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
                Shape.To = _to;
            }
        }

        protected Vector2 _from;
        protected Vector2 _to;
        public Shape Shape { get; set; }
        protected abstract void AddEffect(CommonGraphic graphic);

        public Effect(Shape shape)
        {
            Shape = shape;
            this._from = Shape.From;
            this._to = Shape.To;
        }

    }
}
