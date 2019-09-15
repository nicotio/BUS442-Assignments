namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label quantity_On_HandLabel;
            System.Windows.Forms.Label quantity_On_OrderLabel;
            System.Windows.Forms.Label product_Lead_TimeLabel;
            System.Windows.Forms.Label product_Reorder_LevelLabel;
            System.Windows.Forms.Label productLineLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label yTDPurchasesLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorRegionLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label classificationLabel;
            System.Windows.Forms.Label activeStatusLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label contactNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSourcedInUSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsSourcedInChinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalCostsAndSalesByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorProductDatabaseDataSet = new WindowsFormsApp1.VendorProductDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pRODUCTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripDropDownButton();
            this.productNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.quantity_On_HandTextBox = new System.Windows.Forms.TextBox();
            this.quantity_On_OrderTextBox = new System.Windows.Forms.TextBox();
            this.product_Lead_TimeTextBox = new System.Windows.Forms.TextBox();
            this.product_Reorder_LevelTextBox = new System.Windows.Forms.TextBox();
            this.productLineTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.yTDPurchasesTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calculateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPurchLabel = new System.Windows.Forms.Label();
            this.avgPurchLabel = new System.Windows.Forms.Label();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.vENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.activeStatusTextBox = new System.Windows.Forms.TextBox();
            this.classificationTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.vendorRegionTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pRODUCTTableAdapter = new WindowsFormsApp1.VendorProductDatabaseDataSetTableAdapters.PRODUCTTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.VendorProductDatabaseDataSetTableAdapters.TableAdapterManager();
            this.vENDORTableAdapter = new WindowsFormsApp1.VendorProductDatabaseDataSetTableAdapters.VENDORTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            vendorIDLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            quantity_On_HandLabel = new System.Windows.Forms.Label();
            quantity_On_OrderLabel = new System.Windows.Forms.Label();
            product_Lead_TimeLabel = new System.Windows.Forms.Label();
            product_Reorder_LevelLabel = new System.Windows.Forms.Label();
            productLineLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            yTDPurchasesLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorRegionLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            classificationLabel = new System.Windows.Forms.Label();
            activeStatusLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            contactNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).BeginInit();
            this.pRODUCTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(16, 79);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 2;
            productIDLabel.Text = "Product ID:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(16, 105);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 4;
            productNameLabel.Text = "Product Name:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(16, 131);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(58, 13);
            vendorIDLabel.TabIndex = 6;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(16, 157);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(96, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Product Unit Price:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(16, 183);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(71, 13);
            costLabel.TabIndex = 10;
            costLabel.Text = "Product Cost:";
            // 
            // quantity_On_HandLabel
            // 
            quantity_On_HandLabel.AutoSize = true;
            quantity_On_HandLabel.Location = new System.Drawing.Point(16, 209);
            quantity_On_HandLabel.Name = "quantity_On_HandLabel";
            quantity_On_HandLabel.Size = new System.Drawing.Size(95, 13);
            quantity_On_HandLabel.TabIndex = 12;
            quantity_On_HandLabel.Text = "Quantity-On-Hand:";
            // 
            // quantity_On_OrderLabel
            // 
            quantity_On_OrderLabel.AutoSize = true;
            quantity_On_OrderLabel.Location = new System.Drawing.Point(16, 235);
            quantity_On_OrderLabel.Name = "quantity_On_OrderLabel";
            quantity_On_OrderLabel.Size = new System.Drawing.Size(95, 13);
            quantity_On_OrderLabel.TabIndex = 14;
            quantity_On_OrderLabel.Text = "Quantity-On-Order:";
            // 
            // product_Lead_TimeLabel
            // 
            product_Lead_TimeLabel.AutoSize = true;
            product_Lead_TimeLabel.Location = new System.Drawing.Point(16, 261);
            product_Lead_TimeLabel.Name = "product_Lead_TimeLabel";
            product_Lead_TimeLabel.Size = new System.Drawing.Size(100, 13);
            product_Lead_TimeLabel.TabIndex = 16;
            product_Lead_TimeLabel.Text = "Product Lead-Time:";
            // 
            // product_Reorder_LevelLabel
            // 
            product_Reorder_LevelLabel.AutoSize = true;
            product_Reorder_LevelLabel.Location = new System.Drawing.Point(16, 287);
            product_Reorder_LevelLabel.Name = "product_Reorder_LevelLabel";
            product_Reorder_LevelLabel.Size = new System.Drawing.Size(117, 13);
            product_Reorder_LevelLabel.TabIndex = 18;
            product_Reorder_LevelLabel.Text = "Product Reorder Level:";
            // 
            // productLineLabel
            // 
            productLineLabel.AutoSize = true;
            productLineLabel.Location = new System.Drawing.Point(16, 313);
            productLineLabel.Name = "productLineLabel";
            productLineLabel.Size = new System.Drawing.Size(70, 13);
            productLineLabel.TabIndex = 20;
            productLineLabel.Text = "Product Line:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(16, 339);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(38, 13);
            brandLabel.TabIndex = 22;
            brandLabel.Text = "Brand:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(16, 365);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(63, 13);
            discountLabel.TabIndex = 24;
            discountLabel.Text = "Discount %:";
            // 
            // yTDPurchasesLabel
            // 
            yTDPurchasesLabel.AutoSize = true;
            yTDPurchasesLabel.Location = new System.Drawing.Point(16, 391);
            yTDPurchasesLabel.Name = "yTDPurchasesLabel";
            yTDPurchasesLabel.Size = new System.Drawing.Size(85, 13);
            yTDPurchasesLabel.TabIndex = 26;
            yTDPurchasesLabel.Text = "YTD Purchases:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(254, 85);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(75, 13);
            vendorNameLabel.TabIndex = 30;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorRegionLabel
            // 
            vendorRegionLabel.AutoSize = true;
            vendorRegionLabel.Location = new System.Drawing.Point(254, 111);
            vendorRegionLabel.Name = "vendorRegionLabel";
            vendorRegionLabel.Size = new System.Drawing.Size(81, 13);
            vendorRegionLabel.TabIndex = 32;
            vendorRegionLabel.Text = "Vendor Region:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(255, 134);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(107, 13);
            stateLabel.TabIndex = 34;
            stateLabel.Text = "State/Province Abbr:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(254, 163);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 36;
            cityLabel.Text = "City:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(254, 189);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 38;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(254, 215);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 40;
            countryLabel.Text = "Country:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(254, 241);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(76, 13);
            emailLabel.TabIndex = 42;
            emailLabel.Text = "Email Address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(254, 267);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 44;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(254, 293);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(90, 13);
            websiteLabel.TabIndex = 46;
            websiteLabel.Text = "Website Address:";
            // 
            // classificationLabel
            // 
            classificationLabel.AutoSize = true;
            classificationLabel.Location = new System.Drawing.Point(254, 319);
            classificationLabel.Name = "classificationLabel";
            classificationLabel.Size = new System.Drawing.Size(71, 13);
            classificationLabel.TabIndex = 48;
            classificationLabel.Text = "Classification:";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new System.Drawing.Point(254, 345);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new System.Drawing.Size(73, 13);
            activeStatusLabel.TabIndex = 50;
            activeStatusLabel.Text = "Active Status:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(254, 371);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 52;
            notesLabel.Text = "Notes:";
            // 
            // contactNameLabel
            // 
            contactNameLabel.AutoSize = true;
            contactNameLabel.Location = new System.Drawing.Point(254, 397);
            contactNameLabel.Name = "contactNameLabel";
            contactNameLabel.Size = new System.Drawing.Size(78, 13);
            contactNameLabel.TabIndex = 54;
            contactNameLabel.Text = "Contact Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsSourcedInUSAToolStripMenuItem,
            this.productsSourcedInChinaToolStripMenuItem,
            this.totalCostsAndSalesByProductToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.queriesToolStripMenuItem.Text = "Queries";
            // 
            // productsSourcedInUSAToolStripMenuItem
            // 
            this.productsSourcedInUSAToolStripMenuItem.Name = "productsSourcedInUSAToolStripMenuItem";
            this.productsSourcedInUSAToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.productsSourcedInUSAToolStripMenuItem.Text = "Products Sourced in USA";
            this.productsSourcedInUSAToolStripMenuItem.ToolTipText = "Displays products sourced in USA";
            this.productsSourcedInUSAToolStripMenuItem.Click += new System.EventHandler(this.productsSourcedInUSAToolStripMenuItem_Click);
            // 
            // productsSourcedInChinaToolStripMenuItem
            // 
            this.productsSourcedInChinaToolStripMenuItem.Name = "productsSourcedInChinaToolStripMenuItem";
            this.productsSourcedInChinaToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.productsSourcedInChinaToolStripMenuItem.Text = "Products Sourced in China";
            this.productsSourcedInChinaToolStripMenuItem.ToolTipText = "Displays products sourced in China";
            this.productsSourcedInChinaToolStripMenuItem.Click += new System.EventHandler(this.productsSourcedInChinaToolStripMenuItem_Click);
            // 
            // totalCostsAndSalesByProductToolStripMenuItem
            // 
            this.totalCostsAndSalesByProductToolStripMenuItem.Name = "totalCostsAndSalesByProductToolStripMenuItem";
            this.totalCostsAndSalesByProductToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.totalCostsAndSalesByProductToolStripMenuItem.Text = "Total Costs and Sales by Product";
            this.totalCostsAndSalesByProductToolStripMenuItem.ToolTipText = "Displays total costs and sales by product";
            this.totalCostsAndSalesByProductToolStripMenuItem.Click += new System.EventHandler(this.totalCostsAndSalesByProductToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pRODUCTBindingNavigator
            // 
            this.pRODUCTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUCTBindingNavigator.BindingSource = this.pRODUCTBindingSource;
            this.pRODUCTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUCTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUCTBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.pRODUCTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pRODUCTBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.toolStripButton8,
            this.searchTextBox,
            this.toolStripButton9,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripButton10});
            this.pRODUCTBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.pRODUCTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUCTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUCTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUCTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUCTBindingNavigator.Name = "pRODUCTBindingNavigator";
            this.pRODUCTBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pRODUCTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUCTBindingNavigator.Size = new System.Drawing.Size(803, 39);
            this.pRODUCTBindingNavigator.TabIndex = 1;
            this.pRODUCTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.vendorProductDatabaseDataSet;
            // 
            // vendorProductDatabaseDataSet
            // 
            this.vendorProductDatabaseDataSet.DataSetName = "VendorProductDatabaseDataSet";
            this.vendorProductDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // pRODUCTBindingNavigatorSaveItem
            // 
            this.pRODUCTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUCTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUCTBindingNavigatorSaveItem.Image")));
            this.pRODUCTBindingNavigatorSaveItem.Name = "pRODUCTBindingNavigatorSaveItem";
            this.pRODUCTBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.pRODUCTBindingNavigatorSaveItem.Text = "Save Data";
            this.pRODUCTBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUCTBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(52, 39);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton9.Text = "toolStripButton9";
            this.toolStripButton9.ToolTipText = "Search by product name";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 36);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(129, 15);
            this.toolStripLabel2.Text = "Filter by Product Name";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productNameToolStripMenuItem,
            this.productPriceToolStripMenuItem,
            this.productCostToolStripMenuItem,
            this.brandToolStripMenuItem});
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(45, 36);
            this.toolStripButton10.Text = "toolStripButton10";
            // 
            // productNameToolStripMenuItem
            // 
            this.productNameToolStripMenuItem.Name = "productNameToolStripMenuItem";
            this.productNameToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.productNameToolStripMenuItem.Text = "Product Name";
            this.productNameToolStripMenuItem.Click += new System.EventHandler(this.productNameToolStripMenuItem_Click);
            // 
            // productPriceToolStripMenuItem
            // 
            this.productPriceToolStripMenuItem.Name = "productPriceToolStripMenuItem";
            this.productPriceToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.productPriceToolStripMenuItem.Text = "Product Price";
            this.productPriceToolStripMenuItem.Click += new System.EventHandler(this.productPriceToolStripMenuItem_Click);
            // 
            // productCostToolStripMenuItem
            // 
            this.productCostToolStripMenuItem.Name = "productCostToolStripMenuItem";
            this.productCostToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.productCostToolStripMenuItem.Text = "Product Cost";
            this.productCostToolStripMenuItem.Click += new System.EventHandler(this.productCostToolStripMenuItem_Click);
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            this.brandToolStripMenuItem.Click += new System.EventHandler(this.brandToolStripMenuItem_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(139, 76);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.productIDTextBox.TabIndex = 3;
            this.productIDTextBox.Click += new System.EventHandler(this.productIDTextBox_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(139, 154);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.Click += new System.EventHandler(this.priceTextBox_Click);
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(139, 180);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 11;
            this.costTextBox.Click += new System.EventHandler(this.costTextBox_Click);
            // 
            // quantity_On_HandTextBox
            // 
            this.quantity_On_HandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Quantity_On_Hand", true));
            this.quantity_On_HandTextBox.Location = new System.Drawing.Point(139, 206);
            this.quantity_On_HandTextBox.Name = "quantity_On_HandTextBox";
            this.quantity_On_HandTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantity_On_HandTextBox.TabIndex = 13;
            this.quantity_On_HandTextBox.Click += new System.EventHandler(this.quantity_On_HandTextBox_Click);
            // 
            // quantity_On_OrderTextBox
            // 
            this.quantity_On_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Quantity_On_Order", true));
            this.quantity_On_OrderTextBox.Location = new System.Drawing.Point(139, 232);
            this.quantity_On_OrderTextBox.Name = "quantity_On_OrderTextBox";
            this.quantity_On_OrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantity_On_OrderTextBox.TabIndex = 15;
            this.quantity_On_OrderTextBox.Click += new System.EventHandler(this.quantity_On_OrderTextBox_Click);
            // 
            // product_Lead_TimeTextBox
            // 
            this.product_Lead_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Product_Lead_Time", true));
            this.product_Lead_TimeTextBox.Location = new System.Drawing.Point(139, 258);
            this.product_Lead_TimeTextBox.Name = "product_Lead_TimeTextBox";
            this.product_Lead_TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_Lead_TimeTextBox.TabIndex = 17;
            this.product_Lead_TimeTextBox.Click += new System.EventHandler(this.product_Lead_TimeTextBox_Click);
            // 
            // product_Reorder_LevelTextBox
            // 
            this.product_Reorder_LevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Product_Reorder_Level", true));
            this.product_Reorder_LevelTextBox.Location = new System.Drawing.Point(139, 284);
            this.product_Reorder_LevelTextBox.Name = "product_Reorder_LevelTextBox";
            this.product_Reorder_LevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_Reorder_LevelTextBox.TabIndex = 19;
            this.product_Reorder_LevelTextBox.Click += new System.EventHandler(this.product_Reorder_LevelTextBox_Click);
            // 
            // productLineTextBox
            // 
            this.productLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "ProductLine", true));
            this.productLineTextBox.Location = new System.Drawing.Point(139, 310);
            this.productLineTextBox.Name = "productLineTextBox";
            this.productLineTextBox.Size = new System.Drawing.Size(100, 20);
            this.productLineTextBox.TabIndex = 21;
            this.productLineTextBox.Click += new System.EventHandler(this.productLineTextBox_Click);
            // 
            // brandTextBox
            // 
            this.brandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Brand", true));
            this.brandTextBox.Location = new System.Drawing.Point(139, 336);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(100, 20);
            this.brandTextBox.TabIndex = 23;
            this.brandTextBox.Click += new System.EventHandler(this.brandTextBox_Click);
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(139, 362);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 25;
            this.discountTextBox.Click += new System.EventHandler(this.discountTextBox_Click);
            // 
            // yTDPurchasesTextBox
            // 
            this.yTDPurchasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "YTDPurchases", true));
            this.yTDPurchasesTextBox.Location = new System.Drawing.Point(139, 388);
            this.yTDPurchasesTextBox.Name = "yTDPurchasesTextBox";
            this.yTDPurchasesTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTDPurchasesTextBox.TabIndex = 27;
            this.yTDPurchasesTextBox.Click += new System.EventHandler(this.yTDPurchasesTextBox_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(485, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(278, 341);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Purchase Amount";
            this.columnHeader2.Width = 118;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(19, 441);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(92, 35);
            this.calculateButton.TabIndex = 57;
            this.calculateButton.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Displays products in purchases list box");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(117, 441);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(92, 35);
            this.refreshButton.TabIndex = 58;
            this.refreshButton.Text = "&Refresh";
            this.toolTip1.SetToolTip(this.refreshButton, "Refreshes application");
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(215, 441);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 35);
            this.exitButton.TabIndex = 59;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Exits application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "YTD total purchases:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "YTD average purchases:";
            // 
            // totalPurchLabel
            // 
            this.totalPurchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPurchLabel.Location = new System.Drawing.Point(641, 422);
            this.totalPurchLabel.Name = "totalPurchLabel";
            this.totalPurchLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPurchLabel.TabIndex = 62;
            // 
            // avgPurchLabel
            // 
            this.avgPurchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgPurchLabel.Location = new System.Drawing.Point(641, 451);
            this.avgPurchLabel.Name = "avgPurchLabel";
            this.avgPurchLabel.Size = new System.Drawing.Size(100, 23);
            this.avgPurchLabel.TabIndex = 63;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "ContactName", true));
            this.contactNameTextBox.Enabled = false;
            this.contactNameTextBox.Location = new System.Drawing.Point(368, 391);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNameTextBox.TabIndex = 55;
            // 
            // vENDORBindingSource
            // 
            this.vENDORBindingSource.DataMember = "VENDOR";
            this.vENDORBindingSource.DataSource = this.vendorProductDatabaseDataSet;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Notes", true));
            this.notesTextBox.Enabled = false;
            this.notesTextBox.Location = new System.Drawing.Point(368, 365);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(100, 20);
            this.notesTextBox.TabIndex = 53;
            // 
            // activeStatusTextBox
            // 
            this.activeStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "ActiveStatus", true));
            this.activeStatusTextBox.Enabled = false;
            this.activeStatusTextBox.Location = new System.Drawing.Point(368, 339);
            this.activeStatusTextBox.Name = "activeStatusTextBox";
            this.activeStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.activeStatusTextBox.TabIndex = 51;
            // 
            // classificationTextBox
            // 
            this.classificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Classification", true));
            this.classificationTextBox.Enabled = false;
            this.classificationTextBox.Location = new System.Drawing.Point(368, 313);
            this.classificationTextBox.Name = "classificationTextBox";
            this.classificationTextBox.Size = new System.Drawing.Size(100, 20);
            this.classificationTextBox.TabIndex = 49;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Website", true));
            this.websiteTextBox.Enabled = false;
            this.websiteTextBox.Location = new System.Drawing.Point(368, 287);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.websiteTextBox.TabIndex = 47;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Enabled = false;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(368, 261);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 45;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Email", true));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(368, 235);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 43;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "Country", true));
            this.countryTextBox.Enabled = false;
            this.countryTextBox.Location = new System.Drawing.Point(368, 209);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 41;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Enabled = false;
            this.postalCodeTextBox.Location = new System.Drawing.Point(368, 183);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTextBox.TabIndex = 39;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "City", true));
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Location = new System.Drawing.Point(368, 157);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 37;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "State", true));
            this.stateTextBox.Enabled = false;
            this.stateTextBox.Location = new System.Drawing.Point(368, 131);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 35;
            // 
            // vendorRegionTextBox
            // 
            this.vendorRegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "VendorRegion", true));
            this.vendorRegionTextBox.Enabled = false;
            this.vendorRegionTextBox.Location = new System.Drawing.Point(368, 105);
            this.vendorRegionTextBox.Name = "vendorRegionTextBox";
            this.vendorRegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorRegionTextBox.TabIndex = 33;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDORBindingSource, "VendorName", true));
            this.vendorNameTextBox.Enabled = false;
            this.vendorNameTextBox.Location = new System.Drawing.Point(368, 79);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vendorNameTextBox.TabIndex = 31;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PRODUCTTableAdapter = this.pRODUCTTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.VendorProductDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDORTableAdapter = this.vENDORTableAdapter;
            // 
            // vENDORTableAdapter
            // 
            this.vENDORTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTBindingSource, "VendorID", true));
            this.comboBox1.DataSource = this.vENDORBindingSource;
            this.comboBox1.DisplayMember = "VendorID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 64;
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DataSource = this.pRODUCTBindingSource;
            this.productNameComboBox.DisplayMember = "ProductName";
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(139, 100);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(100, 21);
            this.productNameComboBox.TabIndex = 65;
            this.productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(803, 511);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.avgPurchLabel);
            this.Controls.Add(this.totalPurchLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorRegionLabel);
            this.Controls.Add(this.vendorRegionTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(this.websiteTextBox);
            this.Controls.Add(classificationLabel);
            this.Controls.Add(this.classificationTextBox);
            this.Controls.Add(activeStatusLabel);
            this.Controls.Add(this.activeStatusTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(contactNameLabel);
            this.Controls.Add(this.contactNameTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(quantity_On_HandLabel);
            this.Controls.Add(this.quantity_On_HandTextBox);
            this.Controls.Add(quantity_On_OrderLabel);
            this.Controls.Add(this.quantity_On_OrderTextBox);
            this.Controls.Add(product_Lead_TimeLabel);
            this.Controls.Add(this.product_Lead_TimeTextBox);
            this.Controls.Add(product_Reorder_LevelLabel);
            this.Controls.Add(this.product_Reorder_LevelTextBox);
            this.Controls.Add(productLineLabel);
            this.Controls.Add(this.productLineTextBox);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(yTDPurchasesLabel);
            this.Controls.Add(this.yTDPurchasesTextBox);
            this.Controls.Add(this.pRODUCTBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Vendor and Product Database App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingNavigator)).EndInit();
            this.pRODUCTBindingNavigator.ResumeLayout(false);
            this.pRODUCTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorProductDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private VendorProductDatabaseDataSet vendorProductDatabaseDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private VendorProductDatabaseDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private VendorProductDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pRODUCTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pRODUCTBindingNavigatorSaveItem;
        private VendorProductDatabaseDataSetTableAdapters.VENDORTableAdapter vENDORTableAdapter;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox quantity_On_HandTextBox;
        private System.Windows.Forms.TextBox quantity_On_OrderTextBox;
        private System.Windows.Forms.TextBox product_Lead_TimeTextBox;
        private System.Windows.Forms.TextBox product_Reorder_LevelTextBox;
        private System.Windows.Forms.TextBox productLineTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox yTDPurchasesTextBox;
        private System.Windows.Forms.BindingSource vENDORBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalPurchLabel;
        private System.Windows.Forms.Label avgPurchLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox activeStatusTextBox;
        private System.Windows.Forms.TextBox classificationTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox vendorRegionTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.ToolStripMenuItem productsSourcedInUSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsSourcedInChinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalCostsAndSalesByProductToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton10;
        private System.Windows.Forms.ToolStripMenuItem productNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
    }
}

