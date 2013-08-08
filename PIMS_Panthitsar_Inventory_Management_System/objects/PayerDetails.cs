using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class PayerDetails
    {
        private string payerDetailID;
        private string capitalID;
        private string payerID;

        public PayerDetails()
        { }

        public string PayerDetailID { get; set; }

        public string CapitalID { get; set; }

        public string PayerID { get; set; }
    }
}
