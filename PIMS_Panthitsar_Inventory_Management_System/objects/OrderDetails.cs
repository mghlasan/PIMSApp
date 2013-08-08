using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class OrderDetails
    {
        private string orderDetailsID;
        private string orderID;
        private string itemID;
        private double price;
        private int quantity;

        public OrderDetails()
        { }

        public string  OrderDetailsID { get; set; }

        public string  OrderID { get; set; }

        public string  ItemID { get; set; }

        public double  Price { get; set; }

        public int Quantity { get; set; }


    }
}
