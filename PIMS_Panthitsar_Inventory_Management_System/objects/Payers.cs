using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Payers
    {
        private string payerID;
        private string payerName;
        private string email;
        private string phone;
        private string address;

        public Payers()
        { }


        public string PayerID { get; set; }

        public string PayerName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
