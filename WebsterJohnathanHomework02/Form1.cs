using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsterJohnathanHomework02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try 
            {
                //Variable Container Declarations
                double test1, test2, test3, test4, test5, average;

                //Assign vaiables specified input
                test1 = double.Parse(textBox1.Text);
                test2 = double.Parse(textBox2.Text);
                test3 = double.Parse(textBox3.Text);
                test4 = double.Parse(textBox4.Text);
                test5 = double.Parse(textBox5.Text);

                //Calculate Average
                average = (test1 + test2 + test3 + test4 + test5) / 5.0;

                //Display Average
                AverageOutput.Text = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Reset text boxes

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            AverageOutput.Text = "";

            //Set focus to first box
            textBox1.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
