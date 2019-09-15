//Names: Aby Duquette, Mia Freeland, Nico Tio
//Date: Dec 6, 2018
//Purpose: Track Vendors & Products

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pRODUCTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUCTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vendorProductDatabaseDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Loads data into the 'vendorProductDatabaseDataSet.VENDOR' table. You can move, or remove it, as needed.
            this.vENDORTableAdapter.Fill(this.vendorProductDatabaseDataSet.VENDOR);
            // Loads data into the 'vendorProductDatabaseDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.vendorProductDatabaseDataSet.PRODUCT);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // ask for confirmation to quit app
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text, MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);
            // if the answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ask for confirmation to quit app
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text, MessageBoxButtons.YesNo,
           MessageBoxIcon.Warning);
            // if the answer is yes, close the app
            if (dialog == DialogResult.Yes)
                this.Close();
        }
        
        //independent method to display into the listView
        private void displayInListView()
        {
            string productName, YTDPurchases;

            foreach (DataRow dr in vendorProductDatabaseDataSet.PRODUCT.Rows)
            {
                productName = dr["ProductName"].ToString();
                YTDPurchases = dr["YTDPurchases"].ToString();
               
                string[] fieldsArray = new string[2];
                fieldsArray[0] = productName;
                fieldsArray[1] = YTDPurchases;

                ListViewItem showsLVI = new ListViewItem(fieldsArray);
                listView1.Items.Add(showsLVI);
            }

        }

        private void clearAll()
        {
            listView1.Items.Clear();
        }

        //Calculate Purchase Total
        private void calculateButton_Click(object sender, EventArgs e)
        {
            clearAll();
            double purchasesTotal = 0, purchaseAmount = 0, averagePurchase;
            int count = 0;
            
            foreach (DataRow dr in vendorProductDatabaseDataSet.PRODUCT.Rows)
            {
                purchaseAmount = double.Parse(dr["YTDPurchases"].ToString());
                purchasesTotal += purchaseAmount;
                count++;
            }
            totalPurchLabel.Text = purchasesTotal.ToString();

            averagePurchase = purchasesTotal / count;
            avgPurchLabel.Text = averagePurchase.ToString();
            
            displayInListView();

        }

        private void productsSourcedInUSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();

            this.pRODUCTTableAdapter.GetFillUSA(this.vendorProductDatabaseDataSet.PRODUCT);

            displayInListView();
        }

        private void productsSourcedInChinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();

            this.pRODUCTTableAdapter.GetFillCHN(this.vendorProductDatabaseDataSet.PRODUCT);
            displayInListView();
        }

        private void totalCostsAndSalesByProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();
            this.pRODUCTTableAdapter.GetFillTotalCostandSales(this.vendorProductDatabaseDataSet.PRODUCT);
            displayInListView();
        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {

            //Search Item

            try
            {
                calculateButton.Enabled = false;

                listView1.Items.Clear();

                pRODUCTBindingSource.Filter = "ProductName LIKE " + "'" + searchTextBox.Text + "*'";

                if (pRODUCTBindingSource.Count == 0)

                {
                    MessageBox.Show("Search not found.", "Error Message",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    searchTextBox.Focus();
                }
            }



            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                searchTextBox.SelectAll();

            }

        

         
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            calculateButton.Enabled = true;
            pRODUCTBindingSource.Filter = null;
        }

        private void productIDTextBox_Click(object sender, EventArgs e)
        {
            productIDTextBox.SelectAll();
        }

        private void priceTextBox_Click(object sender, EventArgs e)
        {
            priceTextBox.SelectAll();
        }

        private void costTextBox_Click(object sender, EventArgs e)
        {
            costTextBox.SelectAll();
        }

        private void quantity_On_HandTextBox_Click(object sender, EventArgs e)
        {
            quantity_On_HandTextBox.SelectAll();
        }

        private void quantity_On_OrderTextBox_Click(object sender, EventArgs e)
        {
            quantity_On_OrderTextBox.SelectAll();
        }

        private void product_Lead_TimeTextBox_Click(object sender, EventArgs e)
        {
            product_Lead_TimeTextBox.SelectAll();
        }

        private void product_Reorder_LevelTextBox_Click(object sender, EventArgs e)
        {
            product_Reorder_LevelTextBox.SelectAll();
        }

        private void productLineTextBox_Click(object sender, EventArgs e)
        {
            productLineTextBox.SelectAll();
        }

        private void brandTextBox_Click(object sender, EventArgs e)
        {
            brandTextBox.SelectAll();
        }

        private void discountTextBox_Click(object sender, EventArgs e)
        {
            discountTextBox.SelectAll();
        }

        private void yTDPurchasesTextBox_Click(object sender, EventArgs e)
        {
            yTDPurchasesTextBox.SelectAll();
        }

        private void productNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();

            this.pRODUCTTableAdapter.FillByProductName(this.vendorProductDatabaseDataSet.PRODUCT);

            displayInListView();
        }

        private void productPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();

            this.pRODUCTTableAdapter.FillByPrice(this.vendorProductDatabaseDataSet.PRODUCT);

            displayInListView();
        }

        private void productCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();

            this.pRODUCTTableAdapter.FillByCost(this.vendorProductDatabaseDataSet.PRODUCT);

            displayInListView();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();

            this.pRODUCTTableAdapter.FillByBrand(this.vendorProductDatabaseDataSet.PRODUCT);

            displayInListView();
        }
    }
}
