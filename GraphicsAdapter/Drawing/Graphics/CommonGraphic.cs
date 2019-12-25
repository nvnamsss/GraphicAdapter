using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Graphics
{
    public abstract class CommonGraphic : ICloneable
    {
        public int Thick
        {
            get
            {
                return _thick;
            }
            set
            {
                _thick = value;
                PropertyChanged();
            }
        }
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                PropertyChanged();
            }
        }
        public Color Background { get; set; }
        protected int _thick;
        protected Color _color;
        public abstract void DrawLine(Vector2 from, Vector2 to);
        public abstract void DrawRectangle(Vector2 from, Vector2 to);
        public abstract void DrawEllipse(Vector2 from, Vector2 to);
        
        public abstract object Clone();
        protected abstract void PropertyChanged();
    }
}
