//Names: Nico Tio and Mia Freeland
//Name of App: arithmaticIsCool.org Project 2
//Purpose of App: Create a super calculator
//Date: 9/15/18

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PairProgrammingProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int startNumber = 0, endNumber = 0;
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit Confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
                Application.Exit(); //closes the app immediately. In contrast, .Close closes the application 
        }

        private void startTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallow any user input in the textbox except numbers, the period sybol, and the backspace symbol.

            //This event handler only allows digits, control characters, and the period.
            //The symbol ! means "not"; the symbols && means "and".
            //used following link: https://stackoverflow.com/questions/13158226/allow-only-numbers-and-negative-values
            if ((!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != '-')))
                e.Handled = true;
        }

        private void endTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallow any user input in the textbox except numbers, the period sybol, and the backspace symbol.

            //This event handler only allows digits, control characters, and the period.
            //The symbol ! means "not"; the symbols && means "and".
            //used following link: https://stackoverflow.com/questions/13158226/allow-only-numbers-and-negative-values
            if ((!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && (e.KeyChar != '-')))
                e.Handled = true;
        }

        private void startTextBox_TextChanged(object sender, EventArgs e)
        {
            resultListBox.Items.Clear(); //clears out listBox
        }

        private void endTextBox_TextChanged(object sender, EventArgs e)
        {
            resultListBox.Items.Clear(); //clears out listBox
        }

        private void startTextBox_Click(object sender, EventArgs e)
        {
            startTextBox.SelectAll();
        }

        private void endTextBox_Click(object sender, EventArgs e)
        {
            endTextBox.SelectAll();
        }

        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            //Clear List Box
            resultListBox.Items.Clear();

            //Declare variable
            double reciprocal = 0;

            //Parse user inputs
            int.TryParse(startTextBox.Text, out startNumber);

            //Calculate

            if (startNumber ==  0)
            {
                MessageBox.Show("Cannot divide be 0", "Error Message",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                startTextBox.Focus();
            }

            else
            {

                reciprocal = 1 / (double)startNumber;

                //Display on listbox
                resultListBox.Items.Add("Reciprocal of value " + startNumber + ": " + reciprocal);

            }

        }

        private void fileSumButton_Click(object sender, EventArgs e)
        {
            string currentLines;
            string[] fields;
            double result = 0;

            StreamReader numberReader = new StreamReader("Numbers.csv");


            resultListBox.Items.Clear();

            while(numberReader.EndOfStream == false)
            {
                
                currentLines = numberReader.ReadLine();

                fields = currentLines.Split(',');
   

                result += (double.Parse(fields[0]) + double.Parse(fields[1]) + double.Parse(fields[2]) 
                    + double.Parse(fields[3]) + double.Parse(fields[4]));



            }

            resultListBox.Items.Add("Sum of file numbers is: " + result);

            numberReader.Close();
            
        }


        private void multiplyButton_Click(object sender, EventArgs e)
        {
            //Clear listBox
            resultListBox.Items.Clear();

            // Declare variable
            double product = 0;

            //Parse user inputs
            int.TryParse(startTextBox.Text, out startNumber);

            if ((startNumber <= 0) || (startNumber > 12))
            {
                MessageBox.Show("Start number must be between range of 1 and 12", "Error Message",
                                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //Calculate multiplication table
            //run loop
            if (startNumber >= 1 && startNumber <= 12)
            {


                for (int number = 1; number <= 12; number++)
                {
                    product = number * startNumber;

                    resultListBox.Items.Add(number + " * " + startNumber + " = " + product);
                }

            }


        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            //Clear List Box
            resultListBox.Items.Clear();

            // Deckare variables
            double perimeter = 0;

            // Parse user inputs
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            //Check if start number greater than end number and prevent 0
            if (startNumber > endNumber || startNumber <= 0 || endNumber <= 0)
            {
                MessageBox.Show("Enter number greater than 0 and start number must be less than end number.", "Error Message",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                startTextBox.Focus();
            }

            else
            {
                //Calculate perimeter
                perimeter = (startNumber + endNumber) * 2;
                resultListBox.Items.Add("Rectangle perimeter: width = " + startNumber +
                    "; length = " + endNumber + ": " + perimeter);
            }

        }

        private void rangeButton1_Click(object sender, EventArgs e)
        {
            string currentLines;
            string[] fields;
            double big = -99999, small=999999;

            StreamReader numberReader = new StreamReader("Numbers.txt");


            resultListBox.Items.Clear();

            while (numberReader.EndOfStream == false)
            {

                currentLines = numberReader.ReadLine();

                fields = currentLines.Split(',');

                for (int i = 0; i <= 4; i++)
                {



                    if (double.Parse(fields[i]) > big)
                    {
                        big = double.Parse(fields[i]);
                    }

                    else if (double.Parse(fields[i]) < small)
                    {
                        small = double.Parse(fields[i]);
                    }

                    else
                    {
                        
                    }

                }


            }

            double result = Math.Abs(big - small);
            resultListBox.Items.Add("Range of values between " + big + " and " + small + ": " + result);

            numberReader.Close();

            startTextBox.Focus();
            
            }

        private void pythagoreanButton_Click(object sender, EventArgs e)
        {
            //Clear List Box
            resultListBox.Items.Clear();

            // Declare variables
            var a = "a²"; // one way… or
            var b = "b\xB2"; // another way, typing the unicode character for square.
            var c = "c\xB2";
            double aSide = 0, bSide = 0, cSide = 0;
            double sum, sqrt;

            // Parse user inputs
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            if (startNumber <= 0 || endNumber <= 0)
            {
                MessageBox.Show("Enter number greater than 0", "Error Message",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                startTextBox.Focus();
            }

            else
            {
                aSide = startNumber;
                bSide = endNumber;

                //Calculate pythagorean theorm
                aSide = aSide * aSide;
                bSide = bSide * bSide;
                sum = aSide + bSide;

                cSide = aSide + bSide;
                sqrt = Math.Sqrt(cSide);

                resultListBox.Items.Add(a + " + " + b + " = " + c);
                resultListBox.Items.Add(aSide + " + " + bSide + " = " + c);
                resultListBox.Items.Add(sum.ToString("N2") + " = " + c);
                resultListBox.Items.Add(sqrt.ToString("N2") + " = c");
            }

        }

        private void standardDevButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultListBox.Items.Clear();

            //Retrieves the data from the textboxes
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            //Declaring two new variables
            double start, finish;

            //checks if both the start number and the end number are zero
            if ((startNumber == 0) && (endNumber == 0))
            {
                MessageBox.Show("Both start number and end number cannot be zero", "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // If the start number is greater than the endnumber, it flips the variable
                if (startNumber > endNumber)
                {
                    start = endNumber;
                    finish = startNumber;

                }
                else
                {
                    start = startNumber;
                    finish = endNumber;
                }
                //create sample size variable
                double n = finish - start;

                //Finding the average of the range of values
                double average = (start + finish) / (float)2.0;

                //Declaring new variables for the for loop
                double error;
                double errorTotal = 0;

                //Calculates the error for each sample and totals it up.
                for (double counter = start; counter <= finish; counter++)
                {
                    error = counter - (double)average;
                    errorTotal = errorTotal + Math.Pow(error, 2);
                }
                //Find the mean square error
                double meansquare = errorTotal / n;

                //square roots the MSE to find the std
                double std = Math.Sqrt(meansquare);

                //Displays it into the listbox
                resultListBox.Items.Add("Standard deviation for range " + start + " to " + finish + ": " + std.ToString("N6"));

                startTextBox.Focus();
            }
        }

        private void primeButton_Click(object sender, EventArgs e)
        {
            //Clear listBox
            resultListBox.Items.Clear();

            //Declare variables
            double counter;

            // Parse user inputs
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            if (startNumber > endNumber || startNumber <= 0 || endNumber <= 0 || startNumber > 500 || endNumber > 500)
            {
                MessageBox.Show("Start number cannot be greater than end number, number must be greater than 0 and less than 0", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                for (counter = startNumber; counter <= endNumber; counter++)
                {
                    bool isPrime = true;
                    for (double i = 2; i < counter; i++)
                    {
                        if (isPrime == false)
                        {
                            break;
                        }
                        else if ((counter % i) == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime == true)
                    {
                        resultListBox.Items.Add(counter + " is a prime number");
                    }
                    else
                    {
                        resultListBox.Items.Add(counter + " is not a prime number");
                    }
                }
            }
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            //Clear the listBox
            resultListBox.Items.Clear();
            
            //Parse data
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            int factorial = startNumber;
        


            if (startNumber < 0 || startNumber > 10 || startTextBox.Text.Trim() == string.Empty || endTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Start number cannot be less than 0 or greater than 10.", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //loop all values that are less than or equal to the startnumber
                for (int i = 1; i < startNumber; i++)
                {
                    //accumulates the total product
                    factorial = factorial * i;
                }
                //display results in listBox
                resultListBox.Items.Add(startNumber + "!" + "= " + factorial);

                //sets the focus to startTextBox
                startTextBox.Focus();
            }
        }

        private void fibonacciButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultListBox.Items.Clear();

            //Retrieves the data from the textboxes
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            //Check if the inputed values are between 0 and 30
            if ((startNumber <= 0) || (startNumber > 30))
            {
                MessageBox.Show("Start number must be between range of 1 and 30", "Error Message",
                                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {


                //Declare array 
                double[] fibonacci = new double[30];

                //Set value of first two index
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                //Adds the two numbers before [i] index
                for (int i = 2; i < startNumber; i++)
                {
                    //Index i is equal to the two previous index addded together
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                //Display in listBox
                resultListBox.Items.Add("Fibonacci sequence for " + startNumber);

                //Display every values in the array 
                for (int i = 0; i < startNumber; i++)
                {
                    resultListBox.Items.Add(fibonacci[i]);
                }

            }
            }

        private void squaresSumButton_Click(object sender, EventArgs e)
        {
            //display variables
            double squared1, squared2, numbersum, squaresum;
            
            //Clears the listbox
            resultListBox.Items.Clear();

            //Retrieves the data from the textboxes
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            //calculate sum of squares
            numbersum = startNumber + endNumber;
            squared1 = startNumber * startNumber;
            squared2 = endNumber * endNumber;
            squaresum = squared1 + squared2;

            resultListBox.Items.Add("The number is: " + startNumber + " and its square is: " + squared1);
            resultListBox.Items.Add("The number is: " + endNumber + " and its square is: " + squared2);
            resultListBox.Items.Add(" ");
            resultListBox.Items.Add("Sum of numbers: " + numbersum + " Sum of squares: " + squaresum);
            
        }

        private void wildcardButton_Click(object sender, EventArgs e)
        {
            //Clear the listBox
            resultListBox.Items.Clear();


            //Parse data
            int.TryParse(startTextBox.Text, out startNumber);
            int.TryParse(endTextBox.Text, out endNumber);

            if (startNumber <= 0 || endNumber <= 0)
            {
                MessageBox.Show("Enter number greater than 0.", "Error Message",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                startTextBox.Focus();
            }

            else
            {

                //declareing new variable
                double result = startNumber * endNumber / 2;
                resultListBox.Items.Add("Area of isosceles triangle with base " + startNumber + " and height " + endNumber + " = " + result);

            }
            }

        private void sumSquaredFileButton_Click(object sender, EventArgs e)
        {
            string currentLines;
            string[] fields;
            double result = 0;

            StreamReader numberReader = new StreamReader("Numbers.csv");


            resultListBox.Items.Clear();

            while (numberReader.EndOfStream == false)
            {

                currentLines = numberReader.ReadLine();

                fields = currentLines.Split(',');


                result += (Math.Pow(double.Parse(fields[0]), 2) + (Math.Pow(double.Parse(fields[1]), 2) + (Math.Pow(double.Parse(fields[2]), 2))
                    + (Math.Pow(double.Parse(fields[3]), 2) + (Math.Pow(double.Parse(fields[4]), 2)))));



            }

            resultListBox.Items.Add("Sum of squared values: " + result.ToString("N0"));

            numberReader.Close();
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void absoluteValueButton_Click(object sender, EventArgs e)
            {
                //Clear List Box
                resultListBox.Items.Clear();

                // Deckare variables
                double startAbs = 0, endAbs = 0;

                // Parse user inputs
                int.TryParse(startTextBox.Text, out startNumber);
                int.TryParse(endTextBox.Text, out endNumber);

            if (startNumber == 0 || endNumber == 0)
            {
                MessageBox.Show("Enter number greater than 0", "Error Message",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                startTextBox.Focus();
            }

            else
            {

                //Calculate abs value
                startAbs = Math.Abs(startNumber);
                endAbs = Math.Abs(endNumber);

                //Display on listbox
                resultListBox.Items.Add("The absolute value of " + startNumber + ": " + startAbs + ".");
                resultListBox.Items.Add("The absolute value of " + endNumber + ": " + endAbs + ".");

            }

            }
        }
    } 
