using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PIMS_Panthitsar_Inventory_Management_System.objects;
using PIMS_Panthitsar_Inventory_Management_System.util;

namespace PIMS_Panthitsar_Inventory_Management_System
{
    public partial class PointOfSale : Form
    {
        public PointOfSale()
        {
            InitializeComponent();
            LoadPOSPage();
            List<string> paymentModeList = new List<string>();
            paymentModeList.Add("Cash");
            paymentModeList.Add("Partial");
            paymentModeList.Add("Credit");
            comboBoxPointOSalesPaymentMode.DataSource = paymentModeList;


            List<string> customerList = new List<string>();
            customerList.Add("James Bond");
            customerList.Add("Harry Porter");
            customerList.Add("Mr Bean");
            //comboBoxPointOfSalesCustomerName.DataSource = customerList;
            comboBoxPointOfSalesCustomerName.DataSource = DBCustomers.Instance.GetCustomerNameList();
            comboBoxPointOfSalesCustomerName.DisplayMember = "CustomerName";
            comboBoxPointOfSalesCustomerName.ValueMember = "CustomerID";

            

            List<string> itemList = new List<string>();
            itemList.Add("V-Shape Tee");
            itemList.Add("Wool Coat");
            itemList.Add("Denim soft Jean");
            itemList.Add("Shirt - (Long Sleeve with Sports)");
            //comboBoxPointOfSalesItemName.DataSource = itemList;

            
            
        }

        private void LoadPOSPage()
        {
            List<string> paymentModeList = new List<string>();
            paymentModeList.Add("Cash");
            paymentModeList.Add("Partial");
            paymentModeList.Add("Credit");
            comboBoxPointOSalesPaymentMode.DataSource = paymentModeList;

            comboBoxPointOfSalesCustomerName.DataSource = DBCustomers.Instance.GetCustomerNameList();
            comboBoxPointOfSalesCustomerName.DisplayMember = "CustomerName";
            comboBoxPointOfSalesCustomerName.ValueMember = "CustomerID";

            getCustomerDetailsByID();


            GetItemsByCategoryID();
        }

        private void GetItemsByCategoryID()
        {
            Items item = new Items();
           // item.CategoryID = comboBoxPointOfSalesCategoryName.SelectedValue.ToString();
            List<string> itemList = new List<string>();
            itemList.Add("V-Shape Tee");
            itemList.Add("Wool Coat");
            itemList.Add("Denim soft Jean");
            itemList.Add("Shirt - (Long Sleeve with Sports)");
           // comboBoxPointOfSalesItemName.DataSource = DBUtil.Instance.GetItemsListByCategoryID(item);
           // comboBoxPointOfSalesItemName.DisplayMember = "ItemName";
            //comboBoxPointOfSalesItemName.ValueMember = "ItemID";
        }

        private void comboBoxPointOfSalesCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
            getCustomerDetailsByID();
        }

        private List<Customers> getCustomerDetailsByID()
          
        {
            Customers customer = new Customers();
            string selectcustomer = comboBoxPointOfSalesCustomerName.SelectedValue.ToString();
            customer.CustomerID = selectcustomer;
            List<Customers> list = new List<Customers>();
            list = DBCustomers.Instance.GetCustomerDetailsByID(customer);
            foreach (Customers c in list)
            {
            //   textBoxPointOfSalesCustomerName.Text = c.CustomerName.ToString();
              // textBoxPointOfSalesCustomerAddress.Text = c.Address.ToString();
              //  textBoxPointOfSalesCreditAmount.Text = c.DebitDue.ToString();
            }
            return list;
        }

        private void comboBoxPointOfSalesCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetItemsByCategoryID();
        }

        private void buttonPOSSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxPointOfSalesReceiptNo.Text.Equals(""))
            {
                labelPOSReceiptNoError.Text = "Receip Number cannot be emptied.";
            }
            else
            {
                string receiptNo = textBoxPointOfSalesReceiptNo.Text.ToString();
                string paymentMode = comboBoxPointOSalesPaymentMode.SelectedValue.ToString();
                List<Customers> list = getCustomerDetailsByID();
                POSAddPurchasedItems posItems = new POSAddPurchasedItems(list, receiptNo, paymentMode);
                posItems.Show();
            }
        }

        private void textBoxPointOfSalesReceiptNo_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPointOfSalesReceiptNo.Text.Equals(""))
            {
                labelPOSReceiptNoError.Text = "Receip Number cannot be emptied.";
            }
        }
    }
}
