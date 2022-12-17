
namespace WebsterJohnathanHomework09
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
            this.RoomsComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NumberofRoomsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.LakeViewComboBox = new System.Windows.Forms.ComboBox();
            this.LakeViewLabel = new System.Windows.Forms.Label();
            this.BathroomComboBox = new System.Windows.Forms.ComboBox();
            this.BathroomsLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomsComboBox
            // 
            this.RoomsComboBox.FormattingEnabled = true;
            this.RoomsComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.RoomsComboBox.Location = new System.Drawing.Point(174, 43);
            this.RoomsComboBox.Name = "RoomsComboBox";
            this.RoomsComboBox.Size = new System.Drawing.Size(121, 23);
            this.RoomsComboBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(272, 185);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NumberofRoomsLabel
            // 
            this.NumberofRoomsLabel.AutoSize = true;
            this.NumberofRoomsLabel.Location = new System.Drawing.Point(16, 43);
            this.NumberofRoomsLabel.Name = "NumberofRoomsLabel";
            this.NumberofRoomsLabel.Size = new System.Drawing.Size(105, 15);
            this.NumberofRoomsLabel.TabIndex = 2;
            this.NumberofRoomsLabel.Text = "Number of Rooms";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalPriceLabel);
            this.groupBox1.Controls.Add(this.TotalPriceTextBox);
            this.groupBox1.Controls.Add(this.LakeViewComboBox);
            this.groupBox1.Controls.Add(this.LakeViewLabel);
            this.groupBox1.Controls.Add(this.BathroomComboBox);
            this.groupBox1.Controls.Add(this.BathroomsLabel);
            this.groupBox1.Controls.Add(this.RoomsComboBox);
            this.groupBox1.Controls.Add(this.CalculateButton);
            this.groupBox1.Controls.Add(this.NumberofRoomsLabel);
            this.groupBox1.Location = new System.Drawing.Point(76, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Price";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(54, 188);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(61, 15);
            this.TotalPriceLabel.TabIndex = 8;
            this.TotalPriceLabel.Text = "Total Price";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Location = new System.Drawing.Point(121, 185);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.TotalPriceTextBox.TabIndex = 7;
            // 
            // LakeViewComboBox
            // 
            this.LakeViewComboBox.FormattingEnabled = true;
            this.LakeViewComboBox.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.LakeViewComboBox.Location = new System.Drawing.Point(174, 119);
            this.LakeViewComboBox.Name = "LakeViewComboBox";
            this.LakeViewComboBox.Size = new System.Drawing.Size(121, 23);
            this.LakeViewComboBox.TabIndex = 6;
            // 
            // LakeViewLabel
            // 
            this.LakeViewLabel.AutoSize = true;
            this.LakeViewLabel.Location = new System.Drawing.Point(16, 119);
            this.LakeViewLabel.Name = "LakeViewLabel";
            this.LakeViewLabel.Size = new System.Drawing.Size(64, 15);
            this.LakeViewLabel.TabIndex = 5;
            this.LakeViewLabel.Text = "Lake View?";
            // 
            // BathroomComboBox
            // 
            this.BathroomComboBox.FormattingEnabled = true;
            this.BathroomComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.BathroomComboBox.Location = new System.Drawing.Point(174, 83);
            this.BathroomComboBox.Name = "BathroomComboBox";
            this.BathroomComboBox.Size = new System.Drawing.Size(121, 23);
            this.BathroomComboBox.TabIndex = 4;
            // 
            // BathroomsLabel
            // 
            this.BathroomsLabel.AutoSize = true;
            this.BathroomsLabel.Location = new System.Drawing.Point(16, 83);
            this.BathroomsLabel.Name = "BathroomsLabel";
            this.BathroomsLabel.Size = new System.Drawing.Size(126, 15);
            this.BathroomsLabel.TabIndex = 3;
            this.BathroomsLabel.Text = "Number of Bathrooms";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(472, 349);
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
            this.ClientSize = new System.Drawing.Size(559, 384);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox RoomsComboBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label NumberofRoomsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox BathroomComboBox;
        private System.Windows.Forms.Label BathroomsLabel;
        private System.Windows.Forms.ComboBox LakeViewComboBox;
        private System.Windows.Forms.Label LakeViewLabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

