﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNC;

namespace BluePrints.Plates
{
    class RhombWide : Plate
    {
        /// <summary>
        /// OCN plate instance
        /// </summary>
        /// <param name="form">Reference on the form containing common plate parameters</param>
        public RhombWide()
        {
            _vertexAngle = 80;//make const
            _processAngle = 80;
            _sideCount = 2;
            _name = "Широкий ромб";
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

        protected override double R51()
        {
            double buf = Math.Sqrt(R31() * R31() + R32() * R32());
            return R31() - buf;
        }
    }
}
