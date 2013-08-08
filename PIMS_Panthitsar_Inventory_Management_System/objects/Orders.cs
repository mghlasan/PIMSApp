using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Orders
    {
        private string orderID;
        private double amountDue;
        private DateTime date;
        private string supplierID;

        public Orders()
        { }

        public string OrderID { get; set; }

        public double AmountDue { get; set; }

        public DateTime Date { get; set; }

        public string SupplierID { get; set; } 
    }
}
