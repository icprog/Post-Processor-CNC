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

namespace Post_Processor_CNC
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
            double R21, R2, R11, R7, R9, R91;
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write("DEF REAL GB\r\nDEF REAL ZZ\r\n");
            writer.WriteLine("GB=0");
            writer.Write("M3\r\nM8\r\n"); //Включение оборотов круга и подач охлаждения

            //Размер стороны
            R21 = Convert.ToDouble(numericSideSize.Value);
            writer.WriteLine("R21=" + Math.Round(R21,3));

            //Радиус
            R11 = ToRadians(int.Parse(comboBoxPlates.SelectedItem.ToString()));
            R2 = R21 / Math.Sin(R11);
            writer.WriteLine("R2=" + Math.Round(R2,3));

            //r4 & r5
            String r4_str = "R4=r2*(cos(r11/2))*(sin(r11/2)-r3";
            writer.WriteLine(r4_str.ToUpper());
            String r5_str = "R5=r4/(tan(r11/2))";
            writer.WriteLine(r5_str.ToUpper());

            //Дискретность
            R7 = (double)comboBoxDiscrete.SelectedItem;
            writer.WriteLine("R7="+Math.Round(R7,3));

            //Число проходов и припуск
            R9 = (double)numericPasses.Value;
            R91 = (double)numericAllowance.Value;
            writer.Write("R9=" + Math.Round(R9,3) + "\r\nR91=" + Math.Round(R91,3) + "\r\n");

            //Close streams
            writer.Close();
            fs.Close();
            System.Diagnostics.Process.Start(path);
        }

        private double ToRadians(int degrees)
        {
            return (Math.PI / 180) * degrees;
        }
    }
}
