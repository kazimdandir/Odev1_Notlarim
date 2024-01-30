using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTechKapsulHacimHesaplama21012024.Shapes
{
    internal class SquarePyramid : Shape
    {
        int side, height;

        public int Side { get => side; set => side = Math.Abs(value); }
        public int Height { get => height; set => height = Math.Abs(value); }

        public double CalculateVolume(int _side, int _height)
        {
            TotalArea = Math.Pow(_side, 2) * _height * (1 / 3);
            return TotalArea;
        }
    }
}
