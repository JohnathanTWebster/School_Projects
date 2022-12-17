using System;
using System.Windows.Forms;



/* 
Write a Visual Studio 2019 Windows Forms Application that allows a user to input five daily Fahrenheit temperatures that must range from −30 to 130;
if a temperature is out of range, require the user to reenter it. If no temperature is lower than any previous one, display a message Getting warmer.
If every temperature is lower than the previous one, display a message Getting cooler. If the temperatures are not entered in either ascending or descending order,
display a message It’s a mixed bag . Finally, display the average of the temperatures. Use the Controls that you think are best for each function.
Label items appropriately, and use fonts and colors to achieve an attractive design. Include a Close button to exit the application.
 */

namespace WebsterJohnathanHomework05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            //Delcare constants for value comparison
            const int lowerLimit = -30;
            const int upperLimit = 130;

            //Containers for all inputs from the user
            int day1 = Int32.Parse(day1textBox.Text);
            int day2 = Int32.Parse(day2textBox.Text);
            int day3 = Int32.Parse(day3textBox.Text);
            int day4 = Int32.Parse(day4textBox.Text);
            int day5 = Int32.Parse(day5textBox.Text);

            //Calculate the average of the temperatures entered

            int averageTemp = (day1 + day2 + day3 + day4 + day5) / 5;
            

            //Check to see if any of the values entered are below the allowed temp
            //If true then display message and have user re-enter by clearing text
            if (day1 < lowerLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day1textBox.Clear();
            }
            if(day2 < lowerLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day2textBox.Clear();
            }
            if(day3 < lowerLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day3textBox.Clear();
            }
            if(day4 < lowerLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day4textBox.Clear();
            }
            if(day5 < lowerLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day5textBox.Clear();
            }

            //Check to see if any of the values entered are above the allowed temp
            //If true then display message and have user re-enter by clearing text
            if (day1 > upperLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day1textBox.Clear();
            }
            if(day2 > upperLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day2textBox.Clear();
            }
            if(day3 > upperLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day3textBox.Clear();
            }
            if(day4 > upperLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day4textBox.Clear();
            }
            if(day5 > upperLimit)
            {
                MessageBox.Show("Please enter a number between -30 and 130");
                day5textBox.Clear();
            }


            //Check to see if the values entered at accending or decending
            //Display the message according to what was entered and the average with the message
            if((day2 > day1) && (day3 > day2) && (day4 > day3) && (day5 > day4))
            {
                MessageBox.Show("Getting Warmer");
                AverageTextBox.Text = averageTemp.ToString();
            }
            else if((day2 < day1) && (day3 < day2) && (day4 < day3) && (day5 < day4))
            {
                MessageBox.Show("Getting colder");
                AverageTextBox.Text = averageTemp.ToString();
            }
            else
            {
                MessageBox.Show("It's a mixed bag");
                AverageTextBox.Text = averageTemp.ToString();
            }

            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //When the clear button is pressed clear all text boxes
            day1textBox.Text = "";
            day2textBox.Text = "";
            day3textBox.Text = "";
            day4textBox.Text = "";
            day5textBox.Text = "";
            AverageTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //When the exit button is pressed close the application
            this.Close();
        }
    }
}
