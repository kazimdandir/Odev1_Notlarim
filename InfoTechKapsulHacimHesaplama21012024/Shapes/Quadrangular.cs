using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTechKapsulHacimHesaplama21012024.Shapes
{
    internal class Quadrangular : Shape
    {
        int shortSide, longSide, height;

        public int ShortSide { get => shortSide; set => shortSide = Math.Abs(value); }
        public int LongSide { get => longSide; set => longSide = Math.Abs(value); }
        public int Height { get => height; set => height = Math.Abs(value); }

        public double CalculateVolume(int _shortSide, int _longSide, int _height)
        {
            TotalArea = _shortSide * _longSide * _height;
            return TotalArea;
        }
    }
}
