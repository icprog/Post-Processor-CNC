using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Helper;



namespace CNC
{
    public partial class Form1 : Form
    {
        String path = "test.txt";
        /// <summary>
        /// Main combo box elements (Plates)
        /// </summary>
        List<String> plateList = new List<String>()
        {
            "80",
            "100",
            "60"
        };

        /// <summary>
        /// Discrete items
        /// </summary>
        List<double> discreteList = new List<double>()
        {
            0.2,
            0.5,
            1.0
        };

        /// <summary>
        /// Radius items
        /// </summary>
        List<double> radiusList = new List<double>()
        {
            0.2,
            0.4,
            0.8,
            1.2,
            1.5
        };

        public Form1()
        {
            InitializeComponent();
            //Set the collections with items and styles for comboBoxes
            comboBoxPlates.DataSource = plateList;
            comboBoxRadius.DataSource = radiusList;
            comboBoxDiscrete.DataSource = discreteList;
            comboBoxDiscrete.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlates.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRadius.DropDownStyle = ComboBoxStyle.DropDownList;
            //Set the initial values of combo boxes
            comboBoxPlates.SelectedIndex = 0;
            comboBoxRadius.SelectedIndex = radiusList.IndexOf(0.8);
            comboBoxDiscrete.SelectedIndex = discreteList.IndexOf(1);
        }

        private void buttonGenerateCP_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            ShortcutCNC CNC = new ShortcutCNC(writer);

            CNC.DefReal("GB");
            CNC.DefReal("ZZ");
            CNC.Append("GB", 0);
            CNC.MCode(3);
            CNC.MCode(8);
            CNC.Append("R11", InputHelper.GetCBDouble(comboBoxPlates)); 
            CNC.Append("R21", numericSideSize.Value);
            CNC.Append("R2", "R21/(SIN(R11))");
            CNC.Append("R3", InputHelper.GetCBDouble(comboBoxRadius));
            CNC.Append("r4", "r2*(cos (r11/2))*(sin (r11/2)-r34)");
            CNC.Append("r5", "r4/ (tan (r11/2))");
            CNC.Append("r7", InputHelper.GetCBDouble(comboBoxDiscrete));
            CNC.Append("r9", numericPasses.Value);
            CNC.Append("r91", numericAllowance.Value);

            CNC.Inline(true);
            CNC.GCode(90);
            CNC.GCode(1);
            CNC.Echo(numericX.Value);
            CNC.Echo(numericZ.Value);
            CNC.Echo(numericA.Value);
            CNC.FeedRate(9000);
            CNC.Inline(false);

            //CNC.While("gb<r9");
            
            //CNC.MCode(new object[] { 5, 9, 30 });                       
            //Close streams
            writer.Close();
            fs.Close();
            System.Diagnostics.Process.Start(path);
        }        
    }
}
