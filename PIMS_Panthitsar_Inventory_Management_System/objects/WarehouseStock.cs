using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class WarehouseStock
    {
        private string warehouseStockID;
        private DateTime date;
        private string receivedRetrievedMark;
        private int receivedQuantity;
        private int retrievedQuantity;
        private string itemID;

        public WarehouseStock()
        { }

        public string  WarehouseStockID { get; set; }

        public DateTime Date { get; set; }

        public string ReceivedRetrievedMark { get; set; }

        public int ReceivedQuantity { get; set; }

        public int RetrievedQuantity { get; set; }

        public string  ItemID { get; set; }
    }
}
