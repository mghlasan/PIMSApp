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
    public partial class CapitalManagement : Form
    {
        public CapitalManagement()
        {
            InitializeComponent();

            List<string> payeeList = new List<string>();
            payeeList.Add("Pita");            
            payeeList.Add("Prasaad Dhai");
            comboboxManageCapitalPayerName.DataSource = payeeList;

            List<string> bankList = new List<string>();
            bankList.Add("Kanbawza Bank");
            bankList.Add("Asia Wealth Bank");
            comboBoxManageCapitalBankName.DataSource = bankList;

            List<string> categoryList = new List<string>();
            categoryList.Add("Household Bill");
            categoryList.Add("Utilities Bill");
            categoryList.Add("Carry Bill");
            comboBoxManageExpenseCategory.DataSource = categoryList;

            List<string> carryList = new List<string>();
            carryList.Add("Mann Shwe Li");
            carryList.Add("Miba Myitta");
            carryList.Add("Taung Paw Thar");
            comboBoxManageExpenseCarryName.DataSource = carryList;

            textBoxManageExpenseAvailableCapital.Text = "100,000.00";

        }

        private void buttonMPISavePurchasedItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Money has been sum up as total money.");
        }
    }
}
