using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
    // This program was written by Gail Mosdell
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Date : February 2017
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-----------------------------------------
        //               CM to Inches
        //-----------------------------------------
        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            const double CM_TO_INCH = 0.3937;
           
            // validate user entry and convert to a double

            if (! double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * CM_TO_INCH;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
            }
        }

        //-----------------------------------------
        //               M to Feet
        //-----------------------------------------
        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_TO_FEET = 3.2808;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * M_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " metres is converted to ";
                lbl_Convert.Text = " feet.";
            }
        }

        //-----------------------------------------
        //               Celsius to Fahrenheit
        //-----------------------------------------
        private void btn_C_to_F_Click(object sender, EventArgs e)
        {
            const double X = 9;
            const double Y = 5;
            const double Z = 32;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * X/Y+Z;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " degrees Celsius is converted to ";
                lbl_Convert.Text = " degrees Fahrenheit.";
            }
        }

        //-----------------------------------------
        //               CM to Feet
        //-----------------------------------------
        private void btn_CM_to_Feet_Click(object sender, EventArgs e)
        {
            const double CM_TO_FEET = 0.032808;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * CM_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                lbl_Convert.Text = " feet.";
            }
        }

        //-----------------------------------------
        //               KM to Miles
        //-----------------------------------------
        private void btn_KM_to_Miles_Click(object sender, EventArgs e)
        {
            const double KM_TO_MILES = 0.6213712;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * KM_TO_MILES;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " kilometres is converted to ";
                lbl_Convert.Text = " miles.";
            }
        }
    }
}
