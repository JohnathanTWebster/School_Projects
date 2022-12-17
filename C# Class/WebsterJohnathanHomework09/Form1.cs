using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsterJohnathanHomework09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RoomsComboBox_MouseEnter(object sender, EventArgs e)
        {

        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Global Contatiner for total price and prices of selections
            int TotalPrice = 0;
            int OneBedRoom = 450;
            int TwoBedRoom = 550;
            int ThreeBedRoom = 700;
            int BathroomPrice = 75;
            int LakeViewPrice = 50;

            try
            {
                //Check for bedrooms
                switch (RoomsComboBox.Text)
                {
                    case "1":
                        TotalPrice += OneBedRoom;
                        break;
                    case "2":
                        TotalPrice += TwoBedRoom;
                        break;
                    case "3":
                        TotalPrice += ThreeBedRoom;
                        break;
                    default:
                        MessageBox.Show("Please enter valid number of rooms");
                        return;                        
                }
                //Check for Bathrooms
                switch(BathroomComboBox.Text)
                {
                    case "1":
                        break;
                    case "2":
                        TotalPrice += BathroomPrice;
                        break;
                    case "3":
                        TotalPrice += BathroomPrice;
                        break;
                    default:
                        MessageBox.Show("Please enter valid number of bathrooms");
                        return;
                }
                //Check for Lake View
                switch(LakeViewComboBox.Text)
                {
                    case "Yes":
                        TotalPrice += LakeViewPrice;
                        break;
                    case "No":
                        break;
                    default:
                        MessageBox.Show("Please enter  \"Yes\" or \"No\" for lake view");
                        return;
                }
                //Update total price text box to display total price
                TotalPriceTextBox.Text = "$" + Convert.ToString(TotalPrice);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
