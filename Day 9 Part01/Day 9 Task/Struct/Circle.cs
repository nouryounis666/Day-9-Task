using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Task.Struct
{
    internal struct Circle
    {
        #region Properties
        public double Radius { get; set; }
        public string Color { get; set; }
        #endregion

        #region Constructor
        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            if (obj is Circle other)
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

        #region Operators
        public static bool operator ==(Circle c1, Circle c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Circle c1, Circle c2)
        {
            return !c1.Equals(c2);
        } 
        #endregion
    }
}
