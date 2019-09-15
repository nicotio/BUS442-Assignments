namespace PairProgrammingProject
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
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.absoluteValueButton = new System.Windows.Forms.Button();
            this.reciprocalButton = new System.Windows.Forms.Button();
            this.fileSumButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.fibonacciButton = new System.Windows.Forms.Button();
            this.pythagoreanButton = new System.Windows.Forms.Button();
            this.perimeterButton = new System.Windows.Forms.Button();
            this.primeButton = new System.Windows.Forms.Button();
            this.squaresSumButton = new System.Windows.Forms.Button();
            this.rangeButton = new System.Windows.Forms.Button();
            this.standardDevButton = new System.Windows.Forms.Button();
            this.sumSquaredFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wildcardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(48, 26);
            this.startTextBox.MaxLength = 9;
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(59, 27);
            this.startTextBox.TabIndex = 2;
            this.startTextBox.Click += new System.EventHandler(this.startTextBox_Click);
            this.startTextBox.TextChanged += new System.EventHandler(this.startTextBox_TextChanged);
            this.startTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startTextBox_KeyPress);
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(168, 27);
            this.endTextBox.MaxLength = 9;
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(59, 27);
            this.endTextBox.TabIndex = 3;
            this.endTextBox.Click += new System.EventHandler(this.endTextBox_Click);
            this.endTextBox.TextChanged += new System.EventHandler(this.endTextBox_TextChanged);
            this.endTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endTextBox_KeyPress);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 20;
            this.resultListBox.Location = new System.Drawing.Point(48, 78);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(320, 124);
            this.resultListBox.TabIndex = 5;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // absoluteValueButton
            // 
            this.absoluteValueButton.Location = new System.Drawing.Point(48, 208);
            this.absoluteValueButton.Name = "absoluteValueButton";
            this.absoluteValueButton.Size = new System.Drawing.Size(102, 52);
            this.absoluteValueButton.TabIndex = 6;
            this.absoluteValueButton.Text = "&Absolute Value";
            this.absoluteValueButton.UseVisualStyleBackColor = true;
            this.absoluteValueButton.Click += new System.EventHandler(this.absoluteValueButton_Click);
            // 
            // reciprocalButton
            // 
            this.reciprocalButton.Location = new System.Drawing.Point(156, 208);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.Size = new System.Drawing.Size(102, 52);
            this.reciprocalButton.TabIndex = 7;
            this.reciprocalButton.Text = "Reciproca&l";
            this.reciprocalButton.UseVisualStyleBackColor = true;
            this.reciprocalButton.Click += new System.EventHandler(this.reciprocalButton_Click);
            // 
            // fileSumButton
            // 
            this.fileSumButton.Location = new System.Drawing.Point(266, 208);
            this.fileSumButton.Name = "fileSumButton";
            this.fileSumButton.Size = new System.Drawing.Size(102, 52);
            this.fileSumButton.TabIndex = 8;
            this.fileSumButton.Text = "S&um of File Values";
            this.fileSumButton.UseVisualStyleBackColor = true;
            this.fileSumButton.Click += new System.EventHandler(this.fileSumButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(48, 266);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(102, 52);
            this.multiplyButton.TabIndex = 9;
            this.multiplyButton.Text = "&Multiplication Table";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.Location = new System.Drawing.Point(156, 266);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(102, 51);
            this.factorialButton.TabIndex = 10;
            this.factorialButton.Text = "Fa&ctorial";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // fibonacciButton
            // 
            this.fibonacciButton.Location = new System.Drawing.Point(266, 266);
            this.fibonacciButton.Name = "fibonacciButton";
            this.fibonacciButton.Size = new System.Drawing.Size(102, 52);
            this.fibonacciButton.TabIndex = 11;
            this.fibonacciButton.Text = "&Fibonacci";
            this.fibonacciButton.UseVisualStyleBackColor = true;
            this.fibonacciButton.Click += new System.EventHandler(this.fibonacciButton_Click);
            // 
            // pythagoreanButton
            // 
            this.pythagoreanButton.Location = new System.Drawing.Point(48, 323);
            this.pythagoreanButton.Name = "pythagoreanButton";
            this.pythagoreanButton.Size = new System.Drawing.Size(102, 53);
            this.pythagoreanButton.TabIndex = 12;
            this.pythagoreanButton.Text = "&Pythagorean Theorm";
            this.pythagoreanButton.UseVisualStyleBackColor = true;
            this.pythagoreanButton.Click += new System.EventHandler(this.pythagoreanButton_Click);
            // 
            // perimeterButton
            // 
            this.perimeterButton.Location = new System.Drawing.Point(156, 323);
            this.perimeterButton.Name = "perimeterButton";
            this.perimeterButton.Size = new System.Drawing.Size(102, 53);
            this.perimeterButton.TabIndex = 13;
            this.perimeterButton.Text = "Perime&ter";
            this.perimeterButton.UseVisualStyleBackColor = true;
            this.perimeterButton.Click += new System.EventHandler(this.perimeterButton_Click);
            // 
            // primeButton
            // 
            this.primeButton.Location = new System.Drawing.Point(266, 324);
            this.primeButton.Name = "primeButton";
            this.primeButton.Size = new System.Drawing.Size(102, 52);
            this.primeButton.TabIndex = 14;
            this.primeButton.Text = "Pr&ime";
            this.primeButton.UseVisualStyleBackColor = true;
            this.primeButton.Click += new System.EventHandler(this.primeButton_Click);
            // 
            // squaresSumButton
            // 
            this.squaresSumButton.Location = new System.Drawing.Point(48, 383);
            this.squaresSumButton.Name = "squaresSumButton";
            this.squaresSumButton.Size = new System.Drawing.Size(102, 51);
            this.squaresSumButton.TabIndex = 15;
            this.squaresSumButton.Text = "&Sum of Squares";
            this.squaresSumButton.UseVisualStyleBackColor = true;
            this.squaresSumButton.Click += new System.EventHandler(this.squaresSumButton_Click);
            // 
            // rangeButton
            // 
            this.rangeButton.Location = new System.Drawing.Point(156, 383);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(102, 51);
            this.rangeButton.TabIndex = 16;
            this.rangeButton.Text = "&Range";
            this.rangeButton.UseVisualStyleBackColor = true;
            this.rangeButton.Click += new System.EventHandler(this.rangeButton1_Click);
            // 
            // standardDevButton
            // 
            this.standardDevButton.Location = new System.Drawing.Point(266, 383);
            this.standardDevButton.Name = "standardDevButton";
            this.standardDevButton.Size = new System.Drawing.Size(102, 51);
            this.standardDevButton.TabIndex = 17;
            this.standardDevButton.Text = "Standard De&viation";
            this.standardDevButton.UseVisualStyleBackColor = true;
            this.standardDevButton.Click += new System.EventHandler(this.standardDevButton_Click);
            // 
            // sumSquaredFileButton
            // 
            this.sumSquaredFileButton.Location = new System.Drawing.Point(48, 440);
            this.sumSquaredFileButton.Name = "sumSquaredFileButton";
            this.sumSquaredFileButton.Size = new System.Drawing.Size(102, 52);
            this.sumSquaredFileButton.TabIndex = 18;
            this.sumSquaredFileButton.Text = "Sum of S&quared File Values";
            this.sumSquaredFileButton.UseVisualStyleBackColor = true;
            this.sumSquaredFileButton.Click += new System.EventHandler(this.sumSquaredFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "End number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result:";
            // 
            // wildcardButton
            // 
            this.wildcardButton.Location = new System.Drawing.Point(156, 440);
            this.wildcardButton.Name = "wildcardButton";
            this.wildcardButton.Size = new System.Drawing.Size(102, 52);
            this.wildcardButton.TabIndex = 19;
            this.wildcardButton.Text = "&Wildcard";
            this.wildcardButton.UseVisualStyleBackColor = true;
            this.wildcardButton.Click += new System.EventHandler(this.wildcardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(266, 440);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 52);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.absoluteValueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(419, 504);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.wildcardButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumSquaredFileButton);
            this.Controls.Add(this.standardDevButton);
            this.Controls.Add(this.rangeButton);
            this.Controls.Add(this.squaresSumButton);
            this.Controls.Add(this.primeButton);
            this.Controls.Add(this.perimeterButton);
            this.Controls.Add(this.pythagoreanButton);
            this.Controls.Add(this.fibonacciButton);
            this.Controls.Add(this.factorialButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.fileSumButton);
            this.Controls.Add(this.reciprocalButton);
            this.Controls.Add(this.absoluteValueButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.startTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "arithmaticIsCool.org Project2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox endTextBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button absoluteValueButton;
        private System.Windows.Forms.Button reciprocalButton;
        private System.Windows.Forms.Button fileSumButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button fibonacciButton;
        private System.Windows.Forms.Button pythagoreanButton;
        private System.Windows.Forms.Button perimeterButton;
        private System.Windows.Forms.Button primeButton;
        private System.Windows.Forms.Button squaresSumButton;
        private System.Windows.Forms.Button rangeButton;
        private System.Windows.Forms.Button standardDevButton;
        private System.Windows.Forms.Button sumSquaredFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button wildcardButton;
        private System.Windows.Forms.Button exitButton;
    }
}

