using GraphicsAdapter.Drawing.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Diagram
{
    public class DfdFactory : DiagramFactory
    {
        public override StartBlock CreateStartBlock(ShapeInfo info)
        {
            return new DfdStartBlock();
        }

        public override InputBlock CreateInputBlock(ShapeInfo info)
        {
            return new DfdInputBlock();
        }
    }
}
