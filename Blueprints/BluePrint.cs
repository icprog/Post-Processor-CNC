using System;
using CNC;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrints
{
    public abstract class BluePrint : Object
    {
        protected bool _finishing;
        //Выхаживание
        protected String _name;
        protected abstract void MainCycleBody();

        protected CNCWriter CNC;

        protected void DoFinishing()
        {
            if (_finishing)
            {
                CNC.Comment("Выхаживание");
                CNC.Move("z", -0.005, 2000);
                MainCycleBody();
            }
        }

        public override string ToString()
        {
            return _name;
        }
        
    }
}
