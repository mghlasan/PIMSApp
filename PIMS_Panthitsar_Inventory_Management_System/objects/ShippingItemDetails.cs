using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class ShippingItemDetails
    {

        private string shippingItemDetailsID;
        private double shippingFee;
        private int quantity;
        private string shippingItemID;
        private string itemID;

        public ShippingItemDetails()
        { }


        public string ShippingItemDetailsID { get; set; }

        public double ShippingFee { get; set; }

        public int Quantity { get; set; }

        public string ShippingItemID { get; set; }

        public string ItemID { get; set; }
    }
}
