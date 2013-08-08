using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Categories
    {
        private string categoryID;
        private string categoryName;

        public Categories()
        { }

        public string  CategoryID { get; set; }

        [Required(ErrorMessage = "CategoryName cannot be empty.")]
        [NotNullValidator(MessageTemplate = "CategoryName is required.")]
        public string  CategoryName { get; set; }
    }
}
