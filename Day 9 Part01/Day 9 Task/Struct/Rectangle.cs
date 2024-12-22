using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Task.Struct
{
    internal struct Rectangle
    {
        #region Properties
        public int Length { get; set; }
        public int Width { get; set; }
        #endregion

        #region Constructor
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        } 
        #endregion
    }
}
