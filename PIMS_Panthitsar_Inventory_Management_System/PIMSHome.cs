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
    public partial class FormPIMSHome : Form
    {
        public FormPIMSHome()
        {
            InitializeComponent();
        }

        private void buttonPointOFSale_Click(object sender, EventArgs e)
        {
            PointOfSale pos = new PointOfSale();
            pos.Show();
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            WarehouseManagement warehouseManagement = new WarehouseManagement();
            warehouseManagement.Show();
        }

        private void buttonCapital_Click(object sender, EventArgs e)
        {
            CapitalManagement capitalmanagement = new CapitalManagement();

            capitalmanagement.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonfunction_Click(object sender, EventArgs e)
        {
            ConfigurationManagement configurationManagement = new ConfigurationManagement();
            configurationManagement.Show();
        }

        private void buttonOrderItems_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagegemnt = new OrderManagement();
            orderManagegemnt.Show();
        }
    }
}
