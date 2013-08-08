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
    public partial class WarehouseManagement : Form
    {
        public WarehouseManagement()
        {
            InitializeComponent();

            List<string> stockInOutList = new List<string>();
            stockInOutList.Add("In");
            stockInOutList.Add("Out");

            comboBoxWMStockInOut.DataSource = stockInOutList;

            List<string> categoryList = new List<string>();
            categoryList.Add("Wintre Coat");
            categoryList.Add("T-Shirt");
            categoryList.Add("Skirt");
            categoryList.Add("Shirt");

            comboBoxWMCategoryName.DataSource = categoryList;

            List<string> itemList = new List<string>();
            itemList.Add("V-Shape Tee");
            itemList.Add("Wool Coat");
            itemList.Add("Denim soft Jean");
            itemList.Add("Shirt - (Long Sleeve with Sports)");

            comboBoxWMItemName.DataSource = itemList;

            textBoxWMQuantity.Text = "200";

            textBoxWMStockBalance.Text = "850";
        }
    }
}
