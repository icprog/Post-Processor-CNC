using System;
using System.Windows.Forms;

namespace Helper
{
    public static class InputHelper : Object
    {
        public static double GetCBDouble(ComboBox cb)
        {    
            return double.Parse(cb.SelectedItem.ToString());
        }
    }
}
