using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Items
    {
        private string itemID;
        private string itemName;
        private double price;
        private int stock;
        private string categoryID;
        private string supplierID;
        private string imagePath;
        private string status;
        private string supplierName;
        private string categoryName;
        //private string no;

        public Items()
        { }

       // public string No { get; set; }
       // [Required(ErrorMessage="ItemID cannot be empty.")]
       // [NotNullValidator(MessageTemplate="ItemID is required.")]
        public string  ItemID { get; set; }

        [Required(ErrorMessage = "ItemName cannot be empty.")]
        [NotNullValidator(MessageTemplate = "ItemName is required.")]
        public string  ItemName { get; set; }

       // [Required(ErrorMessage = "CategoryID cannot be empty.")]
       // [NotNullValidator(MessageTemplate = "CategoryID is required.")]
        public string CategoryID { get; set; }

      //  [Required(ErrorMessage = "SupplierID cannot be empty.")]
       // [NotNullValidator(MessageTemplate = "SupplierID is required.")]
        public string SupplierID { get; set; }

       /// <summary>
       /// 
       /// </summary>
     // [Required(ErrorMessage = "Status cannot be empty.")]
       // [NotNullValidator(MessageTemplate = "Status is required.")]
        public string Status { get; set; }

        //public double  Price { get; set; }
       // [Required(ErrorMessage = "Stock cannot be empty.")]
       // [NotNullValidator(MessageTemplate = "Stock is required.")]
        public int Stock { get; set; }

        

        public string ImagePath { get; set; }

        public string SupplierName { get; set; }

        public string CategoryName { get; set; }
    }
}
