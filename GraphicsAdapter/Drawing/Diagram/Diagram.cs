using GraphicsAdapter.Drawing.Graphics;
using GraphicsAdapter.Drawing.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Diagram
{
    public class Diagram : Shape
    {
        public List<Block> Blocks { get; set; }
        public DiagramFactory Factory { get; }
        public Diagram(DiagramFactory factory)
        {
            Factory = factory;
            Blocks = new List<Block>();
        }

        public override void Draw(CommonGraphic graphic)
        {
            for (int loop = 0; loop < Blocks.Count; loop++)
            {
                Blocks[loop].Draw(graphic);
            }
        }

        protected override void Draw(CommonGraphic graphic, Vector2 from, Vector2 to)
        {
            throw new NotImplementedException();
        }
    }
}
