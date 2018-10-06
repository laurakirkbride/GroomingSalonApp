using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class CustomerAccount
    {
        private static int lastAccountId = 0;

        #region Properties
        public int CustomerAccountId { get; }
        public string CustomerFN { get; set; }
        public string CustomerLN { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Constructor
        public CustomerAccount()
        {
            CustomerAccountId = ++lastAccountId;
            CreatedDate = DateTime.Now;
        }
        #endregion
    }
}
