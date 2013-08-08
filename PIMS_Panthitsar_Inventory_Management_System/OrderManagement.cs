using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIMS_Panthitsar_Inventory_Management_System
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();

            List<string> categoryList = new List<string>();
            categoryList.Add("Wintre Coat");
            categoryList.Add("T-Shirt");
            categoryList.Add("Skirt");
            categoryList.Add("Shirt");
            comboboxMPICategoryName.DataSource = categoryList;
            comboBoxManageShippingItemsCategoryName.DataSource = categoryList;
            comboBoxOrderCategoryname.DataSource = categoryList;
           

            List<string> itemList = new List<string>();
            itemList.Add("V-Shape Tee");
            itemList.Add("Wool Coat");
            itemList.Add("Denim soft Jean");
            itemList.Add("Shirt - (Long Sleeve with Sports)");
            comboboxMPIItemName.DataSource = itemList;
            comboBoxManageShippingItemsItemName.DataSource = itemList;
            comboBoxOrderedItemName.DataSource = itemList;

            List<string> supplierList = new List<string>();
            supplierList.Add("ABC Trading");
            supplierList.Add("Shun Lee Enterprise");
            supplierList.Add("Amazon");
            comboboxMPISupplierName.DataSource = supplierList;

            List<string> carryList = new List<string>();
            carryList.Add("Mann Shwe Li");
            carryList.Add("Miba Myitta");
            carryList.Add("Taung Paw Thar");
            comboBoxShippingItemsCarryName.DataSource = carryList;

            List<string> customerList = new List<string>();
            customerList.Add("Prasad");
            customerList.Add("Gokul");
            customerList.Add("Maynu");
            comboBoxOrderCustomername.DataSource = customerList;
        }

        private void buttonMPISavePurchasedItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdakfjals");
            
        }
    }
}
