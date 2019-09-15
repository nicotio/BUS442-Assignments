/* App Developer: Nico Tio
 * App Purpose: App prototype to calculate a loan amortization schedule for use by car dealerships, in collaboration with a (hypothetical) automotive industry.
 * App Name: Vehicle Loan Calculator 
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLoanCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Declare fields
        double totalInterest = 0, totalLoans = 0, totalPrincipal = 0, finalTotalInterest = 0, finalTotalLoans = 0;


        private void exitButton_Click(object sender, EventArgs e)
        {
            //Confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If answer is yes, close the app
            if (dialog == DialogResult.Yes)
            Application.Exit();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Clear Loan ListBox
            loanListBox.Items.Clear();
            totalInterestLabel.Text = null;
            totalLoanLabel.Text = null;

            // Format for ListBox Output
            string formatString = "{0,5}{1,15}{2,15}{3,15}{4,15}";
            string formatFinalString = "{0,5}{1,15}{2,15}{3,15}";

            //Declare Variables
            double loan = 0, rebate = 0, principalPayment = 0, interest = 0, pmt = 0, rate = 0, pmtSolver = 0, interestMonthly=0 ;
            int monthsCounter = 6;
            totalInterest = 0;
            totalLoans = 0;  
            totalPrincipal = 0;

            //Grab User Inputs
            try
            {
                double.TryParse(loanTextBox.Text, out loan);
                rate = Convert.ToDouble(annualAPRComboBox.Text);
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //Rate to decimals
            rate = rate / 100;

            // Show error for invalid loan
            if (loan  == 0)
            {
                MessageBox.Show("Please a loan amount", "Error Message",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                loanTextBox.Focus();
            }

            // Loan is valid
            else
            { 
            
            // Take Rebate out of loan
            if (rebateCheckBox.Checked == true)
            double.TryParse(rebateTextBox.Text, out rebate);
            loan = loan - rebate;

            
            // Check the monthly
            if (sixRadioButton.Checked)
                monthsCounter = 6;
            else if (twelveRadioButton.Checked)
                monthsCounter = 12;
            else if (eighteenRadioButton.Checked)
                monthsCounter = 18;
            else if (twentyFourRadioButton.Checked)
                monthsCounter = 24;


            // Set interest for 1st Month
            interest = loan * rate / 12;

            // Set monthly interest rate 
            interestMonthly = rate / 12;

            // PMT solver for monthly payment
            pmtSolver = (1-Math.Pow((1 + interestMonthly), -monthsCounter))/interestMonthly;

            // Monthly Payment
            pmt = loan / pmtSolver;

            
            // Fill in Loan ListBox
                for(int counter = 1; counter <= monthsCounter;  counter++)
                {
                    // Calculate Principal Amount Paid
                    principalPayment = pmt - interest;

                    // Recalculate New Loan for new period (Loan - Monthly Payment + Interest)
                    loan = loan - pmt + (loan * interestMonthly);

                    // Add Loan to ListBox
                    loanListBox.Items.Add(string.Format(formatString, counter, interest.ToString("C2"), principalPayment.ToString("C2"), pmt.ToString("C2"), loan.ToString("C2")));

                    // Track Total Principal, Total Interest, and Total Loan when displaying Loan
                    totalPrincipal += principalPayment;
                    totalInterest += interest;
                    totalLoans += pmt;

                    // Recalculate New Interest after new Loan
                    interest = loan * interestMonthly;

                    // Add to counter (*Actual Month) and decrease monthsCounter
                  

                }

                //Add Space and add Total Interest, Principal and Loans
                loanListBox.Items.Add("");
                loanListBox.Items.Add(string.Format(formatFinalString, "Total", totalInterest.ToString("C2"), totalPrincipal.ToString("C2"), totalLoans.ToString("C2")));
            }

           
            



        }

        private void loanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prevent users to key in incorrect value

            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.' && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

        }


        private void rebateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Rebate checkbox enable rebate textbox.
            if (rebateCheckBox.Checked == true)
                rebateTextBox.Enabled = true;
            else
                rebateTextBox.Enabled = false;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            // Reset and Clear
            finalTotalInterest = totalInterest;
            finalTotalLoans = totalLoans;
            loanListBox.Items.Clear();
            loanTextBox.Text = null;
            rebateTextBox.Text = null;
            annualAPRComboBox.SelectionStart = annualAPRComboBox.Text.Length;
            sixRadioButton.Checked = true;
            rebateCheckBox.Checked = false;
        }

        //Reset fields when user change loan amount
        private void loanTextBox_TextChanged(object sender, EventArgs e)
        {
            loanListBox.Items.Clear();
            totalInterestLabel.Text = null;
            totalLoanLabel.Text = null;
        }

        //Select all when user click
        private void loanTextBox_Click(object sender, EventArgs e)
        {
            loanTextBox.SelectAll();
        }

        //Display Total Interest and Total Loan
        private void displayLoanButton_Click(object sender, EventArgs e)
        {
            totalInterestLabel.Text = finalTotalInterest.ToString("C2");
            totalLoanLabel.Text = finalTotalLoans.ToString("C2");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populate ComboBox
            double populate = .25;
            while (populate < 30)
            {
                annualAPRComboBox.Items.Add(populate);
                populate += .25;
            }

            annualAPRComboBox.SelectedIndex = 6;
        }
    }
}
