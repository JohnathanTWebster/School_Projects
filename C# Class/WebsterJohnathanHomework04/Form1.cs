using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebsterJohnathanHomework04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            //global containers
            int upperCounter = 0;
            int lowerCounter = 0;

            //convert phrase string to a char array
            string phrase = Phrase_Box.Text;
            char[] phraseArray =  phrase.ToCharArray(); 


            //loop through each element in the array and add to global for each encountered
            foreach(char character in phraseArray)
            {
                if(character == 'A' || character == 'E'|| character == 'I' || character == 'O' || character == 'U')
                {
                    upperCounter++;
                }
                if(character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    lowerCounter++;
                }
            }
            //set text for each box accordingly
            Lowercase_Box.Text = lowerCounter.ToString();
            Uppercase_Box.Text = upperCounter.ToString();
        }

        //clear all text from boxes
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Lowercase_Box.Text = "";
            Uppercase_Box.Text = "";
            Phrase_Box.Text = "";
        }

        //exit application
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
