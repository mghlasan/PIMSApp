using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Banks
    {
        private string bankID;
        private string bankName;
        private string email;
        private string phone;
        private string address;

        public Banks()
        { }

        
        public string  BankID { get; set; }

        [Required(ErrorMessage = "BankName cannot be empty.")]
        [NotNullValidator(MessageTemplate = "BankName is required.")]
        public string BankName { get; set; }

        [Required(ErrorMessage = "Email cannot be empty.")]
        [NotNullValidator(MessageTemplate = "Email is required.")]
        public string  Email { get; set; }

        [Required(ErrorMessage = "Phone cannot be empty.")]
        [NotNullValidator(MessageTemplate = "Phone is required.")]
        public string  Phone { get; set; }

        [Required(ErrorMessage = "Address cannot be empty.")]
        [NotNullValidator(MessageTemplate = "Address is required.")]
        public string  Address { get; set; }
    }
}
