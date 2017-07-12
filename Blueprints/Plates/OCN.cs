using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNC;

namespace BluePrints.Plates
{
    class OCN : Plate
    {
        /// <summary>
        /// OCN plate instance
        /// </summary>
        /// <param name="form">Reference on the form containing common plate parameters</param>
        public OCN()
        {
            _vertexAngle = 80;//make const
            _processAngle = 80;
            _sideCount = 2;
            _name = "OCN (731)";
        }

        protected override double R31()
        {
            return _sideSize/2 - _radius;
        }

        protected override double R32()
        {
            double buf1 = Math.Tan(_vertexAngle / 2);
            return R31() / buf1;
        }

        protected override string R51()
        {
            return "R31-(SQRT(R31*R31+R32*R32))*(SIN(R41+R1/2))";
        }
    }
}
