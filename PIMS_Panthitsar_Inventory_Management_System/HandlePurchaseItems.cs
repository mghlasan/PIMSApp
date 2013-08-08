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
    public partial class HandlePurchaseItems : Form
    {
        public HandlePurchaseItems()
        {
            InitializeComponent();

            List<string> categoryList = new List<string>();
            categoryList.Add("Wintre Coat");
            categoryList.Add("T-Shirt");
            categoryList.Add("Skirt");
            categoryList.Add("Shirt");
            comboBoxPurchasedItemsCategoryName.DataSource = categoryList;

            List<string> itemList = new List<string>();
            itemList.Add("V-Shape Tee");
            itemList.Add("Wool Coat");
            itemList.Add("Denim soft Jean");
            itemList.Add("Shirt - (Long Sleeve with Sports)");
            comboBoxPurchasedItemsItemName.DataSource = itemList;

            List<string> supplierList = new List<string>();
            supplierList.Add("ABC Trading");
            supplierList.Add("Shun Lee Enterprise");
            supplierList.Add("Amazon");
            comboBoxPurchasedItemsSupplierName.DataSource = supplierList;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
