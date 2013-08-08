using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Suppliers
    {
        private string supplierID;
        private string supplierName;
        private string email;
        private string phone;
        private string address;
        private double creditDue;

        public Suppliers()
        { }

        public string SupplierID { get; set; }

        [Required(ErrorMessage = "SupplierName cannot be empty.")]
        [NotNullValidator(MessageTemplate = "SupplierName is required.")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Email cannot be empty.")]
        [NotNullValidator(MessageTemplate = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone cannot be empty.")]
        [NotNullValidator(MessageTemplate = "Phone is required.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address cannot be empty.")]
        [NotNullValidator(MessageTemplate = "Address is required.")]
        public string Address { get; set; }

        public double CreditDue { get; set; }

        public string  Status { get; set; }
    }
}
