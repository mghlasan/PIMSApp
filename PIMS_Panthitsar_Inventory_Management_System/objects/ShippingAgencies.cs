using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class ShippingAgencies
    {

        private string shippingAgencyID;
        private string shippingAgencyName;
        private string email;
        private string phone;
        private string address;
        private double amount;

        public ShippingAgencies()
        { }


        public string ShippingAgencyID { get; set; }

        public string ShippingAgencyName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public double Amount { get; set; }
    }
}
