
using System;

namespace ClassBoxData
{
    public class Box
    {
        private double height;
        private double length;
        private double width;

        public Box(double length, double width, double height)
        {
            Height = height;
            Length = length;
            Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                DataValidation(value, "Height");
                this.height = value;
            }
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                DataValidation(value, "Length");
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                DataValidation(value, "Width");
                this.width = value;
            }
        }

        public double GetSurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double GetVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        #region private
        private void DataValidation(double value, string message)
        {
            if (value <= 0)
            {
                throw new ArgumentException(message + " cannot be zero or negative.");
            }
        }

        #endregion

    }
}
