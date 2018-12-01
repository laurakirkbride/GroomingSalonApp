using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    public class Transaction
    {


       

        #region Properties
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int PetId { get; set; }
        public int ServiceId { get; set; }
        public double ServicePrice { get; set; }
        public DateTime DatePaid { get; set; }
        #endregion

        #region Constructor
        public Transaction()
        {

          

        }
        #endregion
    }
}
