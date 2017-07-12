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
using BluePrints.Plates;



namespace CNC
{
    public partial class PlateForm : Form
    {
        //Public Parameters
        public double SideSize
        {
            get
            {
                return Convert.ToDouble(numSideSize.Value);
            }
        }
        public double Radius
        {
            get
            {
                return Convert.ToDouble(cbRadius.SelectedItem);
            }
        }
        public double OverMeasure
        {
            get
            {
                return Convert.ToDouble(numAllowance.Value);
            }
        }
        public double PlateExit
        {
            get
            {
                return Convert.ToDouble(numPlateExit.Value);
            }
        }
        public double Passes
        {
            get
            {
                return Convert.ToDouble(numPasses.Value);
            }
        }
        public double Discreteness
        {
            get
            {
                return Convert.ToDouble(cbDiscrete.SelectedItem);
            }
        }
        public bool Finishing
        {
            get
            {
                return checkFinishing.Checked;
            }
        }
        public double InitialX
        {
            get
            {
                return (double)numericX.Value;
            }
        }
        public double InitialZ
        {
            get
            {
                return (double)numericZ.Value;
            }
        }
        public double InitialA
        {
            get
            {
                return (double)numericA.Value;
            }
        }

        //Private Parameters
        private int PlateIndex
        {
            get
            {
                return comboBoxPlates.SelectedIndex;
            }
        }
        String path = "test.txt"; //принесет илья

        //Lists
        /// <summary>
        /// List of plate objects 
        /// </summary>
        private List<Plate> plateList = new List<Plate>();       
        /// <summary>
        /// Discrete combobox items
        /// </summary>
        private List<double> discreteList = new List<double>()
        {
            0.2,
            0.5,
            1.0
        };
        /// <summary>
        /// Radius combobox items
        /// </summary>
        private List<double> radiusList = new List<double>()
        {
            0.2,
            0.4,
            0.8,
            1.2,
            1.5
        };

        public PlateForm()
        {
            InitializeComponent();
            //Set the collections with items and styles for comboBoxes
            cbRadius.DataSource = radiusList;
            cbDiscrete.DataSource = discreteList;
            cbDiscrete.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlates.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRadius.DropDownStyle = ComboBoxStyle.DropDownList;

            //Set the initial values of combo boxes
            cbRadius.SelectedIndex = radiusList.IndexOf(0.8);
            cbDiscrete.SelectedIndex = discreteList.IndexOf(1);

            //Create instances for plates
            plateList.Add(new OCN());
            plateList.Add(new OPN());
            //
            //Set up plate comboBox
            comboBoxPlates.DataSource = plateList;
            comboBoxPlates.SelectedIndex = 0;
            //
            UpdatePlateParameters();
        }

        private void buttonGenerateCP_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Plate current = plateList[PlateIndex];
            current.GetParametersFromForm(this);
            current.WriteMetaCode(path);
            System.Diagnostics.Process.Start(path);
            this.Enabled = true;
        }

        private void UpdatePlateParameters()
        {
            tbRadius.Text = plateList[PlateIndex].VertexAngle.ToString();
        }

        private void plateChanged(object sender, EventArgs e)
        {
            UpdatePlateParameters();
        }
    }
}
