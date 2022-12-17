using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsterJohnathanHomework10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Set all lables to not be visable on launch
        private void Form1_Load(object sender, EventArgs e)
        {
            HarryPotterLabel.Visible = false;
            GameOfThronesLabel.Visible = false;
            StarWarsLabel.Visible = false;
            JavaProgrammingLabel.Visible = false;
            CProgrammingLabel.Visible = false;

        }

        


        //When an item index is selected in the listbox set the correct lable and color for book
        private void listBox1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                HarryPotterLabel.Visible = true;
                GameOfThronesLabel.Visible = false;
                StarWarsLabel.Visible = false;
                BackColor = Color.Tomato;
            }

            if (listBox1.SelectedIndex == 1)
            {
                HarryPotterLabel.Visible = false;
                GameOfThronesLabel.Visible = true;
                StarWarsLabel.Visible = false;
                BackColor = Color.SkyBlue;
            }

            if (listBox1.SelectedIndex == 2)
            {
                HarryPotterLabel.Visible = false;
                GameOfThronesLabel.Visible = false;
                StarWarsLabel.Visible = true;
                BackColor = Color.Gainsboro;
            }

            if (listBox1.SelectedIndex == 3)
            {
                HarryPotterLabel.Visible = false;
                GameOfThronesLabel.Visible = false;
                StarWarsLabel.Visible = false;
                JavaProgrammingLabel.Visible = true;
                CProgrammingLabel.Visible = false;
                BackColor = Color.Salmon;
            }
            if (listBox1.SelectedIndex == 4)
            {
                HarryPotterLabel.Visible = false;
                GameOfThronesLabel.Visible = false;
                StarWarsLabel.Visible = false;
                JavaProgrammingLabel.Visible = false;
                CProgrammingLabel.Visible = true;
                BackColor = Color.Coral;
            }

        }

        //If the mouse enters the listbox area display reading message
        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            ReadingStatementLabel.Visible = true;
        }

        //If the mouse leaves the listbox area remove message
        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            ReadingStatementLabel.Visible = false;
        }


        //Exit the application when the exit button is clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

