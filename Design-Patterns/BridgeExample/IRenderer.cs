using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    public interface IRenderer
    {
        void RenderCircle(float radius);
        void RenderSquare(float side);
    }
}
