using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsterJohnathanHomework03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Initilize constants for hurricanes

            const int CATFIVE = 157;
            const int CATFOUR = 130;
            const int CATTHREE = 111;
            const int CATTWO = 96;
            const int CATONE = 74;

            //Main program
            try
            {
                //Set input to int
                int windSpeed = int.Parse(WindSpeedTextBox.Text);

                //Compare wind speed to category speeds and display correct category
                if (windSpeed >= CATFIVE)
                {
                    CategoryTextBox.Text = "Category 5 Hurricane";

                }else if (windSpeed >= CATFOUR && windSpeed <CATFIVE)
                {
                    CategoryTextBox.Text = "Category 4 Hurricane";

                }else if (windSpeed >= CATTHREE && windSpeed < CATFOUR)
                {
                    CategoryTextBox.Text = "Category 3 Hurricane";

                }else if (windSpeed >= CATTWO && windSpeed < CATTHREE)
                {
                    CategoryTextBox.Text = "Category 2 Hurricane";

                }else if (windSpeed >= CATONE && windSpeed < CATTWO)
                {
                    CategoryTextBox.Text = "Category 1 Hurricane";
                }
                else
                {
                    CategoryTextBox.Text = "Not a Hurricane";
                }
                                
            }
            //Return error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Reset text boxes
            WindSpeedTextBox.Text = "";
            CategoryTextBox.Text = "";
        }
    }
}
