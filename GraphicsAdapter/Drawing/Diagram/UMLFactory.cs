using GraphicsAdapter.Drawing.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Diagram
{
    public class UMLFactory : DiagramFactory
    {
        public override StartBlock CreateStartBlock(ShapeInfo info)
        {
            return new UMLStartBlock(info.Location, info.Location + new Vector2(25, 25));
        }

        public override InputBlock CreateInputBlock(ShapeInfo info)
        {
            return new UMLInputBlock(info.Location, info.Location + new Vector2(25, 25));
        }

    }
}
