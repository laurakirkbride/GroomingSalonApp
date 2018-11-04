
using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class CustomerAccount
    {
        private static List<CustomerAccount> accounts = new List<CustomerAccount>();

    

        #region Properties
        public int CustomerId { get; set; }
        public string CustomerFN { get; set; }
        public string CustomerLN { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        #endregion

        #region Constructor
        public CustomerAccount()
        {
           
            CreatedDate = DateTime.Now;
        }
        #endregion
        

        public static IEnumerable<CustomerAccount> GetAllCustomerAccounts()
        {
            return accounts;
        }
    }
}
