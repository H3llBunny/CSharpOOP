using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        private const string ERROR_MESSAGE = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(String.Format(ERROR_MESSAGE, nameof(this.Length)));
                }
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ERROR_MESSAGE, nameof(this.Width)));
                }
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ERROR_MESSAGE, nameof(this.Height)));
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * this.Length * this.Width
                + 2 * this.Length * this.Height
                + 2 * this.Width * this.Height;

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.Length * this.Height
                + 2 * this.Width * this.Height;

            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }
    }
}
