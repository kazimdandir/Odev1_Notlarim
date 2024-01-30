using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTechKapsulHacimHesaplama21012024.Shapes
{
    internal class Cube : Shape
    {
        int side;

        public int Side { get => side; set => side = Math.Abs(value); }

        public double CalculateVolume(int _side)
        {
            TotalArea = Math.Pow(_side, 3);
            return TotalArea;
        }
    }
}
