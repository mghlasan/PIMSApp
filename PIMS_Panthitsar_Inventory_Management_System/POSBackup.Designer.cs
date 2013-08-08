namespace PIMS_Panthitsar_Inventory_Management_System
{
    partial class POSBackup
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
            this.labelPOSReceiptNo = new System.Windows.Forms.Label();
            this.buttonPOSSubmit = new System.Windows.Forms.Button();
            this.groupBoxPOSCPaymentInfo = new System.Windows.Forms.GroupBox();
            this.textBoxPointOfSalesCurrentTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesPaidAmount = new System.Windows.Forms.TextBox();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.groupBoxPOSCustomerInfo = new System.Windows.Forms.GroupBox();
            this.textBoxPointOfSalesCreditAmount = new System.Windows.Forms.TextBox();
            this.textBoxPointOfSalesCustomerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPOSSlipInfo = new System.Windows.Forms.GroupBox();
            this.labelPOSReceiptNoError = new System.Windows.Forms.Label();
            this.comboBoxPointOfSalesCustomerName = new System.Windows.Forms.ComboBox();
            this.comboBoxPointOSalesPaymentMode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPOS = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPOSDate = new System.Windows.Forms.Label();
            this.labelPOSPaymentMode = new System.Windows.Forms.Label();
            this.labelReceiptNo = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesReceiptNo = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxPOSPurchaseitems2 = new System.Windows.Forms.GroupBox();
            this.buttonPointOfSalesPayment = new System.Windows.Forms.Button();
            this.comboBoxPointOfSalesItemName = new System.Windows.Forms.ComboBox();
            this.dataGridViewPointOfSalesPurchasedItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPointOfSalesUnitPrice = new System.Windows.Forms.TextBox();
            this.buttonPointOfSalesAddItem = new System.Windows.Forms.Button();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxPointOfSalesCategoryName = new System.Windows.Forms.ComboBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.groupBoxPOSCPaymentInfo.SuspendLayout();
            this.groupBoxPOSCustomerInfo.SuspendLayout();
            this.groupBoxPOSSlipInfo.SuspendLayout();
            this.groupBoxPOSPurchaseitems2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPointOfSalesPurchasedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPOSReceiptNo
            // 
            this.labelPOSReceiptNo.AutoSize = true;
            this.labelPOSReceiptNo.Location = new System.Drawing.Point(390, 255);
            this.labelPOSReceiptNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPOSReceiptNo.Name = "labelPOSReceiptNo";
            this.labelPOSReceiptNo.Size = new System.Drawing.Size(64, 13);
            this.labelPOSReceiptNo.TabIndex = 31;
            this.labelPOSReceiptNo.Text = "Receipt No:";
            // 
            // buttonPOSSubmit
            // 
            this.buttonPOSSubmit.Location = new System.Drawing.Point(392, 494);
            this.buttonPOSSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPOSSubmit.Name = "buttonPOSSubmit";
            this.buttonPOSSubmit.Size = new System.Drawing.Size(89, 28);
            this.buttonPOSSubmit.TabIndex = 37;
            this.buttonPOSSubmit.Text = "Submit";
            this.buttonPOSSubmit.UseVisualStyleBackColor = true;
            // 
            // groupBoxPOSCPaymentInfo
            // 
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.textBoxPointOfSalesCurrentTotal);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.label5);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.textBoxPointOfSalesDiscount);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.labelDiscount);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.textBoxPointOfSalesPaidAmount);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.labelPaidAmount);
            this.groupBoxPOSCPaymentInfo.Location = new System.Drawing.Point(101, 363);
            this.groupBoxPOSCPaymentInfo.Name = "groupBoxPOSCPaymentInfo";
            this.groupBoxPOSCPaymentInfo.Size = new System.Drawing.Size(273, 155);
            this.groupBoxPOSCPaymentInfo.TabIndex = 36;
            this.groupBoxPOSCPaymentInfo.TabStop = false;
            this.groupBoxPOSCPaymentInfo.Text = "Payment Info";
            // 
            // textBoxPointOfSalesCurrentTotal
            // 
            this.textBoxPointOfSalesCurrentTotal.Location = new System.Drawing.Point(29, 34);
            this.textBoxPointOfSalesCurrentTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesCurrentTotal.Name = "textBoxPointOfSalesCurrentTotal";
            this.textBoxPointOfSalesCurrentTotal.ReadOnly = true;
            this.textBoxPointOfSalesCurrentTotal.Size = new System.Drawing.Size(219, 20);
            this.textBoxPointOfSalesCurrentTotal.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Current Total:";
            // 
            // textBoxPointOfSalesDiscount
            // 
            this.textBoxPointOfSalesDiscount.Location = new System.Drawing.Point(29, 118);
            this.textBoxPointOfSalesDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesDiscount.Name = "textBoxPointOfSalesDiscount";
            this.textBoxPointOfSalesDiscount.Size = new System.Drawing.Size(219, 20);
            this.textBoxPointOfSalesDiscount.TabIndex = 32;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(24, 98);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(52, 13);
            this.labelDiscount.TabIndex = 31;
            this.labelDiscount.Text = "Discount:";
            // 
            // textBoxPointOfSalesPaidAmount
            // 
            this.textBoxPointOfSalesPaidAmount.Location = new System.Drawing.Point(29, 74);
            this.textBoxPointOfSalesPaidAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesPaidAmount.Name = "textBoxPointOfSalesPaidAmount";
            this.textBoxPointOfSalesPaidAmount.Size = new System.Drawing.Size(219, 20);
            this.textBoxPointOfSalesPaidAmount.TabIndex = 30;
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(27, 57);
            this.labelPaidAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(67, 13);
            this.labelPaidAmount.TabIndex = 29;
            this.labelPaidAmount.Text = "PaidAmount:";
            // 
            // groupBoxPOSCustomerInfo
            // 
            this.groupBoxPOSCustomerInfo.Controls.Add(this.textBoxPointOfSalesCreditAmount);
            this.groupBoxPOSCustomerInfo.Controls.Add(this.textBoxPointOfSalesCustomerAddress);
            this.groupBoxPOSCustomerInfo.Controls.Add(this.label3);
            this.groupBoxPOSCustomerInfo.Controls.Add(this.textBoxPointOfSalesCustomerName);
            this.groupBoxPOSCustomerInfo.Controls.Add(this.label4);
            this.groupBoxPOSCustomerInfo.Controls.Add(this.label2);
            this.groupBoxPOSCustomerInfo.Location = new System.Drawing.Point(100, 223);
            this.groupBoxPOSCustomerInfo.Name = "groupBoxPOSCustomerInfo";
            this.groupBoxPOSCustomerInfo.Size = new System.Drawing.Size(273, 134);
            this.groupBoxPOSCustomerInfo.TabIndex = 35;
            this.groupBoxPOSCustomerInfo.TabStop = false;
            this.groupBoxPOSCustomerInfo.Text = "Customer Info";
            // 
            // textBoxPointOfSalesCreditAmount
            // 
            this.textBoxPointOfSalesCreditAmount.Location = new System.Drawing.Point(88, 102);
            this.textBoxPointOfSalesCreditAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesCreditAmount.Name = "textBoxPointOfSalesCreditAmount";
            this.textBoxPointOfSalesCreditAmount.ReadOnly = true;
            this.textBoxPointOfSalesCreditAmount.Size = new System.Drawing.Size(157, 20);
            this.textBoxPointOfSalesCreditAmount.TabIndex = 28;
            // 
            // textBoxPointOfSalesCustomerAddress
            // 
            this.textBoxPointOfSalesCustomerAddress.Location = new System.Drawing.Point(60, 42);
            this.textBoxPointOfSalesCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesCustomerAddress.Multiline = true;
            this.textBoxPointOfSalesCustomerAddress.Name = "textBoxPointOfSalesCustomerAddress";
            this.textBoxPointOfSalesCustomerAddress.ReadOnly = true;
            this.textBoxPointOfSalesCustomerAddress.Size = new System.Drawing.Size(185, 51);
            this.textBoxPointOfSalesCustomerAddress.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Credit Amount:";
            // 
            // textBoxPointOfSalesCustomerName
            // 
            this.textBoxPointOfSalesCustomerName.Location = new System.Drawing.Point(60, 18);
            this.textBoxPointOfSalesCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesCustomerName.Name = "textBoxPointOfSalesCustomerName";
            this.textBoxPointOfSalesCustomerName.ReadOnly = true;
            this.textBoxPointOfSalesCustomerName.Size = new System.Drawing.Size(186, 20);
            this.textBoxPointOfSalesCustomerName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // groupBoxPOSSlipInfo
            // 
            this.groupBoxPOSSlipInfo.Controls.Add(this.labelPOSReceiptNoError);
            this.groupBoxPOSSlipInfo.Controls.Add(this.comboBoxPointOfSalesCustomerName);
            this.groupBoxPOSSlipInfo.Controls.Add(this.comboBoxPointOSalesPaymentMode);
            this.groupBoxPOSSlipInfo.Controls.Add(this.dateTimePickerPOS);
            this.groupBoxPOSSlipInfo.Controls.Add(this.label1);
            this.groupBoxPOSSlipInfo.Controls.Add(this.labelPOSDate);
            this.groupBoxPOSSlipInfo.Controls.Add(this.labelPOSPaymentMode);
            this.groupBoxPOSSlipInfo.Controls.Add(this.labelReceiptNo);
            this.groupBoxPOSSlipInfo.Controls.Add(this.textBoxPointOfSalesReceiptNo);
            this.groupBoxPOSSlipInfo.Location = new System.Drawing.Point(100, 14);
            this.groupBoxPOSSlipInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPOSSlipInfo.Name = "groupBoxPOSSlipInfo";
            this.groupBoxPOSSlipInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPOSSlipInfo.Size = new System.Drawing.Size(274, 208);
            this.groupBoxPOSSlipInfo.TabIndex = 33;
            this.groupBoxPOSSlipInfo.TabStop = false;
            // 
            // labelPOSReceiptNoError
            // 
            this.labelPOSReceiptNoError.AutoSize = true;
            this.labelPOSReceiptNoError.BackColor = System.Drawing.SystemColors.Control;
            this.labelPOSReceiptNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPOSReceiptNoError.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelPOSReceiptNoError.Location = new System.Drawing.Point(251, 75);
            this.labelPOSReceiptNoError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPOSReceiptNoError.Name = "labelPOSReceiptNoError";
            this.labelPOSReceiptNoError.Size = new System.Drawing.Size(16, 20);
            this.labelPOSReceiptNoError.TabIndex = 31;
            this.labelPOSReceiptNoError.Text = "*";
            // 
            // comboBoxPointOfSalesCustomerName
            // 
            this.comboBoxPointOfSalesCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointOfSalesCustomerName.FormattingEnabled = true;
            this.comboBoxPointOfSalesCustomerName.Location = new System.Drawing.Point(24, 167);
            this.comboBoxPointOfSalesCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPointOfSalesCustomerName.Name = "comboBoxPointOfSalesCustomerName";
            this.comboBoxPointOfSalesCustomerName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxPointOfSalesCustomerName.TabIndex = 23;
            // 
            // comboBoxPointOSalesPaymentMode
            // 
            this.comboBoxPointOSalesPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointOSalesPaymentMode.FormattingEnabled = true;
            this.comboBoxPointOSalesPaymentMode.Location = new System.Drawing.Point(24, 118);
            this.comboBoxPointOSalesPaymentMode.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPointOSalesPaymentMode.Name = "comboBoxPointOSalesPaymentMode";
            this.comboBoxPointOSalesPaymentMode.Size = new System.Drawing.Size(219, 21);
            this.comboBoxPointOSalesPaymentMode.TabIndex = 23;
            // 
            // dateTimePickerPOS
            // 
            this.dateTimePickerPOS.Location = new System.Drawing.Point(24, 32);
            this.dateTimePickerPOS.Name = "dateTimePickerPOS";
            this.dateTimePickerPOS.Size = new System.Drawing.Size(219, 20);
            this.dateTimePickerPOS.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name:";
            // 
            // labelPOSDate
            // 
            this.labelPOSDate.AutoSize = true;
            this.labelPOSDate.Location = new System.Drawing.Point(24, 15);
            this.labelPOSDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPOSDate.Name = "labelPOSDate";
            this.labelPOSDate.Size = new System.Drawing.Size(33, 13);
            this.labelPOSDate.TabIndex = 1;
            this.labelPOSDate.Text = "Date:";
            // 
            // labelPOSPaymentMode
            // 
            this.labelPOSPaymentMode.AutoSize = true;
            this.labelPOSPaymentMode.Location = new System.Drawing.Point(24, 100);
            this.labelPOSPaymentMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPOSPaymentMode.Name = "labelPOSPaymentMode";
            this.labelPOSPaymentMode.Size = new System.Drawing.Size(81, 13);
            this.labelPOSPaymentMode.TabIndex = 3;
            this.labelPOSPaymentMode.Text = "Payment Mode:";
            // 
            // labelReceiptNo
            // 
            this.labelReceiptNo.AutoSize = true;
            this.labelReceiptNo.Location = new System.Drawing.Point(24, 58);
            this.labelReceiptNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceiptNo.Name = "labelReceiptNo";
            this.labelReceiptNo.Size = new System.Drawing.Size(64, 13);
            this.labelReceiptNo.TabIndex = 8;
            this.labelReceiptNo.Text = "Receipt No:";
            // 
            // textBoxPointOfSalesReceiptNo
            // 
            this.textBoxPointOfSalesReceiptNo.Location = new System.Drawing.Point(26, 73);
            this.textBoxPointOfSalesReceiptNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesReceiptNo.Name = "textBoxPointOfSalesReceiptNo";
            this.textBoxPointOfSalesReceiptNo.Size = new System.Drawing.Size(219, 20);
            this.textBoxPointOfSalesReceiptNo.TabIndex = 12;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(350, -23);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(131, 23);
            this.labelTitle.TabIndex = 32;
            this.labelTitle.Text = "Point of Sales";
            // 
            // groupBoxPOSPurchaseitems2
            // 
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.buttonPointOfSalesPayment);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.comboBoxPointOfSalesItemName);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.dataGridViewPointOfSalesPurchasedItems);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.textBoxPointOfSalesUnitPrice);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.buttonPointOfSalesAddItem);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.LabelPrice);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.textBoxPointOfSalesQuantity);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.comboBoxPointOfSalesCategoryName);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.labelItemName);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.labelCategoryName);
            this.groupBoxPOSPurchaseitems2.Controls.Add(this.labelQuantity);
            this.groupBoxPOSPurchaseitems2.Location = new System.Drawing.Point(378, 14);
            this.groupBoxPOSPurchaseitems2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPOSPurchaseitems2.Name = "groupBoxPOSPurchaseitems2";
            this.groupBoxPOSPurchaseitems2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPOSPurchaseitems2.Size = new System.Drawing.Size(366, 469);
            this.groupBoxPOSPurchaseitems2.TabIndex = 34;
            this.groupBoxPOSPurchaseitems2.TabStop = false;
            this.groupBoxPOSPurchaseitems2.Text = "Purchased Item(s)";
            // 
            // buttonPointOfSalesPayment
            // 
            this.buttonPointOfSalesPayment.Location = new System.Drawing.Point(273, 437);
            this.buttonPointOfSalesPayment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPointOfSalesPayment.Name = "buttonPointOfSalesPayment";
            this.buttonPointOfSalesPayment.Size = new System.Drawing.Size(89, 28);
            this.buttonPointOfSalesPayment.TabIndex = 26;
            this.buttonPointOfSalesPayment.Text = "Payment";
            this.buttonPointOfSalesPayment.UseVisualStyleBackColor = true;
            // 
            // comboBoxPointOfSalesItemName
            // 
            this.comboBoxPointOfSalesItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointOfSalesItemName.FormattingEnabled = true;
            this.comboBoxPointOfSalesItemName.Location = new System.Drawing.Point(79, 85);
            this.comboBoxPointOfSalesItemName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPointOfSalesItemName.Name = "comboBoxPointOfSalesItemName";
            this.comboBoxPointOfSalesItemName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxPointOfSalesItemName.TabIndex = 10;
            // 
            // dataGridViewPointOfSalesPurchasedItems
            // 
            this.dataGridViewPointOfSalesPurchasedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPointOfSalesPurchasedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.UnitPrice});
            this.dataGridViewPointOfSalesPurchasedItems.Location = new System.Drawing.Point(18, 253);
            this.dataGridViewPointOfSalesPurchasedItems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPointOfSalesPurchasedItems.Name = "dataGridViewPointOfSalesPurchasedItems";
            this.dataGridViewPointOfSalesPurchasedItems.Size = new System.Drawing.Size(344, 172);
            this.dataGridViewPointOfSalesPurchasedItems.TabIndex = 25;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // textBoxPointOfSalesUnitPrice
            // 
            this.textBoxPointOfSalesUnitPrice.Location = new System.Drawing.Point(77, 136);
            this.textBoxPointOfSalesUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesUnitPrice.Name = "textBoxPointOfSalesUnitPrice";
            this.textBoxPointOfSalesUnitPrice.Size = new System.Drawing.Size(219, 20);
            this.textBoxPointOfSalesUnitPrice.TabIndex = 13;
            // 
            // buttonPointOfSalesAddItem
            // 
            this.buttonPointOfSalesAddItem.Location = new System.Drawing.Point(136, 212);
            this.buttonPointOfSalesAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPointOfSalesAddItem.Name = "buttonPointOfSalesAddItem";
            this.buttonPointOfSalesAddItem.Size = new System.Drawing.Size(89, 28);
            this.buttonPointOfSalesAddItem.TabIndex = 18;
            this.buttonPointOfSalesAddItem.Text = "Add Item";
            this.buttonPointOfSalesAddItem.UseVisualStyleBackColor = true;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(76, 118);
            this.LabelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(56, 13);
            this.LabelPrice.TabIndex = 5;
            this.LabelPrice.Text = "Unit Price:";
            // 
            // textBoxPointOfSalesQuantity
            // 
            this.textBoxPointOfSalesQuantity.Location = new System.Drawing.Point(77, 181);
            this.textBoxPointOfSalesQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesQuantity.Name = "textBoxPointOfSalesQuantity";
            this.textBoxPointOfSalesQuantity.Size = new System.Drawing.Size(219, 20);
            this.textBoxPointOfSalesQuantity.TabIndex = 15;
            // 
            // comboBoxPointOfSalesCategoryName
            // 
            this.comboBoxPointOfSalesCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointOfSalesCategoryName.FormattingEnabled = true;
            this.comboBoxPointOfSalesCategoryName.Location = new System.Drawing.Point(79, 35);
            this.comboBoxPointOfSalesCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPointOfSalesCategoryName.Name = "comboBoxPointOfSalesCategoryName";
            this.comboBoxPointOfSalesCategoryName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxPointOfSalesCategoryName.TabIndex = 11;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(76, 66);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(61, 13);
            this.labelItemName.TabIndex = 6;
            this.labelItemName.Text = "Item Name:";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(76, 18);
            this.labelCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(83, 13);
            this.labelCategoryName.TabIndex = 7;
            this.labelCategoryName.Text = "Category Name:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(76, 165);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity:";
            // 
            // POSBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 523);
            this.Controls.Add(this.buttonPOSSubmit);
            this.Controls.Add(this.groupBoxPOSCPaymentInfo);
            this.Controls.Add(this.groupBoxPOSCustomerInfo);
            this.Controls.Add(this.groupBoxPOSSlipInfo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxPOSPurchaseitems2);
            this.Controls.Add(this.labelPOSReceiptNo);
            this.Name = "POSBackup";
            this.Text = "POSBackup";
            this.groupBoxPOSCPaymentInfo.ResumeLayout(false);
            this.groupBoxPOSCPaymentInfo.PerformLayout();
            this.groupBoxPOSCustomerInfo.ResumeLayout(false);
            this.groupBoxPOSCustomerInfo.PerformLayout();
            this.groupBoxPOSSlipInfo.ResumeLayout(false);
            this.groupBoxPOSSlipInfo.PerformLayout();
            this.groupBoxPOSPurchaseitems2.ResumeLayout(false);
            this.groupBoxPOSPurchaseitems2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPointOfSalesPurchasedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPOSReceiptNo;
        private System.Windows.Forms.Button buttonPOSSubmit;
        private System.Windows.Forms.GroupBox groupBoxPOSCPaymentInfo;
        private System.Windows.Forms.TextBox textBoxPointOfSalesCurrentTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPointOfSalesDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxPointOfSalesPaidAmount;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.GroupBox groupBoxPOSCustomerInfo;
        private System.Windows.Forms.TextBox textBoxPointOfSalesCreditAmount;
        private System.Windows.Forms.TextBox textBoxPointOfSalesCustomerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPointOfSalesCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPOSSlipInfo;
        private System.Windows.Forms.Label labelPOSReceiptNoError;
        private System.Windows.Forms.ComboBox comboBoxPointOfSalesCustomerName;
        private System.Windows.Forms.ComboBox comboBoxPointOSalesPaymentMode;
        private System.Windows.Forms.DateTimePicker dateTimePickerPOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPOSDate;
        private System.Windows.Forms.Label labelPOSPaymentMode;
        private System.Windows.Forms.Label labelReceiptNo;
        private System.Windows.Forms.TextBox textBoxPointOfSalesReceiptNo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxPOSPurchaseitems2;
        private System.Windows.Forms.Button buttonPointOfSalesPayment;
        private System.Windows.Forms.ComboBox comboBoxPointOfSalesItemName;
        private System.Windows.Forms.DataGridView dataGridViewPointOfSalesPurchasedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.TextBox textBoxPointOfSalesUnitPrice;
        private System.Windows.Forms.Button buttonPointOfSalesAddItem;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox textBoxPointOfSalesQuantity;
        private System.Windows.Forms.ComboBox comboBoxPointOfSalesCategoryName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelQuantity;
    }
}