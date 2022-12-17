
namespace WebsterJohnathanHomework04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Phrase_G_Box = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Uppercase_Box = new System.Windows.Forms.TextBox();
            this.Lowercase_Box = new System.Windows.Forms.TextBox();
            this.Phrase_Box = new System.Windows.Forms.TextBox();
            this.Run_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Phrase_G_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Phrase_G_Box
            // 
            this.Phrase_G_Box.Controls.Add(this.label2);
            this.Phrase_G_Box.Controls.Add(this.label1);
            this.Phrase_G_Box.Controls.Add(this.Uppercase_Box);
            this.Phrase_G_Box.Controls.Add(this.Lowercase_Box);
            this.Phrase_G_Box.Controls.Add(this.Phrase_Box);
            this.Phrase_G_Box.Location = new System.Drawing.Point(76, 63);
            this.Phrase_G_Box.Name = "Phrase_G_Box";
            this.Phrase_G_Box.Size = new System.Drawing.Size(289, 186);
            this.Phrase_G_Box.TabIndex = 0;
            this.Phrase_G_Box.TabStop = false;
            this.Phrase_G_Box.Text = "Please Enter A Phrase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uppercase Vowels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lowercase Vowels";
            // 
            // Uppercase_Box
            // 
            this.Uppercase_Box.Location = new System.Drawing.Point(113, 125);
            this.Uppercase_Box.Name = "Uppercase_Box";
            this.Uppercase_Box.Size = new System.Drawing.Size(75, 23);
            this.Uppercase_Box.TabIndex = 4;
            // 
            // Lowercase_Box
            // 
            this.Lowercase_Box.Location = new System.Drawing.Point(113, 96);
            this.Lowercase_Box.Name = "Lowercase_Box";
            this.Lowercase_Box.Size = new System.Drawing.Size(75, 23);
            this.Lowercase_Box.TabIndex = 3;
            // 
            // Phrase_Box
            // 
            this.Phrase_Box.Location = new System.Drawing.Point(34, 38);
            this.Phrase_Box.Name = "Phrase_Box";
            this.Phrase_Box.Size = new System.Drawing.Size(216, 23);
            this.Phrase_Box.TabIndex = 0;
            // 
            // Run_Button
            // 
            this.Run_Button.Location = new System.Drawing.Point(76, 267);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(75, 23);
            this.Run_Button.TabIndex = 1;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(189, 267);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 23);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(290, 267);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 338);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Phrase_G_Box);
            this.Controls.Add(this.Run_Button);
            this.Controls.Add(this.Clear_Button);
            this.Name = "Form1";
            this.Text = "Vowel Counter";
            this.Phrase_G_Box.ResumeLayout(false);
            this.Phrase_G_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Phrase_G_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Uppercase_Box;
        private System.Windows.Forms.TextBox Lowercase_Box;
        private System.Windows.Forms.TextBox Phrase_Box;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

