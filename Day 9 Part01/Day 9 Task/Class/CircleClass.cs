using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Task.Class
{
    internal class CircleClass
    {
        #region Properties
        public double Radius { get; set; }
        public string Color { get; set; }
        #endregion

        #region Constructor
        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            if (obj is CircleClass other)
            {
                return Radius == other.Radius && Color == other.Color;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        } 
        #endregion
    }
}
