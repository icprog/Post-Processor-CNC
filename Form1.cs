using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Post_Processor_CNC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Main combo box elements (Plates)
        /// </summary>
        List<String> plateList = new List<String>()
        {
            "80°",
            "100°",
            "60°"
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
    }
}
