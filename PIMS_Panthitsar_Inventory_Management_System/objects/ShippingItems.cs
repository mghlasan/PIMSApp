using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class ShippingItems
    {

        private string shippingItemID;
        private DateTime date;
        private string bagNo;
        private string shippingAgencyID;

        public string ShippingItemID { get; set; }

        public DateTime Date { get; set; }

        public string BagNo { get; set; }

        public string ShippingAgencyID { get; set; }
    }
}
