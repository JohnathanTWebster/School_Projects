
namespace WebsterJohnathanHomework10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadingStatementLabel = new System.Windows.Forms.Label();
            this.HarryPotterLabel = new System.Windows.Forms.Label();
            this.GameOfThronesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StarWarsLabel = new System.Windows.Forms.Label();
            this.JavaProgrammingLabel = new System.Windows.Forms.Label();
            this.CProgrammingLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Harry Potter and the Sorcerer\'s Stone",
            "Game of Thrones",
            "Star Wars: The Phantom Menace",
            "Java SE 17, Java™: The Complete Reference, Twelfth Edition ",
            "C Programming"});
            this.listBox1.Location = new System.Drawing.Point(50, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 94);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // ReadingStatementLabel
            // 
            this.ReadingStatementLabel.AutoSize = true;
            this.ReadingStatementLabel.Location = new System.Drawing.Point(50, 30);
            this.ReadingStatementLabel.Name = "ReadingStatementLabel";
            this.ReadingStatementLabel.Size = new System.Drawing.Size(312, 60);
            this.ReadingStatementLabel.TabIndex = 2;
            this.ReadingStatementLabel.Text = "Some Facts about reading:\r\nReading Exercises the Brain.\r\nReading is a Form of (fr" +
    "ee) Entertainment\r\nReading Improves Concentration and the Ability to Focus.\r\n";
            this.ReadingStatementLabel.Visible = false;
            // 
            // HarryPotterLabel
            // 
            this.HarryPotterLabel.AutoSize = true;
            this.HarryPotterLabel.Location = new System.Drawing.Point(50, 230);
            this.HarryPotterLabel.Name = "HarryPotterLabel";
            this.HarryPotterLabel.Size = new System.Drawing.Size(250, 120);
            this.HarryPotterLabel.TabIndex = 3;
            this.HarryPotterLabel.Text = resources.GetString("HarryPotterLabel.Text");
            this.HarryPotterLabel.Visible = false;
            // 
            // GameOfThronesLabel
            // 
            this.GameOfThronesLabel.AutoSize = true;
            this.GameOfThronesLabel.Location = new System.Drawing.Point(50, 234);
            this.GameOfThronesLabel.Name = "GameOfThronesLabel";
            this.GameOfThronesLabel.Size = new System.Drawing.Size(281, 90);
            this.GameOfThronesLabel.TabIndex = 4;
            this.GameOfThronesLabel.Text = resources.GetString("GameOfThronesLabel.Text");
            this.GameOfThronesLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 5;
            // 
            // StarWarsLabel
            // 
            this.StarWarsLabel.AutoSize = true;
            this.StarWarsLabel.Location = new System.Drawing.Point(50, 264);
            this.StarWarsLabel.Name = "StarWarsLabel";
            this.StarWarsLabel.Size = new System.Drawing.Size(416, 60);
            this.StarWarsLabel.TabIndex = 6;
            this.StarWarsLabel.Text = resources.GetString("StarWarsLabel.Text");
            // 
            // JavaProgrammingLabel
            // 
            this.JavaProgrammingLabel.AutoSize = true;
            this.JavaProgrammingLabel.Location = new System.Drawing.Point(50, 215);
            this.JavaProgrammingLabel.Name = "JavaProgrammingLabel";
            this.JavaProgrammingLabel.Size = new System.Drawing.Size(429, 60);
            this.JavaProgrammingLabel.TabIndex = 7;
            this.JavaProgrammingLabel.Text = resources.GetString("JavaProgrammingLabel.Text");
            // 
            // CProgrammingLabel
            // 
            this.CProgrammingLabel.AutoSize = true;
            this.CProgrammingLabel.Location = new System.Drawing.Point(50, 215);
            this.CProgrammingLabel.Name = "CProgrammingLabel";
            this.CProgrammingLabel.Size = new System.Drawing.Size(468, 60);
            this.CProgrammingLabel.TabIndex = 8;
            this.CProgrammingLabel.Text = resources.GetString("CProgrammingLabel.Text");
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(472, 311);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 359);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CProgrammingLabel);
            this.Controls.Add(this.JavaProgrammingLabel);
            this.Controls.Add(this.StarWarsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GameOfThronesLabel);
            this.Controls.Add(this.HarryPotterLabel);
            this.Controls.Add(this.ReadingStatementLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReadingStatementLabel;
        private System.Windows.Forms.Label HarryPotterLabel;
        private System.Windows.Forms.Label GameOfThronesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StarWarsLabel;
        private System.Windows.Forms.Label JavaProgrammingLabel;
        private System.Windows.Forms.Label CProgrammingLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

