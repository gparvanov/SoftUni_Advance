using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private decimal length;
        protected decimal Length
        {
            get => this.length;
            private set
            {
                if(value <=0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                    
                }
                this.length = value;
            }
        }
        private decimal width;
        protected decimal Width
        {
            get => this.width;
            private set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        private decimal height;
        protected decimal Height
        {
            get => this.height;
            private set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public Box( decimal length, decimal width, decimal height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public decimal SurfaceArea()
        {
            decimal area = LateralSurfaceArea() + 2*Width*Height;            
            return area;
        }
        public decimal LateralSurfaceArea()
        {
            decimal area = 2 * Length * Height + 2 * Width * Height;
            return area;
        }
        public decimal Volume()
        {
            decimal area = Length * Width * Height;
            return area;
        }
    }
}