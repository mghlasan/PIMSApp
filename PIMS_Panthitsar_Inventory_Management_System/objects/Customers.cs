using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
  public   class Customers
    {
        private string customerID;
        private string customerName;
        private double debitDue;
        private string email;
        private string phone;
        private string address;

        public Customers()
        { }

        public string  CustomerID { get; set; }

        public string  CustomerName { get; set; }

        public double DebitDue { get; set; }

        public string  Email { get; set; }

        public string  Phone { get; set; }

        public string  Address { get; set; }



    }
}
