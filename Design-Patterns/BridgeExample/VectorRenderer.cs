using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using vector rendering");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Drawing a square with side {side} using vector rendering");
        }
    }
}
