namespace Tobin_4
{
    partial class OldTimePizzaParlorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldTimePizzaParlorForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickUpRadioButton = new System.Windows.Forms.RadioButton();
            this.dineInRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaySalesSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSalesSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.orderPriceLabel = new System.Windows.Forms.Label();
            this.largePizzaPriceLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.mediumPizzaPriceLabel = new System.Windows.Forms.Label();
            this.pizzaPriceLabel = new System.Windows.Forms.Label();
            this.smallPizzaPriceLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.toppingsListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pizzaCrustComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toppingsPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerInformationGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pizzaInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Time Pizza Parlor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Date:";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Location = new System.Drawing.Point(182, 19);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(73, 20);
            this.dateMaskedTextBox.TabIndex = 1;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "&Order Type:";
            // 
            // pickUpRadioButton
            // 
            this.pickUpRadioButton.AutoSize = true;
            this.pickUpRadioButton.Location = new System.Drawing.Point(312, 86);
            this.pickUpRadioButton.Name = "pickUpRadioButton";
            this.pickUpRadioButton.Size = new System.Drawing.Size(63, 17);
            this.pickUpRadioButton.TabIndex = 9;
            this.pickUpRadioButton.TabStop = true;
            this.pickUpRadioButton.Text = "Pick Up";
            this.pickUpRadioButton.UseVisualStyleBackColor = true;
            // 
            // dineInRadioButton
            // 
            this.dineInRadioButton.AutoSize = true;
            this.dineInRadioButton.Location = new System.Drawing.Point(381, 88);
            this.dineInRadioButton.Name = "dineInRadioButton";
            this.dineInRadioButton.Size = new System.Drawing.Size(59, 17);
            this.dineInRadioButton.TabIndex = 10;
            this.dineInRadioButton.TabStop = true;
            this.dineInRadioButton.Text = "Dine In";
            this.dineInRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "&First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Phone Number:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(98, 51);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(282, 51);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(119, 83);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(88, 20);
            this.phoneNumberMaskedTextBox.TabIndex = 7;
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.Controls.Add(this.label5);
            this.customerInformationGroupBox.Controls.Add(this.dineInRadioButton);
            this.customerInformationGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.pickUpRadioButton);
            this.customerInformationGroupBox.Controls.Add(this.label3);
            this.customerInformationGroupBox.Controls.Add(this.label4);
            this.customerInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.dateMaskedTextBox);
            this.customerInformationGroupBox.Controls.Add(this.label2);
            this.customerInformationGroupBox.Controls.Add(this.label6);
            this.customerInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.customerInformationGroupBox.Location = new System.Drawing.Point(12, 183);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(480, 113);
            this.customerInformationGroupBox.TabIndex = 1;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Customer Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printReceiptToolStripMenuItem,
            this.saveOrderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printReceiptToolStripMenuItem
            // 
            this.printReceiptToolStripMenuItem.Name = "printReceiptToolStripMenuItem";
            this.printReceiptToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.printReceiptToolStripMenuItem.Text = "&Print Receipt";
            this.printReceiptToolStripMenuItem.Click += new System.EventHandler(this.printReceiptToolStripMenuItem_Click);
            // 
            // saveOrderToolStripMenuItem
            // 
            this.saveOrderToolStripMenuItem.Name = "saveOrderToolStripMenuItem";
            this.saveOrderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saveOrderToolStripMenuItem.Text = "&Save Order";
            this.saveOrderToolStripMenuItem.Click += new System.EventHandler(this.saveOrderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displaySalesSummaryToolStripMenuItem,
            this.clearSalesSummaryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // displaySalesSummaryToolStripMenuItem
            // 
            this.displaySalesSummaryToolStripMenuItem.Name = "displaySalesSummaryToolStripMenuItem";
            this.displaySalesSummaryToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.displaySalesSummaryToolStripMenuItem.Text = "&Display Sales Summary";
            this.displaySalesSummaryToolStripMenuItem.Click += new System.EventHandler(this.displaySalesSummaryToolStripMenuItem_Click);
            // 
            // clearSalesSummaryToolStripMenuItem
            // 
            this.clearSalesSummaryToolStripMenuItem.Name = "clearSalesSummaryToolStripMenuItem";
            this.clearSalesSummaryToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.clearSalesSummaryToolStripMenuItem.Text = "&Clear Sales Summary";
            this.clearSalesSummaryToolStripMenuItem.Click += new System.EventHandler(this.clearSalesSummaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pizzaInformationGroupBox
            // 
            this.pizzaInformationGroupBox.Controls.Add(this.toppingsPriceLabel);
            this.pizzaInformationGroupBox.Controls.Add(this.label13);
            this.pizzaInformationGroupBox.Controls.Add(this.orderPriceLabel);
            this.pizzaInformationGroupBox.Controls.Add(this.largePizzaPriceLabel);
            this.pizzaInformationGroupBox.Controls.Add(this.salesTaxLabel);
            this.pizzaInformationGroupBox.Controls.Add(this.mediumPizzaPriceLabel);
            this.pizzaInformationGroupBox.Controls.Add(this.pizzaPriceLabel);
            this.pizzaInformationGroupBox.Controls.Add(this.smallPizzaPriceLabel);
            this.pizzaInformationGroupBox.Controls.Add(this.label12);
            this.pizzaInformationGroupBox.Controls.Add(this.largeRadioButton);
            this.pizzaInformationGroupBox.Controls.Add(this.label11);
            this.pizzaInformationGroupBox.Controls.Add(this.mediumRadioButton);
            this.pizzaInformationGroupBox.Controls.Add(this.label10);
            this.pizzaInformationGroupBox.Controls.Add(this.smallRadioButton);
            this.pizzaInformationGroupBox.Controls.Add(this.toppingsListBox);
            this.pizzaInformationGroupBox.Controls.Add(this.label9);
            this.pizzaInformationGroupBox.Controls.Add(this.pizzaCrustComboBox);
            this.pizzaInformationGroupBox.Controls.Add(this.label8);
            this.pizzaInformationGroupBox.Controls.Add(this.label7);
            this.pizzaInformationGroupBox.Location = new System.Drawing.Point(12, 302);
            this.pizzaInformationGroupBox.Name = "pizzaInformationGroupBox";
            this.pizzaInformationGroupBox.Size = new System.Drawing.Size(480, 199);
            this.pizzaInformationGroupBox.TabIndex = 3;
            this.pizzaInformationGroupBox.TabStop = false;
            this.pizzaInformationGroupBox.Text = "Pizza Information";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(62, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 2);
            this.label13.TabIndex = 17;
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderPriceLabel.Location = new System.Drawing.Point(75, 166);
            this.orderPriceLabel.Name = "orderPriceLabel";
            this.orderPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.orderPriceLabel.TabIndex = 16;
            this.orderPriceLabel.Text = "ORDER PRICE";
            this.orderPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // largePizzaPriceLabel
            // 
            this.largePizzaPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largePizzaPriceLabel.Location = new System.Drawing.Point(165, 80);
            this.largePizzaPriceLabel.Name = "largePizzaPriceLabel";
            this.largePizzaPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.largePizzaPriceLabel.TabIndex = 6;
            this.largePizzaPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesTaxLabel.Location = new System.Drawing.Point(75, 130);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(48, 17);
            this.salesTaxLabel.TabIndex = 14;
            this.salesTaxLabel.Text = "SALES TAX";
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mediumPizzaPriceLabel
            // 
            this.mediumPizzaPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediumPizzaPriceLabel.Location = new System.Drawing.Point(165, 52);
            this.mediumPizzaPriceLabel.Name = "mediumPizzaPriceLabel";
            this.mediumPizzaPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.mediumPizzaPriceLabel.TabIndex = 4;
            this.mediumPizzaPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pizzaPriceLabel
            // 
            this.pizzaPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pizzaPriceLabel.Location = new System.Drawing.Point(76, 107);
            this.pizzaPriceLabel.Name = "pizzaPriceLabel";
            this.pizzaPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.pizzaPriceLabel.TabIndex = 12;
            this.pizzaPriceLabel.Text = "PIZZA PRICE";
            this.pizzaPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // smallPizzaPriceLabel
            // 
            this.smallPizzaPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallPizzaPriceLabel.Location = new System.Drawing.Point(165, 23);
            this.smallPizzaPriceLabel.Name = "smallPizzaPriceLabel";
            this.smallPizzaPriceLabel.Size = new System.Drawing.Size(48, 17);
            this.smallPizzaPriceLabel.TabIndex = 2;
            this.smallPizzaPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Order Price:";
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(74, 80);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(85, 17);
            this.largeRadioButton.TabIndex = 5;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "radioButton3";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            this.largeRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Sales Tax:";
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(74, 52);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(85, 17);
            this.mediumRadioButton.TabIndex = 3;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "radioButton2";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Pizza Price:";
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(74, 23);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(85, 17);
            this.smallRadioButton.TabIndex = 1;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "radioButton1";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // toppingsListBox
            // 
            this.toppingsListBox.FormattingEnabled = true;
            this.toppingsListBox.Location = new System.Drawing.Point(347, 55);
            this.toppingsListBox.Name = "toppingsListBox";
            this.toppingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toppingsListBox.Size = new System.Drawing.Size(120, 134);
            this.toppingsListBox.Sorted = true;
            this.toppingsListBox.TabIndex = 10;
            this.toppingsListBox.SelectedIndexChanged += new System.EventHandler(this.toppingsListBox_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "&Toppings:";
            // 
            // pizzaCrustComboBox
            // 
            this.pizzaCrustComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaCrustComboBox.FormattingEnabled = true;
            this.pizzaCrustComboBox.Location = new System.Drawing.Point(347, 22);
            this.pizzaCrustComboBox.Name = "pizzaCrustComboBox";
            this.pizzaCrustComboBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaCrustComboBox.Sorted = true;
            this.pizzaCrustComboBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pizza &Crust:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pizza &Size:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // toppingsPriceLabel
            // 
            this.toppingsPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppingsPriceLabel.Location = new System.Drawing.Point(271, 72);
            this.toppingsPriceLabel.Name = "toppingsPriceLabel";
            this.toppingsPriceLabel.Size = new System.Drawing.Size(70, 17);
            this.toppingsPriceLabel.TabIndex = 18;
            // 
            // OldTimePizzaParlorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 512);
            this.Controls.Add(this.pizzaInformationGroupBox);
            this.Controls.Add(this.customerInformationGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OldTimePizzaParlorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Old Time Pizza Parlor";
            this.Load += new System.EventHandler(this.OldTimePizzaParlorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pizzaInformationGroupBox.ResumeLayout(false);
            this.pizzaInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton pickUpRadioButton;
        private System.Windows.Forms.RadioButton dineInRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.GroupBox customerInformationGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox pizzaInformationGroupBox;
        private System.Windows.Forms.ListBox toppingsListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox pizzaCrustComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem printReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaySalesSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSalesSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label pizzaPriceLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label orderPriceLabel;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label largePizzaPriceLabel;
        private System.Windows.Forms.Label mediumPizzaPriceLabel;
        private System.Windows.Forms.Label smallPizzaPriceLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label toppingsPriceLabel;
    }
}

