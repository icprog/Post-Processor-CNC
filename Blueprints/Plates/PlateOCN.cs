using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNC;

namespace BluePrints
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
            _sideCount = 2;
            _name = "OCN (731)";
        }

        protected override double R31()
        {
            double buf1 = _sideSize / Math.Sin(_vertexAngle);
            double buf2 = Math.Cos(_vertexAngle / 2) * Math.Sin(_vertexAngle / 2);
            return buf1 * buf2 - _radius;
        }

        protected override double R32()
        {
            double buf1 = Math.Tan(_vertexAngle / 2);
            return R31() / buf1;
        }
    }
}
