using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class Transaction { 
    

        private static int lastTransactionId = 0;

        #region Properties
        public int TransactionId { get; }
        public int CustomerId { get; set; }
        public int PetId { get; set; }
        public int ServiceId { get; set; }
        public double ServicePrice { get; set; }
        public DateTime DatePaid { get; set; }
        #endregion
    }
}
