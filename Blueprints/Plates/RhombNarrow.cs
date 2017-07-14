using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluePrints.Plates;

namespace BluePrints.Plates
{
    class RhombNarrow : Plate
    {
        /// <summary>
        /// OPN plate instance
        /// </summary>
        /// <param name="form">Reference on the form containing common plate parameters</param>
        public RhombNarrow()
        {
            _vertexAngle = 60;//make const
            _processAngle = 60;
            _sideCount = 2;
            _name = "Узкий ромб";
        }

        protected override double R31()
        {
            return (_sideSize / 2) * Math.Tan(30) - _radius;
        }

        protected override double R32()
        {
            return R31() * Math.Tan(60);
        }

        protected override string R51()
        {
            return "R31-(SQRT(R31*R31+R32*R32))*(SIN(R41+R1/2))";
        }
    }
}
