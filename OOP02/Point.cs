using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal struct Point
    {
        #region properties
        public double X { get; set; }
        public double Y { get; set; }
        #endregion
        #region Constructors
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public static double CalcDictince(Point P01, Point P02)
        {
            return Math.Sqrt(Math.Pow(P01.X - P02.X, 2) + Math.Pow(P01.Y - P02.Y, 2));
            
        }
        #endregion
    }
}
