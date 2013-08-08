using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using PIMS_Panthitsar_Inventory_Management_System.objects;
using PIMS_Panthitsar_Inventory_Management_System.util;
using Microsoft.Practices.EnterpriseLibrary.Validation;

namespace PIMS_Panthitsar_Inventory_Management_System
{
    public partial class ConfigurationManagement : Form
    {

        public ConfigurationManagement()
        {
            InitializeComponent();
            PopulateSupplierGridView();
            groupBoxNewSupplierInfo.Hide();
            buttonConfigureNewSupplierSave.Hide();
            groupBoxItemConfigurationAddItemInfo.Hide();

            List<string> categoryList = new List<string>();
            categoryList.Add("Wintre Coat");
            categoryList.Add("T-Shirt");
            categoryList.Add("Skirt");
            categoryList.Add("Shirt");

            comboBoxItemConfigManagementItemCategoryName.DataSource = DBCategories.Instance.GetCategoryList();
            comboBoxItemConfigManagementItemCategoryName.DisplayMember = "CategoryName";
            comboBoxItemConfigManagementItemCategoryName.ValueMember = "CategoryID";
            List<string> supplierList = new List<string>();
            supplierList.Add("ABC Trading");
            supplierList.Add("Shun Lee Enterprise");
            supplierList.Add("Amazon");

            comboBoxConfigManagementItemSupplierName.DataSource = DBSuppliers.Instance.GetSupplierList();
            comboBoxConfigManagementItemSupplierName.DisplayMember = "SupplierName";
            comboBoxConfigManagementItemSupplierName.ValueMember = "SupplierID";
            // tabControlConfigurationManagement.TabIndexChanged += new EventHandler(tabControlConfigurationManagement_TabIndexChanged);
        }

        private void buttonConfigurationAdd_Click(object sender, EventArgs e)
        {
            groupBoxNewSupplierInfo.Show();
            buttonConfigureNewSupplierSave.Show();
        }

        private void buttonItemAddNew_Click(object sender, EventArgs e)
        {
            groupBoxItemConfigurationAddItemInfo.Show();
        }

        private void buttonItemInfoBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg)|*.jpg";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    //Process.Start(fileName);
                    textBoxItemInfoImage.Text = openFileDialog.InitialDirectory + openFileDialog.FileName;
                }
            }
        }

        private void buttonItemSave_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            Boolean update = false;
            int selectedRow = dataGridViewItemDetails.CurrentRow.Index;
            if (buttonItemSave.Text.Equals("Save"))
            {

                StringBuilder sb = new StringBuilder();

                // item.ItemID = textBoxItemItemID.Text.ToString();
                item.ItemName = textBoxItemItemName.Text.ToString();
                item.CategoryID = comboBoxItemConfigManagementItemCategoryName.SelectedValue.ToString();
                // item.CategoryID = "C0001";
                item.SupplierID = comboBoxConfigManagementItemSupplierName.SelectedValue.ToString();
                //item.SupplierID = "S0001";
                item.ImagePath = textBoxItemInfoImage.Text.ToString();
                Validator validator = ValidationFactory.CreateValidator<Items>();
                ValidationResults vResult = new ValidationResults();
                validator.Validate(item, vResult);

                if (!vResult.IsValid)
                {
                    int index = 1;
                    foreach (ValidationResult vr in vResult)
                    {
                        sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                        index++;
                    }

                    labelConfigurationItemError.Text = sb.ToString();
                    MessageBox.Show(sb.ToString());

                    return;
                }
                Boolean insert = DBUtil.Instance.AddNewItem(item);
                if (insert)
                {
                    Console.WriteLine("Inserted");
                    MessageBox.Show("Inserted");
                }

                populateItemGridView();
            }

            else
            {
                //Items item = new Items();
                // item.ItemID = dataGridViewItemDetails.Rows[selectedRow].Cells["ItemID"].Value.ToString();
                item.ItemID = textBoxItemItemID.Text.ToString();
                item.ItemName = textBoxItemItemName.Text.ToString();
                // item.ItemName = dataGridViewItemDetails.Rows[selectedRow].Cells["ItemName"].Value.ToString();

                item.CategoryID = (string)comboBoxItemConfigManagementItemCategoryName.SelectedValue;
                //  item.CategoryID = dataGridViewItemDetails.Rows[selectedRow].Cells["CategoryID"].Value.ToString();
                //item.CategoryID = "C0001";
                // item.SupplierID = "S0001";
                item.SupplierID = (string)comboBoxConfigManagementItemSupplierName.SelectedValue;
                // item.SupplierID = dataGridViewItemDetails.Rows[selectedRow].Cells["SupplierID"].Value.ToString();
                item.ImagePath = textBoxItemInfoImage.Text.ToString();
                Boolean validator = ValidateItem(item);
                if (!validator)
                {
                    return;
                }
                update = DBUtil.Instance.UpdateSelectedItem(item);


                if (update)
                {
                    Console.WriteLine("Inserted");
                    MessageBox.Show("Updated");
                }
                populateItemGridView();
            }

        }

        private Boolean  ValidateItem(Items item)
        {
            Boolean validate = true; 
            StringBuilder sb = new StringBuilder();
            Validator validator = ValidationFactory.CreateValidator<Items>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(item, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());
               // break;
                validate = false;
            }
            return validate;
        }

        private void tabControlConfigurationManagement_TabIndexChanged(object sender, EventArgs e)
        {
            List<Items> list = new List<Items>();
            if (tabControlConfigurationManagement.TabIndex == 2)
            {
                list = DBUtil.Instance.GetItemsList();
                dataGridViewItemDetails.DataSource = list;

            }
        }

        private void tabControlConfigurationManagement_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Items> list = new List<Items>();
            int index = tabControlConfigurationManagement.SelectedIndex;

            if (index == 2)
            {
                populateItemGridView();
                groupBoxItemConfigurationAddItemInfo.Visible = false;
            }

            else if (index == 0)
            {
                PopulateSupplierGridView();
                groupBoxNewSupplierInfo.Visible = false;
            }

            else if (index == 1)
            {
                PopulateCategoryGridView();
                groupBoxNewCategoryInfo.Visible = false;
            }

            else if (index == 3)
            {
                PopulatePayersGridView();
                groupBoxNewPayerInfo.Visible = false;
                labelPayer.Visible = false;
            }

            else if (index == 4)
            {
                PopulatePayeesGridView();
                groupBoxNewPayeeInfo.Visible = false;
               // labelPayer.Visible = false;
            }

            else if (index == 5)
            {
                PopulateBankGridView();
                groupBoxConfigManagementBankInfo.Visible = false;
            }

            else if (index == 6)
            {
                PopulateUsersGridView();
                groupBoxNewUserInfo.Visible = false;
            }

            else if (index == 7)
            {
                PopulateCustomersGridView();
                groupBoxNewCustomerInfo.Visible = false;
            }

            else if (index == 8)
            {
                PopulateShippingAgenciesGridView();
                groupBoxNewShippingAgencyInfo.Visible = false;
            }


        }

        private void PopulateSupplierGridView()
        {
            List<Suppliers> list = new List<Suppliers>();
            list = DBSuppliers.Instance.GetSuppliersDetails();
            BindingSource _source = new BindingSource();
            _source.DataSource = list;
            dataGridViewSupplierInfoSupplierDetail.DataSource = _source;
            dataGridViewSupplierInfoSupplierDetail.Columns["DeleteSupplier"].DisplayIndex = 0;
            dataGridViewSupplierInfoSupplierDetail.Columns["SupplierID"].DisplayIndex =1 ;
            dataGridViewSupplierInfoSupplierDetail.Columns["SupplierName"].DisplayIndex = 2;            
            dataGridViewSupplierInfoSupplierDetail.Columns["CreditDue"].DisplayIndex = 3;
            dataGridViewSupplierInfoSupplierDetail.Columns["Address"].DisplayIndex = 4;            
            dataGridViewSupplierInfoSupplierDetail.Columns["Phone"].DisplayIndex = 5;
            dataGridViewSupplierInfoSupplierDetail.Columns["Email"].DisplayIndex = 6;
            dataGridViewSupplierInfoSupplierDetail.Columns["Status"].Visible = false;

        }

        private void PopulateBankGridView()
        {
            List<Banks> list = new List<Banks>();
            list = DBBanks.Instance.GetBanksDetails();
            BindingSource _source = new BindingSource();
            _source.DataSource = list;
            dataGridViewBankDetails.DataSource = _source;
            dataGridViewBankDetails.Columns["DeleteBank"].DisplayIndex = 0;
            dataGridViewBankDetails.Columns["BankID"].DisplayIndex = 1;
            dataGridViewBankDetails.Columns["BankName"].DisplayIndex = 2;
            dataGridViewBankDetails.Columns["Address"].DisplayIndex = 3;
            dataGridViewBankDetails.Columns["Phone"].DisplayIndex = 4;
            dataGridViewBankDetails.Columns["Email"].DisplayIndex = 5;
           

        }

        private void PopulateCustomersGridView()
        {
            List<Customers> list = new List<Customers>();
            list = DBCustomers.Instance.GetCustomersDetails();
            BindingSource _source = new BindingSource();
            _source.DataSource = list;
            dataGridViewCustomerDetails.DataSource = _source;
            dataGridViewCustomerDetails.Columns["DeleteCustomer"].DisplayIndex = 0;
            dataGridViewCustomerDetails.Columns["CustomerID"].DisplayIndex = 1;
            dataGridViewCustomerDetails.Columns["CustomerName"].DisplayIndex = 2;
            dataGridViewCustomerDetails.Columns["DebitDue"].DisplayIndex = 3;
            dataGridViewCustomerDetails.Columns["Address"].DisplayIndex =4;
            dataGridViewCustomerDetails.Columns["Phone"].DisplayIndex = 5;
            dataGridViewCustomerDetails.Columns["Email"].DisplayIndex = 6;
        }


        private void PopulateUsersGridView()
        {

            List<System_Users> list = new List<System_Users>();
            list = DBUsers.Instance.GetUsersDetails();
            BindingSource _source = new BindingSource();
            _source.DataSource = list;
            dataGridViewUserDetails.DataSource = _source;
            dataGridViewUserDetails.Columns["DeleteUser"].DisplayIndex = 0;
            dataGridViewUserDetails.Columns["UserID"].DisplayIndex = 1;
            dataGridViewUserDetails.Columns["UserName"].DisplayIndex = 2;
             dataGridViewUserDetails.Columns["Role"].DisplayIndex = 3;
            dataGridViewUserDetails.Columns["Address"].DisplayIndex = 4;
            dataGridViewUserDetails.Columns["Phone"].DisplayIndex = 5;
            dataGridViewUserDetails.Columns["Email"].DisplayIndex = 6;
        }

        private void PopulateShippingAgenciesGridView()
        {
            List<ShippingAgencies> list = new List<ShippingAgencies>();
            list = DBShippingAgencies.Instance.GetShippingAgencyDetails();
            BindingSource _source = new BindingSource();
            _source.DataSource = list;
            dataGridViewShippingAgency.DataSource = _source;
            dataGridViewShippingAgency.Columns["DeleteShippingAgency"].DisplayIndex = 0;
            dataGridViewShippingAgency.Columns["ShippingAgencyID"].DisplayIndex = 1;
            dataGridViewShippingAgency.Columns["ShippingAgencyName"].DisplayIndex = 2;
            dataGridViewShippingAgency.Columns["Address"].DisplayIndex = 3;
            dataGridViewShippingAgency.Columns["Phone"].DisplayIndex = 4;
            dataGridViewShippingAgency.Columns["Email"].DisplayIndex = 5;
        }
         private void PopulatePayersGridView()
        {
            List<Payers> list = new List<Payers>();
            list = DBPayers.Instance.GetPayersDetails();
            BindingSource _source = new BindingSource();
            _source.DataSource = list;
            dataGridViewPayerDetails.DataSource = _source;
            dataGridViewPayerDetails.Columns["DeletePayer"].DisplayIndex = 0;
            dataGridViewPayerDetails.Columns["PayerID"].DisplayIndex = 1;
            dataGridViewPayerDetails.Columns["PayerName"].DisplayIndex = 2;
            dataGridViewPayerDetails.Columns["Address"].DisplayIndex = 3;
            dataGridViewPayerDetails.Columns["Phone"].DisplayIndex = 4;
            dataGridViewPayerDetails.Columns["Email"].DisplayIndex = 5;

        }

         private void PopulatePayeesGridView()
         {
             List<Payees> list = new List<Payees>();
             list = DBPayees.Instance.GetPayeesDetails();
             BindingSource _source = new BindingSource();
             _source.DataSource = list;
             dataGridViewPayeeDetails.DataSource = _source;
             dataGridViewPayeeDetails.Columns["DeletePayee"].DisplayIndex = 0;
             dataGridViewPayeeDetails.Columns["PayeeID"].DisplayIndex = 1;
             dataGridViewPayeeDetails.Columns["PayeeName"].DisplayIndex = 2;
             dataGridViewPayeeDetails.Columns["Address"].DisplayIndex = 3;
             dataGridViewPayeeDetails.Columns["Phone"].DisplayIndex = 4;
             dataGridViewPayeeDetails.Columns["Email"].DisplayIndex = 5;

         }

        private void PopulateCategoryGridView()
        {
            List<Categories> list = new List<Categories>();
            list = DBCategories.Instance.GetCategoryList();
            BindingSource _source = new BindingSource();
            _source.DataSource = list;
            dataGridViewCategoryDetails.DataSource = _source;
            dataGridViewCategoryDetails.Columns["DeleteCategory"].DisplayIndex = 0;
            dataGridViewCategoryDetails.Columns["CategoryID"].DisplayIndex = 1;
            dataGridViewCategoryDetails.Columns["CategoryName"].DisplayIndex = 2;            
           // dataGridViewSupplierInfoSupplierDetail.Columns["Status"].Visible = false;

        }
        private void populateItemGridView()
        {
            List<Items> list = new List<Items>();
            list = DBUtil.Instance.GetItemsList();
            DataTable dt = new DataTable();
            
            dt.Columns.Add("ItemID");
            dt.Columns.Add("ItemName");
            dt.Columns.Add("CategoryName");
            dt.Columns.Add("SupplierName");
            dt.Columns.Add("Stock");
            dt.Columns.Add("Image2");
            dt.Columns.Add("Image3",typeof(Bitmap));
            for (int i = 0; i < list.Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr["ItemID"] = list[i].ItemID.ToString();
                dr["ItemName"] = list[i].ItemName.ToString();
                dr["CategoryName"] = list[i].CategoryName.ToString();
                dr["SupplierName"] = list[i].SupplierName.ToString();
                dr["Stock"] = list[i].Stock.ToString();
                dr["Image2"] = list[i].ImagePath.ToString();
                //dr["Image3"] = list[i].ImagePath.ToString();
                
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = null;
                image = Image.FromFile(list[i].ImagePath.ToString());
                img.Image = image;
                //dr["Image"] = img;
                img.Name = "ImageColumn";

               

                if (dataGridViewItemDetails.Columns["ImageColumn"] != null)
                {
                    dataGridViewItemDetails.Columns.Remove("ImageColumn");
                }
                else if (dataGridViewItemDetails.Columns["ImageColumn"] == null)
                {
                   // ((DataGridViewImageColumn)this.dataGridViewItemDetails.Columns["ImageColumn"]).DefaultCellStyle.NullValue = null;
                }
                dataGridViewItemDetails.Columns.Add(img);
                img.HeaderText = "Image";
                //img.Name = "img";
                dt.Rows.Add(dr);
            }

            //dataGridViewItemDetails.Refresh();
            dataGridViewItemDetails.DataSource = AutoNumberedTable(dt);
            AdjustColumnOrder();
            this.dataGridViewItemDetails.AllowUserToResizeColumns = true;
            this.dataGridViewItemDetails.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dataGridViewItemDetails.Columns["ItemID"].ReadOnly = true;
            dataGridViewItemDetails.Columns["Stock"].ReadOnly = true;
            dataGridViewItemDetails.Columns["Sr.No."].ReadOnly = true;
            dataGridViewItemDetails.Columns["Image2"].Visible = false;
        }

        private void AdjustColumnOrder()
        {
            //  dataGridViewItemDetails.Columns["Sr.No."].Visible = false;
            dataGridViewItemDetails.Columns["Sr.No."].DisplayIndex = 0;
            dataGridViewItemDetails.Columns["Delete"].DisplayIndex = 1;
            dataGridViewItemDetails.Columns["ItemID"].DisplayIndex = 2;
            dataGridViewItemDetails.Columns["ItemName"].DisplayIndex = 3;
            dataGridViewItemDetails.Columns["SupplierName"].DisplayIndex = 4;
            dataGridViewItemDetails.Columns["SupplierName"].DisplayIndex = 5;
            dataGridViewItemDetails.Columns["Stock"].DisplayIndex = 6;
            dataGridViewItemDetails.Columns["ImageColumn"].DisplayIndex = 7;
        }

        private DataTable AutoNumberedTable(DataTable SourceTable)
        {

            DataTable ResultTable = new DataTable();

            DataColumn AutoNumberColumn = new DataColumn();

            AutoNumberColumn.ColumnName = "Sr.No.";

            AutoNumberColumn.DataType = typeof(int);

            AutoNumberColumn.AutoIncrement = true;

            AutoNumberColumn.AutoIncrementSeed = 1;

            AutoNumberColumn.AutoIncrementStep = 1;

            ResultTable.Columns.Add(AutoNumberColumn);

            ResultTable.Merge(SourceTable);

            return ResultTable;

        }
        // Update button click
        private void buttonItemtabUpdateItem_Click(object sender, EventArgs e)
        {
            // int selectedRowCount = dataGridViewItemDetails.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRow = dataGridViewItemDetails.CurrentRow.Index;
            labelUploadImage.Visible = true;
            textBoxItemInfoImage.Visible = true;
            buttonItemInfoBrowse.Visible = true;
            textBoxItemItemID.Enabled = false;
           // textBoxItemItemID.Visible = false;
           // labelItemItemID.Visible = false;
            groupBoxItemConfigurationAddItemInfo.Show();

            textBoxItemItemID.Text = dataGridViewItemDetails.Rows[selectedRow].Cells["ItemID"].Value.ToString();
            textBoxItemItemName.Text = dataGridViewItemDetails.Rows[selectedRow].Cells["ItemName"].Value.ToString();
            textBoxItemInfoImage.Text = dataGridViewItemDetails.Rows[selectedRow].Cells["Image2"].Value.ToString();
            string categoryName = dataGridViewItemDetails.Rows[selectedRow].Cells["CategoryName"].Value.ToString();
           // comboBoxItemConfigManagementItemCategoryName.SelectedItem.ToString();
            if (!comboBoxItemConfigManagementItemCategoryName.SelectedItem.ToString().Equals(categoryName))
            {
                int index = 0;
                foreach(Categories  item in comboBoxItemConfigManagementItemCategoryName.Items)
                {
                    
                //comboBoxItemConfigManagementItemCategoryName.SelectedItem = categoryName.ToString();
                    if(item.CategoryName.Equals(categoryName))
                    {
                        comboBoxItemConfigManagementItemCategoryName.SelectedItem = comboBoxItemConfigManagementItemCategoryName.Items.IndexOf((item.CategoryName));
                       // index = comboBoxItemConfigManagementItemCategoryName.Items.IndexOf(item.CategoryName);
                        break;
                    }

                  
                }

                
               
                
            }
            buttonItemSave.Text = "Update";
            // dataGridViewItemDetails.Rows[selectedRow].Cells["ItemID"].ReadOnly = true;


        }



        private void dataGridViewItemDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewItemDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewItemDetails.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["Delete"];
            // DataGridViewCell checkcell = row.Cells[1];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                Items item = new Items();
                item.ItemID = row.Cells["ItemID"].Value.ToString();
                item.Status = "deActive";
                bool result = DBUtil.Instance.DeleteSelectedItem(item);
                dataGridViewItemDetails.Rows.RemoveAt(index);
                populateItemGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }

        }

        private void comboBoxItemConfigManagementItemCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSupplierAdd_Click(object sender, EventArgs e)
        {
            groupBoxNewSupplierInfo.Show();
            buttonConfigureNewSupplierSave.Show();
        }

        private void buttonConfigureNewSupplierSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int currentRow = dataGridViewSupplierInfoSupplierDetail.CurrentRow.Index;
            Suppliers supplier = new Suppliers();
             supplier.SupplierID= dataGridViewSupplierInfoSupplierDetail.Rows[currentRow].Cells["SupplierID"].Value.ToString();
            supplier.SupplierName = textBoxSupplierSupplierName.Text.ToString();
            supplier.Phone = textBoxSupplierInfoPhoneNo.Text.ToString();
            supplier.Email = textBoxSupplierEmail.Text.ToString();
            supplier.Address = textBoxSupplierInfoAddress.Text.ToString();          

            Validator validator = ValidationFactory.CreateValidator<Suppliers>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(supplier, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }
            if (buttonConfigureNewSupplierSave.Text.ToString().Equals("Save"))
            {
                bool intert = DBSuppliers.Instance.AddNewSupplier(supplier);
                PopulateSupplierGridView();
            }
            else 
            {
                bool update = DBSuppliers.Instance.UpdateSelectedSupplier(supplier);
                PopulateSupplierGridView();
            }

        }

        private void buttonSupplierUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewSupplierInfoSupplierDetail.CurrentRow.Index;

            textBoxSupplierSupplierName.Text = dataGridViewSupplierInfoSupplierDetail.Rows[currentRow].Cells["SupplierName"].Value.ToString();
            textBoxSupplierInfoPhoneNo.Text = dataGridViewSupplierInfoSupplierDetail.Rows[currentRow].Cells["Phone"].Value.ToString();
            textBoxSupplierEmail.Text = dataGridViewSupplierInfoSupplierDetail.Rows[currentRow].Cells["Email"].Value.ToString();
            textBoxSupplierInfoAddress.Text = dataGridViewSupplierInfoSupplierDetail.Rows[currentRow].Cells["Address"].Value.ToString();
            groupBoxNewSupplierInfo.Show();
            buttonConfigureNewSupplierSave.Visible = true;
            buttonConfigureNewSupplierSave.Text = "Update";
        }

        private void dataGridViewSupplierInfoSupplierDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSupplierInfoSupplierDetail.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();
           

            row = dataGridViewSupplierInfoSupplierDetail.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeleteSupplier"];
            // DataGridViewCell checkcell = row.Cells[1];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                Suppliers supplier = new Suppliers();
                supplier.SupplierID = row.Cells["SupplierID"].Value.ToString();
                supplier.Status = "InActive";
                bool result = DBSuppliers.Instance.DeleteSelectedSupplier(supplier);
                dataGridViewSupplierInfoSupplierDetail.Rows.RemoveAt(index);
                PopulateSupplierGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }

        private void buttonCategoryAddNew_Click(object sender, EventArgs e)
        {
            textBoxCategoryCategoryID.Visible = false;
            labelConfigurationCategoryID.Visible = false;
            groupBoxNewCategoryInfo.Visible = true;
        }

        private void buttonCategorySave_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
            Categories category = new Categories();
            category.CategoryID = textBoxCategoryCategoryID.Text.ToString();
            category.CategoryName = textBoxCategoryCategoryName.Text.ToString();
            Validator validator = ValidationFactory.CreateValidator<Categories>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(category, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }

            if (buttonCategorySave.Text.ToString().Equals("Save"))
            {

                bool intert = DBCategories.Instance.AddNewCategory(category);
                PopulateCategoryGridView();
            }

            else 
            {
                bool update = DBCategories.Instance.UpdateSelectedCategory(category);
                PopulateCategoryGridView();
            }
        }

        private void buttonCategoryUpdate_Click(object sender, EventArgs e)
        {
            labelConfigurationCategoryID.Visible = true;
            textBoxCategoryCategoryID.Visible = true;
            groupBoxNewCategoryInfo.Visible = true;
            buttonCategorySave.Text = "Update";
            buttonCategorySave.Visible = true;
            int currentRow = dataGridViewCategoryDetails.CurrentRow.Index;
            textBoxCategoryCategoryID.Text = dataGridViewCategoryDetails.Rows[currentRow].Cells["CategoryID"].Value.ToString();
            textBoxCategoryCategoryName.Text = dataGridViewCategoryDetails.Rows[currentRow].Cells["CategoryName"].Value.ToString();
            textBoxCategoryCategoryID.Enabled = false;
        }

        private void dataGridViewCategoryDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCategoryDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewCategoryDetails.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeleteCategory"];
            // DataGridViewCell checkcell = row.Cells[1];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                Categories category = new Categories();
                category.CategoryID= row.Cells["CategoryID"].Value.ToString();
                bool result = DBCategories.Instance.DeleteSelectedCategory(category);
                dataGridViewCategoryDetails.Rows.RemoveAt(index);
                PopulateCategoryGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }

        private void buttonBankAddNew_Click(object sender, EventArgs e)
        {
            labelBankID.Visible = false;
            textBoxBankID.Visible = false;
            groupBoxConfigManagementBankInfo.Visible = true;
            
        }

        private void buttonBankSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Banks bank = new Banks();
            bank.BankID = textBoxBankID.Text.ToString();
            bank.BankName = textBoxBankName.Text.ToString();
            bank.Phone = textBoxBankPhoneNo.Text.ToString();
            bank.Email = textBoxBankEmail.Text.ToString();
            bank.Address = textBoxBankAddress.Text.ToString();

            Validator validator = ValidationFactory.CreateValidator<Banks>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(bank, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }

            if (buttonBankSave.Text.ToString().Equals("Save"))
            {
                bool intert = DBBanks.Instance.AddNewBank(bank);
                PopulateBankGridView();
            }
            else
            {
                bool update = DBBanks.Instance.UpdateSelectedBanks(bank);
                PopulateBankGridView();
            }

        }

        private void buttonBankUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewBankDetails.CurrentRow.Index;
            textBoxBankID.Text = dataGridViewBankDetails.Rows[currentRow].Cells["BankID"].Value.ToString();
            textBoxBankName.Text = dataGridViewBankDetails.Rows[currentRow].Cells["BankName"].Value.ToString();
            textBoxBankEmail.Text = dataGridViewBankDetails.Rows[currentRow].Cells["Email"].Value.ToString();
            textBoxBankPhoneNo.Text = dataGridViewBankDetails.Rows[currentRow].Cells["Phone"].Value.ToString();
            textBoxBankAddress.Text = dataGridViewBankDetails.Rows[currentRow].Cells["Address"].Value.ToString();
            textBoxBankID.Visible = true;
            labelBankID.Visible = true;
            textBoxBankID.Enabled = false;
            groupBoxConfigManagementBankInfo.Visible = true;
            buttonBankSave.Text = "Update";

        }

        private void dataGridViewBankDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewBankDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewBankDetails.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeleteBank"];            
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                Banks bank = new Banks();
                bank.BankID = row.Cells["BankID"].Value.ToString();               
                bool result = DBBanks.Instance.DeleteSelectedBank(bank);
                dataGridViewBankDetails.Rows.RemoveAt(index);
                PopulateBankGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }

        private void buttonPayerAddNew_Click(object sender, EventArgs e)
        {
            labelPayerID.Visible = false;
            textBoxPayerID.Visible = false;
            labelPayer.Visible = true;
            groupBoxNewPayerInfo.Visible = true;
            textBoxPayerAddress.Text = null;
            textBoxPayerEmail.Text = null;
            textBoxPayerPhoneNo.Text = null;
            textBoxConfigurationPayerName.Text = null;

        }

        private void buttonPayerSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Payers payer  = new Payers();
            payer.PayerID = textBoxPayerID.Text.ToString();
            payer.PayerName = textBoxConfigurationPayerName.Text.ToString();
            payer.Phone = textBoxPayerPhoneNo.Text.ToString();
            payer.Address = textBoxPayerAddress.Text.ToString();
            payer.Email = textBoxPayerEmail.Text.ToString();

            Validator validator = ValidationFactory.CreateValidator<Payers>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(payer, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }

            if (buttonPayerSave.Text.ToString().Equals("Save"))
            {
                bool intert = DBPayers.Instance.AddNewPayers(payer);
                PopulatePayersGridView();
                groupBoxNewPayerInfo.Visible = false;
            }
            else
            {
                bool update = DBPayers.Instance.UpdateSelectedPayers(payer);
                PopulatePayersGridView();
                groupBoxNewPayerInfo.Visible = false;
            }

        }

        private void buttonPayerUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewPayerDetails.CurrentRow.Index;
            textBoxPayerID.Text = dataGridViewPayerDetails.Rows[currentRow].Cells["PayerID"].Value.ToString();
            textBoxConfigurationPayerName.Text = dataGridViewPayerDetails.Rows[currentRow].Cells["PayerName"].Value.ToString();
            textBoxPayerEmail.Text = dataGridViewPayerDetails.Rows[currentRow].Cells["Email"].Value.ToString();
            textBoxPayerPhoneNo.Text = dataGridViewPayerDetails.Rows[currentRow].Cells["Phone"].Value.ToString();
            textBoxPayerAddress.Text = dataGridViewPayerDetails.Rows[currentRow].Cells["Address"].Value.ToString();
            textBoxPayerID.Visible = true;
            labelPayerID.Visible = true;
            textBoxPayerID.Enabled = false;
            groupBoxNewPayerInfo.Visible = true;
            buttonPayerSave.Text = "Update";
        }

        private void dataGridViewPayerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPayerDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewPayerDetails.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeletePayer"];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                Payers payer = new Payers();
                payer.PayerID = row.Cells["PayerID"].Value.ToString();
                bool result = DBPayers.Instance.DeleteSelectedPayer(payer);
                dataGridViewPayerDetails.Rows.RemoveAt(index);
                PopulatePayersGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }

        private void buttonPayeeAddNew_Click(object sender, EventArgs e)
        {
            textBoxPayeeID.Visible = false;
            labelPayeePayeeID.Visible = false;
            textBoxPayeeName.Text = null;
            textBoxPayeePhoneNo.Text = null;
            textBoxPayeeEmail.Text = null;
            textBoxPayeeAddress.Text = null;
            buttonPayeeSave.Text = "Save";
            groupBoxNewPayeeInfo.Visible = true;
        }

        private void buttonPayeeUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewPayeeDetails.CurrentRow.Index;
            textBoxPayeeID.Text = dataGridViewPayeeDetails.Rows[currentRow].Cells["PayeeID"].Value.ToString();
            textBoxPayeeName.Text = dataGridViewPayeeDetails.Rows[currentRow].Cells["PayeeName"].Value.ToString();
            textBoxPayeeEmail.Text = dataGridViewPayeeDetails.Rows[currentRow].Cells["Email"].Value.ToString();
            textBoxPayeePhoneNo.Text = dataGridViewPayeeDetails.Rows[currentRow].Cells["Phone"].Value.ToString();
            textBoxPayeeAddress.Text = dataGridViewPayeeDetails.Rows[currentRow].Cells["Address"].Value.ToString();
            textBoxPayeeID.Visible = true;
            labelPayeePayeeID.Visible = true;
            textBoxPayeeID.Enabled = false;
            groupBoxNewPayeeInfo.Visible = true;
            buttonPayeeSave.Text = "Update";
        }

        private void buttonPayeeSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Payees payee = new Payees();
            payee.PayeeID = textBoxPayeeID.Text.ToString();
            payee.PayeeName = textBoxPayeeName.Text.ToString();
            payee.Phone = textBoxPayeePhoneNo.Text.ToString();
            payee.Address = textBoxPayeeAddress.Text.ToString();
            payee.Email = textBoxPayeeEmail.Text.ToString();

            Validator validator = ValidationFactory.CreateValidator<Payees>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(payee, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }

            if (buttonPayeeSave.Text.ToString().Equals("Save"))
            {
                bool intert = DBPayees.Instance.AddNewPayees(payee);
                PopulatePayeesGridView();
                groupBoxNewPayeeInfo.Visible = false;
            }
            else
            {
                bool update = DBPayees.Instance.UpdateSelectedPayees(payee);
                PopulatePayeesGridView();
                groupBoxNewPayeeInfo.Visible = false;
            }
        }

        private void dataGridViewPayeeDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPayeeDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewPayeeDetails.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeletePayee"];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                Payees payee = new Payees();
                payee.PayeeID = row.Cells["PayeeID"].Value.ToString();
                bool result = DBPayees.Instance.DeleteSelectedPayee(payee);
                dataGridViewPayeeDetails.Rows.RemoveAt(index);
                PopulatePayeesGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }

        private void buttonUserAddNew_Click(object sender, EventArgs e)
        {
            textBoxUserID.Visible = false;
            labelUserID.Visible = false;
            textBoxUserName.Text = null;
            textBoxUserPhoneNo.Text = null;
            textBoxUserEmail.Text = null;
            textBoxUserAddress.Text = null;
            buttonUserSave.Text = "Save";
            groupBoxNewUserInfo.Visible = true;
        }

        private void buttonUserUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewUserDetails.CurrentRow.Index;
            textBoxUserID.Text = dataGridViewUserDetails.Rows[currentRow].Cells["UserID"].Value.ToString();
            textBoxUserName.Text = dataGridViewUserDetails.Rows[currentRow].Cells["UserName"].Value.ToString();
            textBoxUserEmail.Text = dataGridViewUserDetails.Rows[currentRow].Cells["Email"].Value.ToString();
            textBoxUserPhoneNo.Text = dataGridViewUserDetails.Rows[currentRow].Cells["Phone"].Value.ToString();
            textBoxUserAddress.Text = dataGridViewUserDetails.Rows[currentRow].Cells["Address"].Value.ToString();
            textBoxUserID.Visible = true;
            labelUserID.Visible = true;
            textBoxUserID.Enabled = false;
            groupBoxNewUserInfo.Visible = true;
            buttonUserSave.Text = "Update";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            System_Users user = new System_Users();
            user.UserID = textBoxUserID.Text.ToString();
            user.UserName = textBoxUserName.Text.ToString();
            user.Phone = textBoxUserPhoneNo.Text.ToString();
            user.Address = textBoxUserAddress.Text.ToString();
            user.Email = textBoxUserEmail.Text.ToString();
            user.Role = comboBoxUserRole.SelectedItem.ToString();

            Validator validator = ValidationFactory.CreateValidator<System_Users>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(user, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }

            if (buttonUserSave.Text.ToString().Equals("Save"))
            {
                bool intert = DBUsers.Instance.AddNewUser(user);
                PopulateUsersGridView();
                groupBoxNewUserInfo.Visible = false;
            }
            else
            {
                bool update = DBUsers.Instance.UpdateSelectedUsers(user);
                PopulateUsersGridView();
                groupBoxNewUserInfo.Visible = false;
            }
        }

        private void dataGridViewUserDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewUserDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewUserDetails.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeleteUser"];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                System_Users user = new System_Users();
                user.UserID = row.Cells["UserID"].Value.ToString();
                bool result = DBUsers.Instance.DeleteSelectedUser(user);
                dataGridViewUserDetails.Rows.RemoveAt(index);
                PopulateUsersGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }

        private void labelCustomerAddress_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustomerAddNew_Click(object sender, EventArgs e)
        {

            textBoxCustomerID.Visible = false;
            labelCustomerID.Visible = false;
            textBoxCustomerName.Text = null;
            textBoxCustomerPhoneNo.Text = null;
            textBoxCustomerEmail.Text = null;
            textBoxCustomerAddress.Text = null;
            buttonCustomerSave.Text = "Save";
            groupBoxNewCustomerInfo.Visible = true;
        }

        private void buttonCustomerUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewCustomerDetails.CurrentRow.Index;
            textBoxCustomerID.Text = dataGridViewCustomerDetails.Rows[currentRow].Cells["CustomerID"].Value.ToString();
            textBoxCustomerName.Text = dataGridViewCustomerDetails.Rows[currentRow].Cells["CustomerName"].Value.ToString();
            textBoxCustomerEmail.Text = dataGridViewCustomerDetails.Rows[currentRow].Cells["Email"].Value.ToString();
            textBoxCustomerPhoneNo.Text = dataGridViewCustomerDetails.Rows[currentRow].Cells["Phone"].Value.ToString();
            textBoxCustomerAddress.Text = dataGridViewCustomerDetails.Rows[currentRow].Cells["Address"].Value.ToString();
            textBoxCustomerID.Visible = true;
            labelCustomerID.Visible = true;
            textBoxUserID.Enabled = false;
            groupBoxNewCustomerInfo.Visible = true;
            buttonCustomerSave.Text = "Update";
        }

        private void buttonCustomerSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Customers customer = new Customers();
            customer.CustomerID = textBoxCustomerID.Text.ToString();
            customer.CustomerName = textBoxCustomerName.Text.ToString();
            customer.Phone = textBoxCustomerPhoneNo.Text.ToString();
            customer.Address = textBoxCustomerAddress.Text.ToString();
            customer.Email = textBoxCustomerEmail.Text.ToString();


            Validator validator = ValidationFactory.CreateValidator<Customers>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(customer, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }

            if (buttonCustomerSave.Text.ToString().Equals("Save"))
            {
                bool intert = DBCustomers.Instance.AddNewCustomers(customer);
                PopulateCustomersGridView();
                groupBoxNewCustomerInfo.Visible = false;
            }
            else
            {
                bool update = DBCustomers.Instance.UpdateSelectedCustomers(customer);
                PopulateCustomersGridView();
                groupBoxNewCustomerInfo.Visible = false;
            }
        }

        private void dataGridViewCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCustomerDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewCustomerDetails.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeleteCustomer"];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                Customers customer = new Customers();
                customer.CustomerID = row.Cells["CustomerID"].Value.ToString();
                bool result = DBCustomers.Instance.DeleteSelectedCustomer(customer);
                dataGridViewCustomerDetails.Rows.RemoveAt(index);
                PopulateCustomersGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }

        private void buttonNewShippingAgencyAddNew_Click(object sender, EventArgs e)
        {
            textBoxShippingID.Visible = false;
            labelShippingID.Visible = false;
            textBoxShippingAgencyName.Text = null;
            textBoxShippingAgencyPhone.Text = null;
            textBoxShippingAgencyEmail.Text = null;
            textBoxShippingAgencyAddress.Text = null;
            buttonNewShippingSave.Text = "Save";
            groupBoxNewShippingAgencyInfo.Visible = true;
        }

        private void buttonShippingAgencyUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewShippingAgency.CurrentRow.Index;
            textBoxShippingID.Text = dataGridViewShippingAgency.Rows[currentRow].Cells["ShippingAgencyID"].Value.ToString();
            textBoxShippingAgencyName.Text = dataGridViewShippingAgency.Rows[currentRow].Cells["ShippingAgencyName"].Value.ToString();
            textBoxShippingAgencyName.Text = dataGridViewShippingAgency.Rows[currentRow].Cells["Email"].Value.ToString();
            textBoxShippingAgencyPhone.Text = dataGridViewShippingAgency.Rows[currentRow].Cells["Phone"].Value.ToString();
            textBoxShippingAgencyAddress.Text = dataGridViewShippingAgency.Rows[currentRow].Cells["Address"].Value.ToString();
            textBoxPayeeID.Visible = true;
            labelShippingID.Visible = true;
            textBoxShippingID.Enabled = false;
            groupBoxNewShippingAgencyInfo.Visible = true;
            buttonNewShippingSave.Text = "Update";
        }

        private void buttonNewShippingSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ShippingAgencies shippingAgency = new ShippingAgencies();
            shippingAgency.ShippingAgencyID = textBoxShippingID.Text.ToString();
            shippingAgency.ShippingAgencyName= textBoxShippingAgencyName.Text.ToString();
            shippingAgency.Phone = textBoxShippingAgencyPhone.Text.ToString();
            shippingAgency.Address = textBoxShippingAgencyAddress.Text.ToString();
            shippingAgency.Email = textBoxShippingAgencyEmail.Text.ToString();

            Validator validator = ValidationFactory.CreateValidator<ShippingAgencies>();
            ValidationResults vResult = new ValidationResults();
            validator.Validate(shippingAgency, vResult);

            if (!vResult.IsValid)
            {
                int index = 1;
                foreach (ValidationResult vr in vResult)
                {
                    sb.Append(string.Format("{0} - {1} \n", index, vr.Message));
                    index++;
                }

                labelConfigurationItemError.Text = sb.ToString();
                MessageBox.Show(sb.ToString());

                return;
            }

            if (buttonNewShippingSave.Text.ToString().Equals("Save"))
            {
                bool intert = DBShippingAgencies.Instance.AddNewShippingAgencies(shippingAgency);
                PopulateShippingAgenciesGridView();
                groupBoxNewShippingAgencyInfo.Visible = false;
            }
            else
            {
                bool update = DBShippingAgencies.Instance.UpdateSelectedShippingAgencies(shippingAgency);
                PopulateShippingAgenciesGridView();
                groupBoxNewShippingAgencyInfo.Visible = false;
            }
        }

        private void dataGridViewShippingAgency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewShippingAgency.CommitEdit(DataGridViewDataErrorContexts.Commit);
            DataGridViewRow row = new DataGridViewRow();


            row = dataGridViewShippingAgency.CurrentRow;
            int index = row.Index;
            DataGridViewCell checkcell = row.Cells["DeleteShippingAgency"];
            int cellIndex = row.Cells.IndexOf(checkcell);
            if (e.ColumnIndex.Equals(cellIndex))
            {
                ShippingAgencies shippingAgency = new ShippingAgencies();
                shippingAgency.ShippingAgencyID = row.Cells["ShippingAgencyID"].Value.ToString();
                bool result = DBShippingAgencies.Instance.DeleteSelectedShippingAgencies(shippingAgency);
                dataGridViewShippingAgency.Rows.RemoveAt(index);
                PopulateShippingAgenciesGridView();
                if (result)
                {
                    Console.WriteLine("Deleted");
                }
            }
        }



    }
}
