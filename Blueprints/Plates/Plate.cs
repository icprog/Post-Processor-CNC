using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CNC;

namespace BluePrints
{
    public abstract class Plate : BluePrint
    {
        //Input parameters
        protected decimal SideSize; //R2
        protected decimal Radius; //R3
        protected decimal Discreteness; //R4
        protected decimal Passes; //R5
        protected decimal OverMeasure; //R6
        protected decimal PlateExit; //R7

        //Plate-defined parameters
        protected decimal VertexAngle { get; set; } //R1
        protected decimal SideCount { get; set; } //R8

        public Plate(PlateForm form)
        {
            GetParametersFromForm(form);
        }

        public void GetParametersFromForm(PlateForm p)
        {
            SideSize = p.SideSize;
            Radius = p.Radius;
            Discreteness = p.Discreteness;
            Passes = p.Passes;
            OverMeasure = p.OverMeasure;
            PlateExit = p.PlateExit;
        }

        public void WriteMetaCode(String path)
        {
            CNCWriter CNC = new CNCWriter(path);
            WritePreset(CNC);
        }

        public void WritePreset(CNCWriter CNC)
        {
            CNC.DefReal("GB");
            CNC.DefReal("ZZ");
            CNC.Append("GB", 0);
            CNC.MCode(3);
            CNC.MCode(8);
        }

        public abstract void SpecifyPlateConstants();
    }
}
