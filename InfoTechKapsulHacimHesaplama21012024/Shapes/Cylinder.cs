using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTechKapsulHacimHesaplama21012024.Shapes
{
    internal class Cylinder : Shape
    {
        int radius, height;

        public int Radius { get => radius; set => radius = Math.Abs(value); }
        public int Height { get => height; set => height = Math.Abs(value); }

        public double CalculateVolume(int _radius, int _height)
        {
            TotalArea = Math.Round(Math.PI, 2) * Math.Pow(_radius, 2) * _height;
            TotalArea = Math.Round(TotalArea, 2);
            return TotalArea;
        }
    }
}
