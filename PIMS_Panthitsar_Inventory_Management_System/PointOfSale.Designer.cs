namespace PIMS_Panthitsar_Inventory_Management_System
{
    partial class PointOfSale
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
            this.groupBoxPOSSlipInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxPointOfSalesCustomerName = new System.Windows.Forms.ComboBox();
            this.comboBoxPointOSalesPaymentMode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPOS = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPOSDate = new System.Windows.Forms.Label();
            this.labelPOSPaymentMode = new System.Windows.Forms.Label();
            this.labelReceiptNo = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesReceiptNo = new System.Windows.Forms.TextBox();
            this.buttonPointOfSalesSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxPOSCPaymentInfo = new System.Windows.Forms.GroupBox();
            this.textBoxPointOfSalesCurrentTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxPointOfSalesPaidAmount = new System.Windows.Forms.TextBox();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.buttonPOSSubmit = new System.Windows.Forms.Button();
            this.labelPOSReceiptNoError = new System.Windows.Forms.Label();
            this.groupBoxPOSSlipInfo.SuspendLayout();
            this.groupBoxPOSCPaymentInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxPOSSlipInfo.Location = new System.Drawing.Point(11, 54);
            this.groupBoxPOSSlipInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPOSSlipInfo.Name = "groupBoxPOSSlipInfo";
            this.groupBoxPOSSlipInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPOSSlipInfo.Size = new System.Drawing.Size(641, 206);
            this.groupBoxPOSSlipInfo.TabIndex = 23;
            this.groupBoxPOSSlipInfo.TabStop = false;
            // 
            // comboBoxPointOfSalesCustomerName
            // 
            this.comboBoxPointOfSalesCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointOfSalesCustomerName.FormattingEnabled = true;
            this.comboBoxPointOfSalesCustomerName.Location = new System.Drawing.Point(204, 167);
            this.comboBoxPointOfSalesCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPointOfSalesCustomerName.Name = "comboBoxPointOfSalesCustomerName";
            this.comboBoxPointOfSalesCustomerName.Size = new System.Drawing.Size(224, 21);
            this.comboBoxPointOfSalesCustomerName.TabIndex = 23;
            this.comboBoxPointOfSalesCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPointOfSalesCustomerName_SelectedIndexChanged);
            // 
            // comboBoxPointOSalesPaymentMode
            // 
            this.comboBoxPointOSalesPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointOSalesPaymentMode.FormattingEnabled = true;
            this.comboBoxPointOSalesPaymentMode.Location = new System.Drawing.Point(204, 118);
            this.comboBoxPointOSalesPaymentMode.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPointOSalesPaymentMode.Name = "comboBoxPointOSalesPaymentMode";
            this.comboBoxPointOSalesPaymentMode.Size = new System.Drawing.Size(224, 21);
            this.comboBoxPointOSalesPaymentMode.TabIndex = 23;
            // 
            // dateTimePickerPOS
            // 
            this.dateTimePickerPOS.Location = new System.Drawing.Point(204, 32);
            this.dateTimePickerPOS.Name = "dateTimePickerPOS";
            this.dateTimePickerPOS.Size = new System.Drawing.Size(224, 20);
            this.dateTimePickerPOS.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name:";
            // 
            // labelPOSDate
            // 
            this.labelPOSDate.AutoSize = true;
            this.labelPOSDate.Location = new System.Drawing.Point(209, 15);
            this.labelPOSDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPOSDate.Name = "labelPOSDate";
            this.labelPOSDate.Size = new System.Drawing.Size(33, 13);
            this.labelPOSDate.TabIndex = 1;
            this.labelPOSDate.Text = "Date:";
            // 
            // labelPOSPaymentMode
            // 
            this.labelPOSPaymentMode.AutoSize = true;
            this.labelPOSPaymentMode.Location = new System.Drawing.Point(209, 100);
            this.labelPOSPaymentMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPOSPaymentMode.Name = "labelPOSPaymentMode";
            this.labelPOSPaymentMode.Size = new System.Drawing.Size(81, 13);
            this.labelPOSPaymentMode.TabIndex = 3;
            this.labelPOSPaymentMode.Text = "Payment Mode:";
            // 
            // labelReceiptNo
            // 
            this.labelReceiptNo.AutoSize = true;
            this.labelReceiptNo.Location = new System.Drawing.Point(209, 58);
            this.labelReceiptNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReceiptNo.Name = "labelReceiptNo";
            this.labelReceiptNo.Size = new System.Drawing.Size(64, 13);
            this.labelReceiptNo.TabIndex = 8;
            this.labelReceiptNo.Text = "Receipt No:";
            // 
            // textBoxPointOfSalesReceiptNo
            // 
            this.textBoxPointOfSalesReceiptNo.Location = new System.Drawing.Point(206, 73);
            this.textBoxPointOfSalesReceiptNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPointOfSalesReceiptNo.Name = "textBoxPointOfSalesReceiptNo";
            this.textBoxPointOfSalesReceiptNo.Size = new System.Drawing.Size(224, 20);
            this.textBoxPointOfSalesReceiptNo.TabIndex = 12;
            this.textBoxPointOfSalesReceiptNo.MouseLeave += new System.EventHandler(this.textBoxPointOfSalesReceiptNo_MouseLeave);
            // 
            // buttonPointOfSalesSave
            // 
            this.buttonPointOfSalesSave.Location = new System.Drawing.Point(91, 522);
            this.buttonPointOfSalesSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPointOfSalesSave.Name = "buttonPointOfSalesSave";
            this.buttonPointOfSalesSave.Size = new System.Drawing.Size(89, 28);
            this.buttonPointOfSalesSave.TabIndex = 19;
            this.buttonPointOfSalesSave.Text = "Save";
            this.buttonPointOfSalesSave.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(265, 8);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(131, 23);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Point of Sales";
            // 
            // groupBoxPOSCPaymentInfo
            // 
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.textBoxPointOfSalesCurrentTotal);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.label5);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.textBoxPointOfSalesDiscount);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.labelDiscount);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.textBoxPointOfSalesPaidAmount);
            this.groupBoxPOSCPaymentInfo.Controls.Add(this.labelPaidAmount);
            this.groupBoxPOSCPaymentInfo.Location = new System.Drawing.Point(16, 394);
            this.groupBoxPOSCPaymentInfo.Name = "groupBoxPOSCPaymentInfo";
            this.groupBoxPOSCPaymentInfo.Size = new System.Drawing.Size(273, 155);
            this.groupBoxPOSCPaymentInfo.TabIndex = 29;
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
            // buttonPOSSubmit
            // 
            this.buttonPOSSubmit.Location = new System.Drawing.Point(307, 277);
            this.buttonPOSSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPOSSubmit.Name = "buttonPOSSubmit";
            this.buttonPOSSubmit.Size = new System.Drawing.Size(89, 28);
            this.buttonPOSSubmit.TabIndex = 30;
            this.buttonPOSSubmit.Text = "Submit";
            this.buttonPOSSubmit.UseVisualStyleBackColor = true;
            this.buttonPOSSubmit.Click += new System.EventHandler(this.buttonPOSSubmit_Click);
            // 
            // labelPOSReceiptNoError
            // 
            this.labelPOSReceiptNoError.AutoSize = true;
            this.labelPOSReceiptNoError.BackColor = System.Drawing.SystemColors.Control;
            this.labelPOSReceiptNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPOSReceiptNoError.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelPOSReceiptNoError.Location = new System.Drawing.Point(443, 75);
            this.labelPOSReceiptNoError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPOSReceiptNoError.Name = "labelPOSReceiptNoError";
            this.labelPOSReceiptNoError.Size = new System.Drawing.Size(12, 15);
            this.labelPOSReceiptNoError.TabIndex = 31;
            this.labelPOSReceiptNoError.Text = "*";
            // 
            // PointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 564);
            this.Controls.Add(this.buttonPOSSubmit);
            this.Controls.Add(this.groupBoxPOSCPaymentInfo);
            this.Controls.Add(this.groupBoxPOSSlipInfo);
            this.Controls.Add(this.buttonPointOfSalesSave);
            this.Controls.Add(this.labelTitle);
            this.Name = "PointOfSale";
            this.Text = "PointOfSale";
            this.groupBoxPOSSlipInfo.ResumeLayout(false);
            this.groupBoxPOSSlipInfo.PerformLayout();
            this.groupBoxPOSCPaymentInfo.ResumeLayout(false);
            this.groupBoxPOSCPaymentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPOSSlipInfo;
        private System.Windows.Forms.Button buttonPointOfSalesSave;
        private System.Windows.Forms.Label labelPOSDate;
        private System.Windows.Forms.Label labelPOSPaymentMode;
        private System.Windows.Forms.Label labelReceiptNo;
        private System.Windows.Forms.TextBox textBoxPointOfSalesReceiptNo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerPOS;
        private System.Windows.Forms.ComboBox comboBoxPointOfSalesCustomerName;
        private System.Windows.Forms.ComboBox comboBoxPointOSalesPaymentMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPOSCPaymentInfo;
        private System.Windows.Forms.TextBox textBoxPointOfSalesCurrentTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPointOfSalesDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxPointOfSalesPaidAmount;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Button buttonPOSSubmit;
        private System.Windows.Forms.Label labelPOSReceiptNoError;
    }
}