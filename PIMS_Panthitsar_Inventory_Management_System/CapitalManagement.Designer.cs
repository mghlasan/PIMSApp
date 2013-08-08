namespace PIMS_Panthitsar_Inventory_Management_System
{
    partial class CapitalManagement
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
            this.TabPanelCapitalManagement = new System.Windows.Forms.TabControl();
            this.ManageCapital = new System.Windows.Forms.TabPage();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMPISavePurchasedItems = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.textBoxManageCapitalAmountReceivedInYuan = new System.Windows.Forms.TextBox();
            this.textBoxManageCapitalAmountExchangeRate = new System.Windows.Forms.TextBox();
            this.textBoxManageCapitalAmountReceivedInKyat = new System.Windows.Forms.TextBox();
            this.comboBoxManageCapitalBankName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxManageCapitalPayerName = new System.Windows.Forms.ComboBox();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.ManageExpense = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxManageExpensePaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxManageExpenseAvailableCapital = new System.Windows.Forms.TextBox();
            this.comboBoxManageExpenseCarryName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxManageExpenseCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TabPanelCapitalManagement.SuspendLayout();
            this.ManageCapital.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ManageExpense.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPanelCapitalManagement
            // 
            this.TabPanelCapitalManagement.Controls.Add(this.ManageCapital);
            this.TabPanelCapitalManagement.Controls.Add(this.ManageExpense);
            this.TabPanelCapitalManagement.Location = new System.Drawing.Point(12, 12);
            this.TabPanelCapitalManagement.Name = "TabPanelCapitalManagement";
            this.TabPanelCapitalManagement.SelectedIndex = 0;
            this.TabPanelCapitalManagement.Size = new System.Drawing.Size(730, 586);
            this.TabPanelCapitalManagement.TabIndex = 0;
            // 
            // ManageCapital
            // 
            this.ManageCapital.BackColor = System.Drawing.Color.Gainsboro;
            this.ManageCapital.Controls.Add(this.labelTitle);
            this.ManageCapital.Controls.Add(this.groupBox1);
            this.ManageCapital.Location = new System.Drawing.Point(4, 23);
            this.ManageCapital.Name = "ManageCapital";
            this.ManageCapital.Padding = new System.Windows.Forms.Padding(3);
            this.ManageCapital.Size = new System.Drawing.Size(722, 559);
            this.ManageCapital.TabIndex = 0;
            this.ManageCapital.Text = "Manage Capital";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(290, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(140, 22);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Manage Capital";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMPISavePurchasedItems);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelPaidAmount);
            this.groupBox1.Controls.Add(this.textBoxManageCapitalAmountReceivedInYuan);
            this.groupBox1.Controls.Add(this.textBoxManageCapitalAmountExchangeRate);
            this.groupBox1.Controls.Add(this.textBoxManageCapitalAmountReceivedInKyat);
            this.groupBox1.Controls.Add(this.comboBoxManageCapitalBankName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboboxManageCapitalPayerName);
            this.groupBox1.Controls.Add(this.labelCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(187, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 351);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // buttonMPISavePurchasedItems
            // 
            this.buttonMPISavePurchasedItems.Location = new System.Drawing.Point(119, 295);
            this.buttonMPISavePurchasedItems.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonMPISavePurchasedItems.Name = "buttonMPISavePurchasedItems";
            this.buttonMPISavePurchasedItems.Size = new System.Drawing.Size(89, 28);
            this.buttonMPISavePurchasedItems.TabIndex = 20;
            this.buttonMPISavePurchasedItems.Text = "Save";
            this.buttonMPISavePurchasedItems.UseVisualStyleBackColor = true;
            this.buttonMPISavePurchasedItems.Click += new System.EventHandler(this.buttonMPISavePurchasedItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount Received (Yuan):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Exchange Rate:";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(61, 119);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(155, 16);
            this.labelPaidAmount.TabIndex = 17;
            this.labelPaidAmount.Text = "Amount Received (Kyat):";
            // 
            // textBoxManageCapitalAmountReceivedInYuan
            // 
            this.textBoxManageCapitalAmountReceivedInYuan.Location = new System.Drawing.Point(66, 252);
            this.textBoxManageCapitalAmountReceivedInYuan.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxManageCapitalAmountReceivedInYuan.Multiline = false;
            this.textBoxManageCapitalAmountReceivedInYuan.Name = "textBoxManageCapitalAmountReceivedInYuan";
            this.textBoxManageCapitalAmountReceivedInYuan.Size = new System.Drawing.Size(219, 30);
            this.textBoxManageCapitalAmountReceivedInYuan.TabIndex = 18;
            // 
            // textBoxManageCapitalAmountExchangeRate
            // 
            this.textBoxManageCapitalAmountExchangeRate.Location = new System.Drawing.Point(66, 197);
            this.textBoxManageCapitalAmountExchangeRate.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxManageCapitalAmountExchangeRate.Multiline = false;
            this.textBoxManageCapitalAmountExchangeRate.Name = "textBoxManageCapitalAmountExchangeRate";
            this.textBoxManageCapitalAmountExchangeRate.Size = new System.Drawing.Size(219, 30);
            this.textBoxManageCapitalAmountExchangeRate.TabIndex = 18;
            // 
            // textBoxManageCapitalAmountReceivedInKyat
            // 
            this.textBoxManageCapitalAmountReceivedInKyat.Location = new System.Drawing.Point(66, 140);
            this.textBoxManageCapitalAmountReceivedInKyat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxManageCapitalAmountReceivedInKyat.Multiline = false;
            this.textBoxManageCapitalAmountReceivedInKyat.Name = "textBoxManageCapitalAmountReceivedInKyat";
            this.textBoxManageCapitalAmountReceivedInKyat.Size = new System.Drawing.Size(219, 30);
            this.textBoxManageCapitalAmountReceivedInKyat.TabIndex = 18;
            // 
            // comboBoxManageCapitalBankName
            // 
            this.comboBoxManageCapitalBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManageCapitalBankName.FormattingEnabled = true;
            this.comboBoxManageCapitalBankName.Location = new System.Drawing.Point(66, 93);
            this.comboBoxManageCapitalBankName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxManageCapitalBankName.Name = "comboBoxManageCapitalBankName";
            this.comboBoxManageCapitalBankName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxManageCapitalBankName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bank Name:";
            // 
            // comboboxManageCapitalPayerName
            // 
            this.comboboxManageCapitalPayerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxManageCapitalPayerName.FormattingEnabled = true;
            this.comboboxManageCapitalPayerName.Location = new System.Drawing.Point(66, 46);
            this.comboboxManageCapitalPayerName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboboxManageCapitalPayerName.Name = "comboboxManageCapitalPayerName";
            this.comboboxManageCapitalPayerName.Size = new System.Drawing.Size(219, 21);
            this.comboboxManageCapitalPayerName.TabIndex = 13;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(61, 28);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(87, 16);
            this.labelCategoryName.TabIndex = 12;
            this.labelCategoryName.Text = "Payer Name:";
            // 
            // ManageExpense
            // 
            this.ManageExpense.BackColor = System.Drawing.Color.Gainsboro;
            this.ManageExpense.Controls.Add(this.label4);
            this.ManageExpense.Controls.Add(this.groupBox2);
            this.ManageExpense.Location = new System.Drawing.Point(4, 23);
            this.ManageExpense.Name = "ManageExpense";
            this.ManageExpense.Padding = new System.Windows.Forms.Padding(3);
            this.ManageExpense.Size = new System.Drawing.Size(722, 559);
            this.ManageExpense.TabIndex = 1;
            this.ManageExpense.Text = "Manage Expense";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Manage Expense";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxManageExpensePaidAmount);
            this.groupBox2.Controls.Add(this.textBoxManageExpenseAvailableCapital);
            this.groupBox2.Controls.Add(this.comboBoxManageExpenseCarryName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxManageExpenseCategory);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(187, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 303);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Available Capital:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Paid Amount:";
            // 
            // textBoxManageExpensePaidAmount
            // 
            this.textBoxManageExpensePaidAmount.Location = new System.Drawing.Point(66, 202);
            this.textBoxManageExpensePaidAmount.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxManageExpensePaidAmount.Multiline = false;
            this.textBoxManageExpensePaidAmount.Name = "textBoxManageExpensePaidAmount";
            this.textBoxManageExpensePaidAmount.Size = new System.Drawing.Size(219, 30);
            this.textBoxManageExpensePaidAmount.TabIndex = 18;
            // 
            // textBoxManageExpenseAvailableCapital
            // 
            this.textBoxManageExpenseAvailableCapital.Location = new System.Drawing.Point(66, 53);
            this.textBoxManageExpenseAvailableCapital.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxManageExpenseAvailableCapital.Name = "textBoxManageExpenseAvailableCapital";
            this.textBoxManageExpenseAvailableCapital.ReadOnly = true;
            this.textBoxManageExpenseAvailableCapital.Size = new System.Drawing.Size(219, 22);
            this.textBoxManageExpenseAvailableCapital.TabIndex = 18;
            // 
            // comboBoxManageExpenseCarryName
            // 
            this.comboBoxManageExpenseCarryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManageExpenseCarryName.FormattingEnabled = true;
            this.comboBoxManageExpenseCarryName.Location = new System.Drawing.Point(66, 155);
            this.comboBoxManageExpenseCarryName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxManageExpenseCarryName.Name = "comboBoxManageExpenseCarryName";
            this.comboBoxManageExpenseCarryName.Size = new System.Drawing.Size(219, 21);
            this.comboBoxManageExpenseCarryName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Carry Name:";
            // 
            // comboBoxManageExpenseCategory
            // 
            this.comboBoxManageExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManageExpenseCategory.FormattingEnabled = true;
            this.comboBoxManageExpenseCategory.Location = new System.Drawing.Point(66, 108);
            this.comboBoxManageExpenseCategory.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBoxManageExpenseCategory.Name = "comboBoxManageExpenseCategory";
            this.comboBoxManageExpenseCategory.Size = new System.Drawing.Size(219, 21);
            this.comboBoxManageExpenseCategory.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Category:";
            // 
            // CapitalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 610);
            this.Controls.Add(this.TabPanelCapitalManagement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)), true);
            this.Name = "CapitalManagement";
            this.Text = "CapitalManagement";
            this.TabPanelCapitalManagement.ResumeLayout(false);
            this.ManageCapital.ResumeLayout(false);
            this.ManageCapital.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ManageExpense.ResumeLayout(false);
            this.ManageExpense.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPanelCapitalManagement;
        private System.Windows.Forms.TabPage ManageCapital;
        private System.Windows.Forms.TabPage ManageExpense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxManageCapitalBankName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxManageCapitalPayerName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.TextBox textBoxManageCapitalAmountReceivedInYuan;
        private System.Windows.Forms.TextBox textBoxManageCapitalAmountExchangeRate;
        private System.Windows.Forms.TextBox textBoxManageCapitalAmountReceivedInKyat;
        private System.Windows.Forms.Button buttonMPISavePurchasedItems;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxManageExpenseAvailableCapital;
        private System.Windows.Forms.TextBox textBoxManageExpensePaidAmount;
        private System.Windows.Forms.ComboBox comboBoxManageExpenseCarryName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxManageExpenseCategory;
        private System.Windows.Forms.Label label9;
    }
}