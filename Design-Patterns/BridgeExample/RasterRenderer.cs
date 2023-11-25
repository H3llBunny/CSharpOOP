using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeExample
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} using raster rendering");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Drawing a square with side {side} using raster rendering");
        }
    }
}
