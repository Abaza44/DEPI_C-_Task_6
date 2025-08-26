using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    internal struct point
    {
        public int First_Coordinate_X;
        public int Second_Coordinate_Y;
        //Manual Constructor
        public point(int _first_Coordinate_X, int _Second_Coordinate_Y)
        {
            First_Coordinate_X = _first_Coordinate_X;
            Second_Coordinate_Y = _Second_Coordinate_Y;
        }

        //Default After .NET 6
        /*
        public point(int _first_Coordinate_X,int _first_Coordinate_Y)
        {
            First_Coordinate_X = default(int);
            First_Coordinate_Y = default(int);
        }
        */
        public point(int _X)
        {
            First_Coordinate_X = _X;
            Second_Coordinate_Y = 0;
        }
        
        public override string ToString()
        {
            return $"X {First_Coordinate_X}, Y {Second_Coordinate_Y}";
        }


    }
}
