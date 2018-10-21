﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class CustomerAccount
    {
        private static List<CustomerAccount> accounts = new List<CustomerAccount>();

        private static int lastAccountId = 0;

        #region Properties
        public int CustomerId { get; }
        public string CustomerFN { get; set; }
        public string CustomerLN { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Constructor
        public CustomerAccount()
        {
            CustomerId = ++lastAccountId;
            CreatedDate = DateTime.Now;
        }
        #endregion
        

        public static IEnumerable<CustomerAccount> GetAllCustomerAccounts()
        {
            return accounts;
        }
    }
}
