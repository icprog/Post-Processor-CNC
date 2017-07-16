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
                return Convert.ToDouble(_sideSizeNum.Value);
            }
        }
        public double Radius
        {
            get
            {
                return Convert.ToDouble(_radiusCBox.SelectedItem);
            }
        }
        public double OverMeasure
        {
            get
            {
                return Convert.ToDouble(_allowanceNum.Value);
            }
        }
        public double PlateExit
        {
            get
            {
                return Convert.ToDouble(_plateExitNum.Value);
            }
        }
        public double Passes
        {
            get
            {
                return Convert.ToDouble(_passesNum.Value);
            }
        }
        public double Discreteness
        {
            get
            {
                return Convert.ToDouble(_discreteCBox.SelectedItem);
            }
        }
        public bool Finishing
        {
            get
            {
                return _finichingCheck.Checked;
            }
        }
        public double InitialX
        {
            get
            {
                return (double)_xNum.Value;
            }
        }
        public double InitialZ
        {
            get
            {
                return (double)_zNum.Value;
            }
        }
        public double InitialA
        {
            get
            {
                return (double)_aNum.Value;
            }
        }

        //Private Parameters
        private int _plateIndex
        {
            get
            {
                return _platesCBox.SelectedIndex;
            }
        }
        private String _resultPath = "test.txt"; //принесет илья

        //Lists
        /// <summary>
        /// List of plate objects 
        /// </summary>
        private List<Plate> _plateList = new List<Plate>();       
        /// <summary>
        /// Discrete combobox items
        /// </summary>
        private List<double> _discreteList = new List<double>()
        {
            0.2,
            0.5,
            1.0
        };
        /// <summary>
        /// Radius combobox items
        /// </summary>
        private List<double> _radiusList = new List<double>()
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
            _radiusCBox.DataSource = _radiusList;
            _discreteCBox.DataSource = _discreteList;
            _discreteCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _platesCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _radiusCBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Set the initial values of combo boxes
            _radiusCBox.SelectedIndex = _radiusList.IndexOf(0.8);
            _discreteCBox.SelectedIndex = _discreteList.IndexOf(1);

            //Create instances for plates
            _plateList.Add(new RhombWide());
            _plateList.Add(new Pentagon());
            _plateList.Add(new RhombNarrow());
            //
            //Set up plate comboBox
            _platesCBox.DataSource = _plateList;
            _platesCBox.SelectedIndex = 0;
            //
            _PlateChanged(new object(), new EventArgs());
        }

        private void _GenerateControlProgramm(object sender, EventArgs e)
        {
            this.Enabled = false;
            Plate current = _plateList[_plateIndex];
            current.GetParametersFromForm(this);
            current.WriteMetaCode(_resultPath);
            System.Diagnostics.Process.Start(_resultPath);
            this.Enabled = true;
        }

        private void _UpdatePlateSketch()
        {
            String imgName = _plateList[_plateIndex].ToString() + ".png";
            try
            {
                SketchBox.Image = Image.FromFile("Images\\" + imgName);
            }
            catch
            {
                SketchBox.Image = SketchBox.ErrorImage;
            }
        }

        private void _PlateChanged(object sender, EventArgs e)
        {
            _UpdatePlateSketch();
        }
    }
}
