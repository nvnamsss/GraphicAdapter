using GraphicsAdapter.Drawing.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing.Diagram
{
    public abstract class DiagramFactory
    {
        public abstract StartBlock CreateStartBlock(ShapeInfo info);
        public abstract InputBlock CreateInputBlock(ShapeInfo info);
    }
}
