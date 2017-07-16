using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrints.Plates
{
    class Pentagon : Plate
    {
        /// <summary>
        /// OPN plate instance
        /// </summary>
        /// <param name="form">Reference on the form containing common plate parameters</param>
        public Pentagon()
        {
            _vertexAngle = 100;//make const
            _processAngle = 20;
            _sideCount = 5;
            _name = "Пятиугольник";
        }

        protected override double R31()
        {
            return _sideSize / 2 - _radius;
        }

        protected override double R32()
        {
            return _sideSize / 2 - _radius;
        }

        protected override double R51()
        {
            double buf1 = R31() - Math.Sqrt(R31() * R31() + R32() * R32());
            double buf2 = (_sideSize * Math.Sin(_radius)) / 4;
            return buf1-buf2;
        }
    }
}
