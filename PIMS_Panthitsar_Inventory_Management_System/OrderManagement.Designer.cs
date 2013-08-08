namespace PIMS_Panthitsar_Inventory_Management_System
{
    partial class OrderManagement
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
            this.OrdMgmtTab = new System.Windows.Forms.TabControl();
            this.ManagePurchasedItems = new System.Windows.Forms.TabPage();
            this.buttonMPISavePurchasedItems = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxPurchasedItems = new System.Windows.Forms.GroupBox();
            this.textboxMPIDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textboxMPITotalPrice = new System.Windows.Forms.TextBox();
            this.comboboxMPISupplierName = new System.Windows.Forms.ComboBox();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.textboxMPIPaidAmount = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelReceiptNo = new System.Windows.Forms.Label();
            this.textboxMPIReceiptNo = new System.Windows.Forms.TextBox();
            this.gridviewManagePurchasedItems = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPurchaseitems2 = new System.Windows.Forms.GroupBox();
            this.comboboxMPIItemName = new System.Windows.Forms.ComboBox();
            this.textboxMPIPrice = new System.Windows.Forms.TextBox();
            this.buttonMPIAddItem = new System.Windows.Forms.Button();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.textboxMPIQuantity = new System.Windows.Forms.TextBox();
            this.comboboxMPICategoryName = new System.Windows.Forms.ComboBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.ManageShippingItems = new System.Windows.Forms.TabPage();
            this.dataGridViewManageShippingItemsAddItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonShippingItemsSave = new System.Windows.Forms.Button();
            this.textBoxShippingItemsCarryCharges = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxShippingItemsCarryName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShippingItemsMarkerNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxManageShippingItemsItemName = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxManageShippingItemsCategoryName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ManagePurchaseOrder = new System.Windows.Forms.TabPage();
            this.labelOrderedItems = new System.Windows.Forms.Label();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.comboBoxOrderCustomername = new System.Windows.Forms.ComboBox();
            this.labelOrderedCustomerName = new System.Windows.Forms.Label();
            this.comboBoxOrderedItemName = new System.Windows.Forms.ComboBox();
            this.buttonOrderedItemSave = new System.Windows.Forms.Button();
            this.textBoxOrderedQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxOrderCategoryname = new System.Windows.Forms.ComboBox();
            this.labelOrderItemName = new System.Windows.Forms.Label();
            this.labelOrderCategoryName = new System.Windows.Forms.Label();
            this.labelOrderedQuantity = new System.Windows.Forms.Label();
            this.labelOrderedDate = new System.Windows.Forms.Label();
            this.dateTimePickerOrderedDate = new System.Windows.Forms.DateTimePicker();
            this.OrdMgmtTab.SuspendLayout();
            this.ManagePurchasedItems.SuspendLayout();
            this.groupBoxPurchasedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewManagePurchasedItems)).BeginInit();
            this.groupBoxPurchaseitems2.SuspendLayout();
            this.ManageShippingItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageShippingItemsAddItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ManagePurchaseOrder.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdMgmtTab
            // 
            this.OrdMgmtTab.Controls.Add(this.ManagePurchasedItems);
            this.OrdMgmtTab.Controls.Add(this.ManageShippingItems);
            this.OrdMgmtTab.Controls.Add(this.ManagePurchaseOrder);
            this.OrdMgmtTab.Location = new System.Drawing.Point(17, 13);
            this.OrdMgmtTab.Name = "OrdMgmtTab";
            this.OrdMgmtTab.SelectedIndex = 0;
            this.OrdMgmtTab.Size = new System.Drawing.Size(732, 613);
            this.OrdMgmtTab.TabIndex = 0;
            // 
            // ManagePurchasedItems
            // 
            this.ManagePurchasedItems.BackColor = System.Drawing.Color.Gainsboro;
            this.ManagePurchasedItems.Controls.Add(this.buttonMPISavePurchasedItems);
            this.ManagePurchasedItems.Controls.Add(this.labelTitle);
            this.ManagePurchasedItems.Controls.Add(this.groupBoxPurchasedItems);
            this.ManagePurchasedItems.Controls.Add(this.gridviewManagePurchasedItems);
            this.ManagePurchasedItems.Controls.Add(this.groupBoxPurchaseitems2);
            this.ManagePurchasedItems.Location = new System.Drawing.Point(4, 23);
            this.ManagePurchasedItems.Name = "ManagePurchasedItems";
            this.ManagePurchasedItems.Padding = new System.Windows.Forms.Padding(3);
            this.ManagePurchasedItems.Size = new System.Drawing.Size(724, 586);
            this.ManagePurchasedItems.TabIndex = 0;
            this.ManagePurchasedItems.Text = "Manage Purchased Items";
            // 
            // buttonMPISavePurchasedItems
            // 
            this.buttonMPISavePurchasedItems.Location = new System.Drawing.Point(601, 552);
            this.buttonMPISavePurchasedItems.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonMPISavePurchasedItems.Name = "buttonMPISavePurchasedItems";
            this.buttonMPISavePurchasedItems.Size = new System.Drawing.Size(89, 28);
            this.buttonMPISavePurchasedItems.TabIndex = 19;
            this.buttonMPISavePurchasedItems.Text = "Save";
            this.buttonMPISavePurchasedItems.UseVisualStyleBackColor = true;
            this.buttonMPISavePurchasedItems.Click += new System.EventHandler(this.buttonMPISavePurchasedItems_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(243, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(226, 22);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Manage Purchased Items";
            // 
            // groupBoxPurchasedItems
            // 
            this.groupBoxPurchasedItems.Controls.Add(this.textboxMPIDiscount);
            this.groupBoxPurchasedItems.Controls.Add(this.labelDiscount);
            this.groupBoxPurchasedItems.Controls.Add(this.textboxMPITotalPrice);
            this.groupBoxPurchasedItems.Controls.Add(this.comboboxMPISupplierName);
            this.groupBoxPurchasedItems.Controls.Add(this.labelSupplierName);
            this.groupBoxPurchasedItems.Controls.Add(this.labelPaidAmount);
            this.groupBoxPurchasedItems.Controls.Add(this.textboxMPIPaidAmount);
            this.groupBoxPurchasedItems.Controls.Add(this.labelTotal);
            this.groupBoxPurchasedItems.Controls.Add(this.labelReceiptNo);
            this.groupBoxPurchasedItems.Controls.Add(this.textboxMPIReceiptNo);
            this.groupBoxPurchasedItems.Location = new System.Drawing.Point(64, 43);
            this.groupBoxPurchasedItems.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxPurchasedItems.Name = "groupBoxPurchasedItems";
            this.groupBoxPurchasedItems.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxPurchasedItems.Size = new System.Drawing.Size(290, 268);
            this.groupBoxPurchasedItems.TabIndex = 23;
            this.groupBoxPurchasedItems.TabStop = false;
            // 
            // textboxMPIDiscount
            // 
            this.textboxMPIDiscount.Location = new System.Drawing.Point(35, 228);
            this.textboxMPIDiscount.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxMPIDiscount.Name = "textboxMPIDiscount";
            this.textboxMPIDiscount.Size = new System.Drawing.Size(219, 22);
            this.textboxMPIDiscount.TabIndex = 21;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(27, 212);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(63, 16);
            this.labelDiscount.TabIndex = 20;
            this.labelDiscount.Text = "Discount:";
            // 
            // textboxMPITotalPrice
            // 
            this.textboxMPITotalPrice.Enabled = false;
            this.textboxMPITotalPrice.Location = new System.Drawing.Point(35, 126);
            this.textboxMPITotalPrice.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxMPITotalPrice.Name = "textboxMPITotalPrice";
            this.textboxMPITotalPrice.Size = new System.Drawing.Size(219, 22);
            this.textboxMPITotalPrice.TabIndex = 18;
            // 
            // comboboxMPISupplierName
            // 
            this.comboboxMPISupplierName.DropDownHeight = 120;
            this.comboboxMPISupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxMPISupplierName.FormattingEnabled = true;
            this.comboboxMPISupplierName.IntegralHeight = false;
            this.comboboxMPISupplierName.Location = new System.Drawing.Point(35, 32);
            this.comboboxMPISupplierName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboboxMPISupplierName.Name = "comboboxMPISupplierName";
            this.comboboxMPISupplierName.Size = new System.Drawing.Size(219, 21);
            this.comboboxMPISupplierName.TabIndex = 9;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(32, 14);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(101, 16);
            this.labelSupplierName.TabIndex = 1;
            this.labelSupplierName.Text = "Supplier Name:";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(32, 162);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(84, 16);
            this.labelPaidAmount.TabIndex = 2;
            this.labelPaidAmount.Text = "PaidAmount:";
            // 
            // textboxMPIPaidAmount
            // 
            this.textboxMPIPaidAmount.Location = new System.Drawing.Point(35, 178);
            this.textboxMPIPaidAmount.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxMPIPaidAmount.Name = "textboxMPIPaidAmount";
            this.textboxMPIPaidAmount.Size = new System.Drawing.Size(219, 22);
            this.textboxMPIPaidAmount.TabIndex = 16;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(32, 108);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(42, 16);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total:";
            // 
            // labelReceiptNo
            // 
            this.labelReceiptNo.AutoSize = true;
            this.labelReceiptNo.Location = new System.Drawing.Point(32, 58);
            this.labelReceiptNo.Name = "labelReceiptNo";
            this.labelReceiptNo.Size = new System.Drawing.Size(79, 16);
            this.labelReceiptNo.TabIndex = 8;
            this.labelReceiptNo.Text = "Receipt No:";
            // 
            // textboxMPIReceiptNo
            // 
            this.textboxMPIReceiptNo.Location = new System.Drawing.Point(35, 77);
            this.textboxMPIReceiptNo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxMPIReceiptNo.Name = "textboxMPIReceiptNo";
            this.textboxMPIReceiptNo.Size = new System.Drawing.Size(219, 22);
            this.textboxMPIReceiptNo.TabIndex = 12;
            // 
            // gridviewManagePurchasedItems
            // 
            this.gridviewManagePurchasedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewManagePurchasedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.gridviewManagePurchasedItems.Location = new System.Drawing.Point(28, 353);
            this.gridviewManagePurchasedItems.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gridviewManagePurchasedItems.Name = "gridviewManagePurchasedItems";
            this.gridviewManagePurchasedItems.Size = new System.Drawing.Size(663, 183);
            this.gridviewManagePurchasedItems.TabIndex = 24;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Category";
            this.Column10.Name = "Column10";
            this.Column10.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Item Name";
            this.Column11.Name = "Column11";
            this.Column11.Width = 220;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Unit Price";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Quantity";
            this.Column13.Name = "Column13";
            // 
            // groupBoxPurchaseitems2
            // 
            this.groupBoxPurchaseitems2.Controls.Add(this.comboboxMPIItemName);
            this.groupBoxPurchaseitems2.Controls.Add(this.textboxMPIPrice);
            this.groupBoxPurchaseitems2.Controls.Add(this.buttonMPIAddItem);
            this.groupBoxPurchaseitems2.Controls.Add(this.LabelPrice);
            this.groupBoxPurchaseitems2.Controls.Add(this.textboxMPIQuantity);
            this.groupBoxPurchaseitems2.Controls.Add(this.comboboxMPICategoryName);
            this.groupBoxPurchaseitems2.Controls.Add(this.labelItemName);
            this.groupBoxPurchaseitems2.Controls.Add(this.labelCategoryName);
            this.groupBoxPurchaseitems2.Controls.Add(this.labelQuantity);
            this.groupBoxPurchaseitems2.Location = new System.Drawing.Point(360, 43);
            this.groupBoxPurchaseitems2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxPurchaseitems2.Name = "groupBoxPurchaseitems2";
            this.groupBoxPurchaseitems2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxPurchaseitems2.Size = new System.Drawing.Size(288, 268);
            this.groupBoxPurchaseitems2.TabIndex = 25;
            this.groupBoxPurchaseitems2.TabStop = false;
            // 
            // comboboxMPIItemName
            // 
            this.comboboxMPIItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxMPIItemName.FormattingEnabled = true;
            this.comboboxMPIItemName.Location = new System.Drawing.Point(40, 77);
            this.comboboxMPIItemName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboboxMPIItemName.Name = "comboboxMPIItemName";
            this.comboboxMPIItemName.Size = new System.Drawing.Size(219, 21);
            this.comboboxMPIItemName.TabIndex = 10;
            // 
            // textboxMPIPrice
            // 
            this.textboxMPIPrice.Location = new System.Drawing.Point(37, 126);
            this.textboxMPIPrice.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxMPIPrice.Name = "textboxMPIPrice";
            this.textboxMPIPrice.Size = new System.Drawing.Size(219, 22);
            this.textboxMPIPrice.TabIndex = 13;
            // 
            // buttonMPIAddItem
            // 
            this.buttonMPIAddItem.Location = new System.Drawing.Point(115, 222);
            this.buttonMPIAddItem.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonMPIAddItem.Name = "buttonMPIAddItem";
            this.buttonMPIAddItem.Size = new System.Drawing.Size(89, 28);
            this.buttonMPIAddItem.TabIndex = 18;
            this.buttonMPIAddItem.Text = "Add Item";
            this.buttonMPIAddItem.UseVisualStyleBackColor = true;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(35, 108);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(42, 16);
            this.LabelPrice.TabIndex = 5;
            this.LabelPrice.Text = "Price:";
            // 
            // textboxMPIQuantity
            // 
            this.textboxMPIQuantity.Location = new System.Drawing.Point(37, 178);
            this.textboxMPIQuantity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textboxMPIQuantity.Name = "textboxMPIQuantity";
            this.textboxMPIQuantity.Size = new System.Drawing.Size(219, 22);
            this.textboxMPIQuantity.TabIndex = 15;
            // 
            // comboboxMPICategoryName
            // 
            this.comboboxMPICategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxMPICategoryName.FormattingEnabled = true;
            this.comboboxMPICategoryName.Location = new System.Drawing.Point(40, 32);
            this.comboboxMPICategoryName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboboxMPICategoryName.Name = "comboboxMPICategoryName";
            this.comboboxMPICategoryName.Size = new System.Drawing.Size(219, 21);
            this.comboboxMPICategoryName.TabIndex = 11;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(35, 58);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(76, 16);
            this.labelItemName.TabIndex = 6;
            this.labelItemName.Text = "Item Name:";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(35, 14);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(106, 16);
            this.labelCategoryName.TabIndex = 7;
            this.labelCategoryName.Text = "Category Name:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(35, 162);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(59, 16);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity:";
            // 
            // ManageShippingItems
            // 
            this.ManageShippingItems.BackColor = System.Drawing.Color.Gainsboro;
            this.ManageShippingItems.Controls.Add(this.dataGridViewManageShippingItemsAddItems);
            this.ManageShippingItems.Controls.Add(this.label8);
            this.ManageShippingItems.Controls.Add(this.groupBox2);
            this.ManageShippingItems.Controls.Add(this.groupBox1);
            this.ManageShippingItems.Location = new System.Drawing.Point(4, 23);
            this.ManageShippingItems.Name = "ManageShippingItems";
            this.ManageShippingItems.Padding = new System.Windows.Forms.Padding(3);
            this.ManageShippingItems.Size = new System.Drawing.Size(724, 586);
            this.ManageShippingItems.TabIndex = 1;
            this.ManageShippingItems.Text = "Manage Shipping Items";
            // 
            // dataGridViewManageShippingItemsAddItems
            // 
            this.dataGridViewManageShippingItemsAddItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageShippingItemsAddItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewManageShippingItemsAddItems.Location = new System.Drawing.Point(23, 344);
            this.dataGridViewManageShippingItemsAddItems.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewManageShippingItemsAddItems.Name = "dataGridViewManageShippingItemsAddItems";
            this.dataGridViewManageShippingItemsAddItems.Size = new System.Drawing.Size(663, 183);
            this.dataGridViewManageShippingItemsAddItems.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Manage Shipping Items";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonShippingItemsSave);
            this.groupBox2.Controls.Add(this.textBoxShippingItemsCarryCharges);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxShippingItemsCarryName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxShippingItemsMarkerNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(67, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 259);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // buttonShippingItemsSave
            // 
            this.buttonShippingItemsSave.Location = new System.Drawing.Point(75, 186);
            this.buttonShippingItemsSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonShippingItemsSave.Name = "buttonShippingItemsSave";
            this.buttonShippingItemsSave.Size = new System.Drawing.Size(89, 28);
            this.buttonShippingItemsSave.TabIndex = 19;
            this.buttonShippingItemsSave.Text = "Save";
            this.buttonShippingItemsSave.UseVisualStyleBackColor = true;
            // 
            // textBoxShippingItemsCarryCharges
            // 
            this.textBoxShippingItemsCarryCharges.Location = new System.Drawing.Point(24, 135);
            this.textBoxShippingItemsCarryCharges.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxShippingItemsCarryCharges.Name = "textBoxShippingItemsCarryCharges";
            this.textBoxShippingItemsCarryCharges.Size = new System.Drawing.Size(219, 22);
            this.textBoxShippingItemsCarryCharges.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Carry Charges:";
            // 
            // comboBoxShippingItemsCarryName
            // 
            this.comboBoxShippingItemsCarryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShippingItemsCarryName.FormattingEnabled = true;
            this.comboBoxShippingItemsCarryName.Location = new System.Drawing.Point(23, 90);
            this.comboBoxShippingItemsCarryName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxShippingItemsCarryName.Name = "comboBoxShippingItemsCarryName";
            this.comboBoxShippingItemsCarryName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxShippingItemsCarryName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Carry Name:";
            // 
            // textBoxShippingItemsMarkerNo
            // 
            this.textBoxShippingItemsMarkerNo.Location = new System.Drawing.Point(23, 39);
            this.textBoxShippingItemsMarkerNo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxShippingItemsMarkerNo.Name = "textBoxShippingItemsMarkerNo";
            this.textBoxShippingItemsMarkerNo.Size = new System.Drawing.Size(219, 22);
            this.textBoxShippingItemsMarkerNo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Marker No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxManageShippingItemsItemName);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBoxManageShippingItemsCategoryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(347, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(294, 259);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxManageShippingItemsItemName
            // 
            this.comboBoxManageShippingItemsItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManageShippingItemsItemName.FormattingEnabled = true;
            this.comboBoxManageShippingItemsItemName.Location = new System.Drawing.Point(40, 83);
            this.comboBoxManageShippingItemsItemName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxManageShippingItemsItemName.Name = "comboBoxManageShippingItemsItemName";
            this.comboBoxManageShippingItemsItemName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxManageShippingItemsItemName.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 184);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 22);
            this.textBox2.TabIndex = 15;
            // 
            // comboBoxManageShippingItemsCategoryName
            // 
            this.comboBoxManageShippingItemsCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManageShippingItemsCategoryName.FormattingEnabled = true;
            this.comboBoxManageShippingItemsCategoryName.Location = new System.Drawing.Point(40, 38);
            this.comboBoxManageShippingItemsCategoryName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxManageShippingItemsCategoryName.Name = "comboBoxManageShippingItemsCategoryName";
            this.comboBoxManageShippingItemsCategoryName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxManageShippingItemsCategoryName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity:";
            // 
            // ManagePurchaseOrder
            // 
            this.ManagePurchaseOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.ManagePurchaseOrder.Controls.Add(this.labelOrderedItems);
            this.ManagePurchaseOrder.Controls.Add(this.groupBoxOrder);
            this.ManagePurchaseOrder.Location = new System.Drawing.Point(4, 23);
            this.ManagePurchaseOrder.Name = "ManagePurchaseOrder";
            this.ManagePurchaseOrder.Padding = new System.Windows.Forms.Padding(3);
            this.ManagePurchaseOrder.Size = new System.Drawing.Size(724, 586);
            this.ManagePurchaseOrder.TabIndex = 2;
            this.ManagePurchaseOrder.Text = "Manage Purchase Order";
            // 
            // labelOrderedItems
            // 
            this.labelOrderedItems.AutoSize = true;
            this.labelOrderedItems.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderedItems.Location = new System.Drawing.Point(248, 21);
            this.labelOrderedItems.Name = "labelOrderedItems";
            this.labelOrderedItems.Size = new System.Drawing.Size(201, 22);
            this.labelOrderedItems.TabIndex = 26;
            this.labelOrderedItems.Text = "ManageOrdered Items";
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.dateTimePickerOrderedDate);
            this.groupBoxOrder.Controls.Add(this.buttonOrderedItemSave);
            this.groupBoxOrder.Controls.Add(this.labelOrderedDate);
            this.groupBoxOrder.Controls.Add(this.comboBoxOrderedItemName);
            this.groupBoxOrder.Controls.Add(this.comboBoxOrderCustomername);
            this.groupBoxOrder.Controls.Add(this.labelOrderedCustomerName);
            this.groupBoxOrder.Controls.Add(this.comboBoxOrderCategoryname);
            this.groupBoxOrder.Controls.Add(this.labelOrderedQuantity);
            this.groupBoxOrder.Controls.Add(this.textBoxOrderedQuantity);
            this.groupBoxOrder.Controls.Add(this.labelOrderCategoryName);
            this.groupBoxOrder.Controls.Add(this.labelOrderItemName);
            this.groupBoxOrder.Location = new System.Drawing.Point(211, 73);
            this.groupBoxOrder.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBoxOrder.Size = new System.Drawing.Size(290, 268);
            this.groupBoxOrder.TabIndex = 27;
            this.groupBoxOrder.TabStop = false;
            // 
            // comboBoxOrderCustomername
            // 
            this.comboBoxOrderCustomername.DropDownHeight = 120;
            this.comboBoxOrderCustomername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderCustomername.FormattingEnabled = true;
            this.comboBoxOrderCustomername.IntegralHeight = false;
            this.comboBoxOrderCustomername.Location = new System.Drawing.Point(33, 79);
            this.comboBoxOrderCustomername.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxOrderCustomername.Name = "comboBoxOrderCustomername";
            this.comboBoxOrderCustomername.Size = new System.Drawing.Size(219, 21);
            this.comboBoxOrderCustomername.TabIndex = 9;
            // 
            // labelOrderedCustomerName
            // 
            this.labelOrderedCustomerName.AutoSize = true;
            this.labelOrderedCustomerName.Location = new System.Drawing.Point(30, 61);
            this.labelOrderedCustomerName.Name = "labelOrderedCustomerName";
            this.labelOrderedCustomerName.Size = new System.Drawing.Size(108, 16);
            this.labelOrderedCustomerName.TabIndex = 1;
            this.labelOrderedCustomerName.Text = "Customer Name:";
            // 
            // comboBoxOrderedItemName
            // 
            this.comboBoxOrderedItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderedItemName.FormattingEnabled = true;
            this.comboBoxOrderedItemName.Location = new System.Drawing.Point(33, 167);
            this.comboBoxOrderedItemName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxOrderedItemName.Name = "comboBoxOrderedItemName";
            this.comboBoxOrderedItemName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxOrderedItemName.TabIndex = 10;
            // 
            // buttonOrderedItemSave
            // 
            this.buttonOrderedItemSave.Location = new System.Drawing.Point(163, 238);
            this.buttonOrderedItemSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonOrderedItemSave.Name = "buttonOrderedItemSave";
            this.buttonOrderedItemSave.Size = new System.Drawing.Size(89, 28);
            this.buttonOrderedItemSave.TabIndex = 18;
            this.buttonOrderedItemSave.Text = "Save";
            this.buttonOrderedItemSave.UseVisualStyleBackColor = true;
            // 
            // textBoxOrderedQuantity
            // 
            this.textBoxOrderedQuantity.Location = new System.Drawing.Point(33, 208);
            this.textBoxOrderedQuantity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxOrderedQuantity.Name = "textBoxOrderedQuantity";
            this.textBoxOrderedQuantity.Size = new System.Drawing.Size(219, 22);
            this.textBoxOrderedQuantity.TabIndex = 15;
            // 
            // comboBoxOrderCategoryname
            // 
            this.comboBoxOrderCategoryname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderCategoryname.FormattingEnabled = true;
            this.comboBoxOrderCategoryname.Location = new System.Drawing.Point(33, 122);
            this.comboBoxOrderCategoryname.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxOrderCategoryname.Name = "comboBoxOrderCategoryname";
            this.comboBoxOrderCategoryname.Size = new System.Drawing.Size(219, 21);
            this.comboBoxOrderCategoryname.TabIndex = 11;
            // 
            // labelOrderItemName
            // 
            this.labelOrderItemName.AutoSize = true;
            this.labelOrderItemName.Location = new System.Drawing.Point(28, 148);
            this.labelOrderItemName.Name = "labelOrderItemName";
            this.labelOrderItemName.Size = new System.Drawing.Size(76, 16);
            this.labelOrderItemName.TabIndex = 6;
            this.labelOrderItemName.Text = "Item Name:";
            // 
            // labelOrderCategoryName
            // 
            this.labelOrderCategoryName.AutoSize = true;
            this.labelOrderCategoryName.Location = new System.Drawing.Point(28, 104);
            this.labelOrderCategoryName.Name = "labelOrderCategoryName";
            this.labelOrderCategoryName.Size = new System.Drawing.Size(106, 16);
            this.labelOrderCategoryName.TabIndex = 7;
            this.labelOrderCategoryName.Text = "Category Name:";
            // 
            // labelOrderedQuantity
            // 
            this.labelOrderedQuantity.AutoSize = true;
            this.labelOrderedQuantity.Location = new System.Drawing.Point(31, 192);
            this.labelOrderedQuantity.Name = "labelOrderedQuantity";
            this.labelOrderedQuantity.Size = new System.Drawing.Size(59, 16);
            this.labelOrderedQuantity.TabIndex = 4;
            this.labelOrderedQuantity.Text = "Quantity:";
            // 
            // labelOrderedDate
            // 
            this.labelOrderedDate.AutoSize = true;
            this.labelOrderedDate.Location = new System.Drawing.Point(32, 17);
            this.labelOrderedDate.Name = "labelOrderedDate";
            this.labelOrderedDate.Size = new System.Drawing.Size(93, 16);
            this.labelOrderedDate.TabIndex = 16;
            this.labelOrderedDate.Text = "Ordered Date:";
            // 
            // dateTimePickerOrderedDate
            // 
            this.dateTimePickerOrderedDate.Location = new System.Drawing.Point(33, 36);
            this.dateTimePickerOrderedDate.Name = "dateTimePickerOrderedDate";
            this.dateTimePickerOrderedDate.Size = new System.Drawing.Size(218, 22);
            this.dateTimePickerOrderedDate.TabIndex = 17;
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(761, 626);
            this.Controls.Add(this.OrdMgmtTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)), true);
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.OrdMgmtTab.ResumeLayout(false);
            this.ManagePurchasedItems.ResumeLayout(false);
            this.ManagePurchasedItems.PerformLayout();
            this.groupBoxPurchasedItems.ResumeLayout(false);
            this.groupBoxPurchasedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewManagePurchasedItems)).EndInit();
            this.groupBoxPurchaseitems2.ResumeLayout(false);
            this.groupBoxPurchaseitems2.PerformLayout();
            this.ManageShippingItems.ResumeLayout(false);
            this.ManageShippingItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageShippingItemsAddItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ManagePurchaseOrder.ResumeLayout(false);
            this.ManagePurchaseOrder.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OrdMgmtTab;
        private System.Windows.Forms.TabPage ManagePurchasedItems;
        private System.Windows.Forms.TabPage ManageShippingItems;
        private System.Windows.Forms.TabPage ManagePurchaseOrder;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxPurchasedItems;
        private System.Windows.Forms.Button buttonMPISavePurchasedItems;
        private System.Windows.Forms.TextBox textboxMPIDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textboxMPITotalPrice;
        private System.Windows.Forms.ComboBox comboboxMPISupplierName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.TextBox textboxMPIPaidAmount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelReceiptNo;
        private System.Windows.Forms.TextBox textboxMPIReceiptNo;
        private System.Windows.Forms.DataGridView gridviewManagePurchasedItems;
        private System.Windows.Forms.GroupBox groupBoxPurchaseitems2;
        private System.Windows.Forms.ComboBox comboboxMPIItemName;
        private System.Windows.Forms.TextBox textboxMPIPrice;
        private System.Windows.Forms.Button buttonMPIAddItem;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox textboxMPIQuantity;
        private System.Windows.Forms.ComboBox comboboxMPICategoryName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxManageShippingItemsItemName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxManageShippingItemsCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxShippingItemsCarryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShippingItemsMarkerNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxShippingItemsCarryCharges;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonShippingItemsSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridView dataGridViewManageShippingItemsAddItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label labelOrderedItems;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.ComboBox comboBoxOrderCustomername;
        private System.Windows.Forms.Label labelOrderedCustomerName;
        private System.Windows.Forms.ComboBox comboBoxOrderedItemName;
        private System.Windows.Forms.Button buttonOrderedItemSave;
        private System.Windows.Forms.TextBox textBoxOrderedQuantity;
        private System.Windows.Forms.ComboBox comboBoxOrderCategoryname;
        private System.Windows.Forms.Label labelOrderItemName;
        private System.Windows.Forms.Label labelOrderCategoryName;
        private System.Windows.Forms.Label labelOrderedQuantity;
        private System.Windows.Forms.Label labelOrderedDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderedDate;
    }
}