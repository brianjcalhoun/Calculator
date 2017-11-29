using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        Double value = 0;
        String display = "";
        bool btnOperator_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            lblEquation.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btnOperator_pressed)
                txtDisplay.Clear();

            btnOperator_pressed = false;
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

            lblEquation.Text = "";
            switch (display)
            {
                case "+":
                    txtDisplay.Text = (value + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (value - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (value / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (value * Double.Parse(txtDisplay.Text)).ToString();
                    break;
            }

            //if (value = Double.Parse(txtDisplay.Text) / 0));
            //{
            //    txtDisplay.Text = "Cannot divide by Zero";
            //}
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(txtDisplay.Text)));
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =(1 / Double.Parse(txtDisplay.Text)).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(txtDisplay.TextLength > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, (txtDisplay.TextLength - 1));
            }
            else
            {
                txtDisplay.Text = "";
            }
        }

        private void btnOperator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            display = b.Text;
            value = Double.Parse(txtDisplay.Text);
            btnOperator_pressed = true;
            lblEquation.Text = value + " " + display;
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "-" + txtDisplay.Text;
        }
    }
}
