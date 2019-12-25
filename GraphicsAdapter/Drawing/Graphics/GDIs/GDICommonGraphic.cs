using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Graphics.GDIs
{
    public class GDICommonGraphic : CommonGraphic
    {
        public System.Drawing.Graphics Graphics { get; set; }
        protected System.Drawing.Pen Pen { get; set; }

        public GDICommonGraphic(System.Drawing.Graphics g, System.Drawing.Color color, int thick) : 
            this(g, color, System.Drawing.Color.Transparent, thick)
        {
        }

        public GDICommonGraphic(System.Drawing.Graphics g, System.Drawing.Color color, System.Drawing.Color background, int thick)
        {
            Graphics = g;
            _color = color;
            _thick = thick;
            Background = background;
            Pen = new System.Drawing.Pen(_color, _thick);
        }

        public override object Clone()
        {
            GDICommonGraphic g = new GDICommonGraphic(Graphics, Color, Thick);
            g.Background = this.Background;
            return g;
        }

        public override void DrawEllipse(Vector2 from, Vector2 to)
        {
            float width = to.x - from.x;
            float height = to.y - from.y;
            Graphics.DrawEllipse(Pen, from.x, from.y, width, height);
            Graphics.FillEllipse(new System.Drawing.SolidBrush(Background), from.x, from.y, width, height);
        }

        public override void DrawLine(Vector2 from, Vector2 to)
        {
            Graphics.DrawLine(Pen, from.x, from.y, to.x, to.y);
        }

        public override void DrawRectangle(Vector2 from, Vector2 to)
        {
            float width = to.x - from.x;
            float height = to.y - from.y;
            Graphics.DrawRectangle(Pen, from.x, from.y, width, height);
            Graphics.FillRectangle(new System.Drawing.SolidBrush(Background), from.x, from.y, width, height);
        }

        protected override void PropertyChanged()
        {
            Pen = new System.Drawing.Pen(_color, _thick);
        }
    }
}
