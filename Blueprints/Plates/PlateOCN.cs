using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNC;

namespace Post_Processor_CNC
{
    class OCN : Plate
    {
        /// <summary>
        /// OCN plate instance
        /// </summary>
        /// <param name="form">Reference on the form containing common plate parameters</param>
        public OCN(ref Form1 form)
            : base(ref form)
        {
            SideCount = 2;
        }
    }
}
