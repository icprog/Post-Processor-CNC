using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNC;

namespace Post_Processor_CNC
{
    public abstract class Plate : BluePrint
    {
        //Input parameters
        protected decimal VertexAngle; //R1
        protected decimal SideSize; //R2
        protected decimal Radius; //R3
        protected decimal Discreteness; //R4
        protected decimal Passes; //R5
        protected decimal OverMeasure; //R6
        protected decimal PlateExit; //R7

        //Plate-defined parameters
        protected decimal SideCount; //R8

        public Plate(ref CNC.Form1 inputForm)
        {
            
        }
    }
}
