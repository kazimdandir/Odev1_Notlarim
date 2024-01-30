using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTechKapsulHacimHesaplama21012024.Shapes
{
    internal class Sphere : Shape
    {
        int radius;

        public int Radius { get => radius; set => radius = Math.Abs(value); }

        public double CalculateVolume(int _radius)
        {
            TotalArea = Math.PI * Math.Pow(_radius, 3) * (4 / 3);
            return TotalArea;
        }
    }
}
