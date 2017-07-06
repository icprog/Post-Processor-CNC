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
        public OCN(PlateForm form)
            : base(form)
        {
            VertexAngle = 80m;
            SideCount = 2;
            Name = "OCN (731)";
        }
    }
}
