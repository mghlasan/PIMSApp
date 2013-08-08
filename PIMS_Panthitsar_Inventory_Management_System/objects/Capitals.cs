using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIMS_Panthitsar_Inventory_Management_System.objects
{
    class Capitals
    {
        private string capitalID;
        private string debitCreditMark;
        private string creditor;
        private DateTime transactionDate;
        private double amount;
        private double exchangeRate;
        private string payerID;
        private string payeeID;

        public Capitals()
        {
 
        }

        public string  CapitalID { get; set; }

        public string  DebitCreditMark { get; set; }

        public string  Creditor { get; set; }

        public DateTime TransactionDate { get; set; }

        public double Amount  { get; set; }

        public double ExchangeRate { get; set; }

        public string  PayerID { get; set; }

        public string PayeeID { get; set; }
    }
}
