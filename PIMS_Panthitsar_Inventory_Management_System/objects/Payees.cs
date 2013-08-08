using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Payees
    {
        private string payeeID;
        private string payeeName;
        private string email;
        private string phone;
        private string address;

        public Payees()
        { }


        public string PayeeID { get; set; }

        public string PayeeName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

    }
}
