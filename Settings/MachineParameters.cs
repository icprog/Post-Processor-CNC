using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Processor_CNC
{
    class MachineParameters
    {
        public bool isAxisReversed;        
        public MachineParameters(bool reversed)
        {
            isAxisReversed = reversed;
        }        
    }
}
