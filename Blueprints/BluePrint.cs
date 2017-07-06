using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrints
{
    public abstract class BluePrint : Object
    {
        protected bool Finishing { get; set; } //Выхаживание
        protected String Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
        
    }
}
