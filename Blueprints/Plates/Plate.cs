using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CNC;

namespace BluePrints.Plates
{
    public abstract class Plate : BluePrint
    {
        //Input parameters
        protected double _sideSize; //R2
        protected double _radius; //R3
        protected double _discreteness; //R4
        protected double _passes; //R5
        protected double _overMeasure; //R6
        protected double _plateExit; //R7
        protected double _initialX;
        protected double _initialZ;
        protected double _initialA;


        //Plate-defined parameters
        protected abstract double R31();
        protected abstract double R32();
        protected abstract string R51();

        protected double _vertexAngle; //R1
        public double VertexAngle 
            {
                get
                {
                    return _vertexAngle;
                }
            }
        protected double _sideCount;
        protected double _processAngle;
               

        public void GetParametersFromForm(PlateForm p)
        {
            _sideSize = p.SideSize;
            _radius = p.Radius;
            _discreteness = p.Discreteness;
            _passes = p.Passes;
            _overMeasure = p.OverMeasure;
            _plateExit = p.PlateExit;
            _initialX = p.InitialX;
            _initialZ = p.InitialZ;
            _initialA = p.InitialA;
            _finishing = p.Finishing;
        }

        public void WriteMetaCode(String path)
        {
            CNC = new CNCWriter(path);
            WritePreset();
            CNC.GCode(90);
            CNC.Move(_initialX, _initialZ, _initialA, 2000);
            CNC.GCode(91);
            CNC.While("GB<" + _passes);
            CNC.Move("Z", _overMeasure, 2000);
            MainCycleBody();
            CNC.Increment("GB");
            CNC.EndWhile();
            DoFinishing();
            CNC.MCode(5);
            CNC.MCode(9);
            CNC.MCode(30);
            CNC.Close();
        }

        public void WritePreset()
        {
            CNC.DefReal("GB");
            CNC.DefReal("ZZ");
            CNC.Append("GB", 0);
            CNC.MCode(3);
            CNC.MCode(8);
            CNC.GCode(64);
            CNC.Append("R1", _vertexAngle);
            CNC.Append("R2", _sideSize);
            CNC.Append("R3", _radius);
            CNC.Append("R31", R31());
            CNC.Append("R32", R32());
            CNC.Append("R4", _discreteness);
            CNC.Append("R5", _passes);
            CNC.Append("R6", _overMeasure);
            CNC.Append("R7", _plateExit);
        }

        protected override void MainCycleBody()
        {
            CNC.Append("ZZ", 0);
            SideCycle();
        }

        public void SideCycle()
        {
            CNC.While("ZZ<" + _sideCount);
            CNC.Move("X", -_plateExit, 1000);
            CNC.Append("R41", 1);
            CNC.Append("R42", 0);
            RotationCycle();
            CNC.Move("x", _plateExit, 1000);
            CNC.RapidMove(_processAngle);
            CNC.Increment("ZZ");
            CNC.EndWhile();
        }

        public void RotationCycle()
        {
            CNC.While("R41<="+(180-_vertexAngle)); //100 depends on plate type
            CNC.Append("R51", R51());
            CNC.Move("Z", "-(R51-R42)", "A", _discreteness.ToString(), 100);
            CNC.Append("R42", "R51");
            CNC.Append("R1", "R1+" + _discreteness);
            CNC.EndWhile();
        }
    }
}
