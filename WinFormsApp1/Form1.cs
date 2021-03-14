using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double resultvalue=0;
        string operationperformed = "";
        bool isoperationperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isoperationperformed))
                textBox_Result.Clear();
            isoperationperformed = false;
            Button button = (Button)sender;
            if (button.Text==".")
            {
                if (textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultvalue != 0)
            {
                button14.PerformClick();
                operationperformed = button.Text;
                labeloperation.Text = resultvalue + " " + operationperformed;
                isoperationperformed = true;
            }
            else
            {
                operationperformed = button.Text;
                resultvalue = Double.Parse(textBox_Result.Text);
                labeloperation.Text = resultvalue + " " + operationperformed;
                isoperationperformed = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox_Result.Text = (resultvalue +Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultvalue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultvalue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultvalue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultvalue = Double.Parse(textBox_Result.Text);
            labeloperation.Text = " ";
        }
    }
}
