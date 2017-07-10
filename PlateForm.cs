﻿using System;
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
using BluePrints;



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
        String path = "test.txt";

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

            /*
            CNC.Append("R11", InputHelper.GetCBDouble(comboBoxPlates)); 
            CNC.Append("R21", numSideSize.Value);
            CNC.Append("R2", "R21/(SIN(R11))");
            CNC.Append("R3", InputHelper.GetCBDouble(cbRadius));
            CNC.Append("r4", "r2*(cos (r11/2))*(sin (r11/2)-r34)");
            CNC.Append("r5", "r4/ (tan (r11/2))");
            CNC.Append("r7", InputHelper.GetCBDouble(cbDiscrete));
            CNC.Append("r9", numPasses.Value);
            CNC.Append("r91", numAllowance.Value);

            CNC.Inline(true);
            CNC.GCode(90);
            CNC.GCode(1);
            CNC.Echo(numericX.Value);
            CNC.Echo(numericZ.Value);
            CNC.Echo(numericA.Value);
            CNC.FeedRate(9000);
            CNC.Inline(false);

            if (!checkFinishing.Checked)
            {
                CNC.While("gb<r9");

                CNC.Inline(true);
                CNC.GCode(1);
                CNC.Append("z", "-r91");
            }
            else
            {
                CNC.While("gb<1");

                CNC.Inline(true);
                CNC.GCode(1);
                CNC.Append("z", 0.005);
            }
            CNC.FeedRate(2000);
            CNC.Inline(false);

            CNC.Append("ZZ", 0);
            CNC.While("zz<2");

            CNC.Inline(true);
            CNC.GCode(1);
            CNC.XCode(15);
            CNC.FeedRate(1000);
            CNC.Inline(false);

            CNC.Append("r1", 1);
            CNC.Append("r8", 0);
            CNC.While("r1<=100");
            CNC.Append("r6", "R4-(SQRT(R4*R4+R5*R5))*(SIN(R11/2))");

            CNC.Inline(true);
            CNC.GCode(1);
            CNC.Append("z", "-(R6-R8)");
            CNC.Append("a", "r7");
            CNC.FeedRate(100);
            CNC.Inline(false);

            CNC.Append("r8", "r6");
            CNC.Append("r1", "r1+r7");
            CNC.Append("r6", 0);
            CNC.EndWhile();

            CNC.Inline(true);
            CNC.GCode(1);
            CNC.XCode(15);
            CNC.FeedRate(1000);
            CNC.Inline(false);

            CNC.Inline(true);
            CNC.GCode(0);
            CNC.Echo("a80");
            CNC.Inline(false);

            CNC.Append("zz", "zz+1");
            CNC.EndWhile();
            CNC.Append("gb", "gb+1");
            CNC.EndWhile();
            CNC.Append("gb", 0);

            CNC.MCode(new object[] { 5, 9, 30 });                       
            //Close streams
            writer.Close();
            fs.Close();*/
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