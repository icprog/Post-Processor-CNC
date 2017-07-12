using System;
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

        public override string ToString()
        {
            return _name;
        }
        
    }
}
