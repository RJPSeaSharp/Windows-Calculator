using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_4._2._1_Calculator
{
    public partial class CalculatorForm : Form
    {


        double num1,num2;
        string operatorOption;
        double result;
        double resultValue=0;



        public CalculatorForm()
        {
            InitializeComponent();
            Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text = txtResult.Text + "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            num2 = double.Parse(txtResult.Text);

                if (operatorOption == ("+"))
                    result = num1 + num2;
                if (operatorOption == ("-"))
                    result = num1 - num2;
                if (operatorOption == ("*"))
                    result = num1 * num2;
                if (operatorOption == ("/"))
                    result = num1 / num2;

            txtResult.Text = result + "";
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text=="0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "3";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operatorOption = "+";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            txtResult.Text = txtResult.Text + "4";
        }
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text = txtResult.Text + "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operatorOption = "-";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operatorOption = "/";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operatorOption = "*";
            num1 = double.Parse(txtResult.Text);
            txtResult.Clear();
        }

        private void Play()
        {
         SystemSounds.Beep.Play();
        }

    }


}
