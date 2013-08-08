using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIMS_Panthitsar_Inventory_Management_System.objects;
using PIMS_Panthitsar_Inventory_Management_System.util;

namespace PIMS_Panthitsar_Inventory_Management_System
{
    public partial class POSAddPurchasedItems : Form
    {
        List<Customers> custChildlist = null;
        string receiptNo = null;
        string paymentMode = null;
        public POSAddPurchasedItems(List<Customers> custList,string receiptno, string paymentmode)
        {
            InitializeComponent();
            receiptNo = receiptno;
            paymentMode = paymentmode;
            custChildlist = custList;
            LoadPOSAddPurchasedItems();

        }

        private void LoadPOSAddPurchasedItems()
        {
          List<Categories> list =DBCategories.Instance.GetCategoryList();
          
            Categories c = new Categories();
            c.CategoryName = "Select a Category";
            c.CategoryID =" 0";
            list.Insert(0, c);
            comboBoxPointOfSalesCategoryName.DataSource = list;
            comboBoxPointOfSalesCategoryName.DisplayMember = "CategoryName";
            comboBoxPointOfSalesCategoryName.ValueMember = "CategoryID";
           
          

           // comboBoxPointOfSalesCategoryName.Items.Insert(0, "Select a Category");
            labelPOSReceiptData.Text = receiptNo;
            labelPaymentData.Text = paymentMode;
            GetItemsByCategoryID();
            getCustomerDetailsByID();
        }

        private void GetItemsByCategoryID()
        {
            Items item = new Items();
            item.CategoryID = comboBoxPointOfSalesCategoryName.SelectedValue.ToString();
            List<Items> list = DBUtil.Instance.GetItemsListByCategoryID(item);
            Items item2 = new Items();
            item2.ItemID = "0";
            item2.ItemName = "----";
            list.Insert(0, item2);
            comboBoxPointOfSalesItemName.DataSource = list;
            comboBoxPointOfSalesItemName.DisplayMember = "ItemName";
            comboBoxPointOfSalesItemName.ValueMember = "ItemID";
        }

        private void getCustomerDetailsByID()
        {          
           
            foreach (Customers c in custChildlist)
            {
                textBoxPointOfSalesCustomerName.Text = c.CustomerName.ToString();
                textBoxPointOfSalesCustomerAddress.Text = c.Address.ToString();
                textBoxPointOfSalesCreditAmount.Text = c.DebitDue.ToString();
            }
        }

        private void comboBoxPointOfSalesCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
              GetItemsByCategoryID();
        }

       
      
    }
}
