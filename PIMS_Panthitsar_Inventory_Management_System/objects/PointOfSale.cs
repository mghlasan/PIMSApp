using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class PointOfSale
    {
        public PointOfSale()
        { }


        public string POSID { get; set; }

        public string ReceiptNO { get; set; }

        public string PaymentMode { get; set; }

        public DateTime TrasactionDate { get; set; }

        public string CustomerID { get; set; }

        public double  TransactionAmount { get; set; }

        public double TotalPaid { get; set; }

        public double Discount { get; set; }
    }
}
