using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class System_Users
    {
        private string userID;
        private string userName;
        private string email;
        private string phone;
        private string address;
        private string role;

        public System_Users()
        { }

        public string UserID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Role { get; set; }
    }
}
