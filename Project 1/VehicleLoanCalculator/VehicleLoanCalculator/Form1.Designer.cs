namespace VehicleLoanCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.displayLoanButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.loanListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalLoanLabel = new System.Windows.Forms.TextBox();
            this.totalInterestLabel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.twentyFourRadioButton = new System.Windows.Forms.RadioButton();
            this.twelveRadioButton = new System.Windows.Forms.RadioButton();
            this.eighteenRadioButton = new System.Windows.Forms.RadioButton();
            this.sixRadioButton = new System.Windows.Forms.RadioButton();
            this.rebateTextBox = new System.Windows.Forms.TextBox();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.annualAPRComboBox = new System.Windows.Forms.ComboBox();
            this.rebateCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(566, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 140);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VehicleLoanCalculator.Properties.Resources.nc_state_poole;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.calcButton);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.acceptButton);
            this.panel2.Controls.Add(this.displayLoanButton);
            this.panel2.Location = new System.Drawing.Point(532, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 291);
            this.panel2.TabIndex = 1;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.calcButton.Location = new System.Drawing.Point(-1, 3);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(186, 72);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "&Calculate Loan";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(-1, 217);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 74);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.IndianRed;
            this.acceptButton.Location = new System.Drawing.Point(-1, 70);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(187, 70);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "&Accept Loan";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // displayLoanButton
            // 
            this.displayLoanButton.BackColor = System.Drawing.Color.IndianRed;
            this.displayLoanButton.Location = new System.Drawing.Point(-1, 135);
            this.displayLoanButton.Name = "displayLoanButton";
            this.displayLoanButton.Size = new System.Drawing.Size(186, 87);
            this.displayLoanButton.TabIndex = 2;
            this.displayLoanButton.Text = "&Display All Loans";
            this.displayLoanButton.UseVisualStyleBackColor = false;
            this.displayLoanButton.Click += new System.EventHandler(this.displayLoanButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 631);
            this.panel3.TabIndex = 0;
           
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FloralWhite;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.loanListBox);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.rebateTextBox);
            this.panel5.Controls.Add(this.loanTextBox);
            this.panel5.Controls.Add(this.annualAPRComboBox);
            this.panel5.Controls.Add(this.rebateCheckBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(35, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(717, 528);
            this.panel5.TabIndex = 4;
            // 
            // loanListBox
            // 
            this.loanListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanListBox.FormattingEnabled = true;
            this.loanListBox.ItemHeight = 17;
            this.loanListBox.Location = new System.Drawing.Point(14, 218);
            this.loanListBox.Name = "loanListBox";
            this.loanListBox.Size = new System.Drawing.Size(499, 259);
            this.loanListBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Balance";
     
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Payment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Principal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Month";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.totalLoanLabel);
            this.panel4.Controls.Add(this.totalInterestLabel);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(531, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 182);
            this.panel4.TabIndex = 13;
            // 
            // totalLoanLabel
            // 
            this.totalLoanLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalLoanLabel.Location = new System.Drawing.Point(40, 104);
            this.totalLoanLabel.Name = "totalLoanLabel";
            this.totalLoanLabel.Size = new System.Drawing.Size(105, 27);
            this.totalLoanLabel.TabIndex = 3;
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalInterestLabel.Location = new System.Drawing.Point(41, 46);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(105, 27);
            this.totalInterestLabel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total loans:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total interest:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twentyFourRadioButton);
            this.groupBox1.Controls.Add(this.twelveRadioButton);
            this.groupBox1.Controls.Add(this.eighteenRadioButton);
            this.groupBox1.Controls.Add(this.sixRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(296, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Months";
            // 
            // twentyFourRadioButton
            // 
            this.twentyFourRadioButton.AutoSize = true;
            this.twentyFourRadioButton.Location = new System.Drawing.Point(68, 61);
            this.twentyFourRadioButton.Name = "twentyFourRadioButton";
            this.twentyFourRadioButton.Size = new System.Drawing.Size(46, 24);
            this.twentyFourRadioButton.TabIndex = 3;
            this.twentyFourRadioButton.Text = "24";
            this.twentyFourRadioButton.UseVisualStyleBackColor = true;
            // 
            // twelveRadioButton
            // 
            this.twelveRadioButton.AutoSize = true;
            this.twelveRadioButton.Location = new System.Drawing.Point(15, 61);
            this.twelveRadioButton.Name = "twelveRadioButton";
            this.twelveRadioButton.Size = new System.Drawing.Size(46, 24);
            this.twelveRadioButton.TabIndex = 1;
            this.twelveRadioButton.Text = "12";
            this.twelveRadioButton.UseVisualStyleBackColor = true;
            // 
            // eighteenRadioButton
            // 
            this.eighteenRadioButton.AutoSize = true;
            this.eighteenRadioButton.Location = new System.Drawing.Point(68, 32);
            this.eighteenRadioButton.Name = "eighteenRadioButton";
            this.eighteenRadioButton.Size = new System.Drawing.Size(46, 24);
            this.eighteenRadioButton.TabIndex = 2;
            this.eighteenRadioButton.Text = "18";
            this.eighteenRadioButton.UseVisualStyleBackColor = true;
            // 
            // sixRadioButton
            // 
            this.sixRadioButton.AutoSize = true;
            this.sixRadioButton.Checked = true;
            this.sixRadioButton.Location = new System.Drawing.Point(15, 32);
            this.sixRadioButton.Name = "sixRadioButton";
            this.sixRadioButton.Size = new System.Drawing.Size(38, 24);
            this.sixRadioButton.TabIndex = 0;
            this.sixRadioButton.TabStop = true;
            this.sixRadioButton.Text = "6";
            this.sixRadioButton.UseVisualStyleBackColor = true;
            // 
            // rebateTextBox
            // 
            this.rebateTextBox.Enabled = false;
            this.rebateTextBox.Location = new System.Drawing.Point(175, 106);
            this.rebateTextBox.Name = "rebateTextBox";
            this.rebateTextBox.Size = new System.Drawing.Size(74, 27);
            this.rebateTextBox.TabIndex = 5;
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(175, 19);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(74, 27);
            this.loanTextBox.TabIndex = 3;
            this.loanTextBox.Click += new System.EventHandler(this.loanTextBox_Click);
            this.loanTextBox.TextChanged += new System.EventHandler(this.loanTextBox_TextChanged);
            this.loanTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loanTextBox_KeyPress);
            // 
            // annualAPRComboBox
            // 
            this.annualAPRComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.annualAPRComboBox.FormattingEnabled = true;
            this.annualAPRComboBox.Location = new System.Drawing.Point(175, 63);
            this.annualAPRComboBox.Name = "annualAPRComboBox";
            this.annualAPRComboBox.Size = new System.Drawing.Size(74, 28);
            this.annualAPRComboBox.TabIndex = 4;
            // 
            // rebateCheckBox
            // 
            this.rebateCheckBox.AutoSize = true;
            this.rebateCheckBox.Location = new System.Drawing.Point(70, 106);
            this.rebateCheckBox.Name = "rebateCheckBox";
            this.rebateCheckBox.Size = new System.Drawing.Size(85, 24);
            this.rebateCheckBox.TabIndex = 2;
            this.rebateCheckBox.Text = "Rebate?";
            this.rebateCheckBox.UseVisualStyleBackColor = true;
            this.rebateCheckBox.CheckedChanged += new System.EventHandler(this.rebateCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Annual APR (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loan amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Loan Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic and Industry Collaboration";
            // 
            // MainForm
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(785, 634);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Vehicle Loan Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayLoanButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox loanListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox totalLoanLabel;
        private System.Windows.Forms.TextBox totalInterestLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton twentyFourRadioButton;
        private System.Windows.Forms.RadioButton twelveRadioButton;
        private System.Windows.Forms.RadioButton eighteenRadioButton;
        private System.Windows.Forms.RadioButton sixRadioButton;
        private System.Windows.Forms.TextBox rebateTextBox;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.ComboBox annualAPRComboBox;
        private System.Windows.Forms.CheckBox rebateCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

