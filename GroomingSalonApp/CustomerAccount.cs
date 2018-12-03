using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{

    public enum StateList
    {
        AL,AK,AZ,AR,CA,CO,CT,DE,FL,GA,HI,ID,IL,IN,IA,KS,KY,LA,ME,MD,MA,MI,MN,MS,MO,MT,NE,NV,NH,NJ,NM,NY,NC,ND,OH,OK,OR,PA,RI,SC,SD,TN,TX,UT,VT,VA,WA,WV,WI,WY
    }
    public class CustomerAccount
    {
        private static List<CustomerAccount> accounts = new List<CustomerAccount>();

    

        #region Properties
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerFN { get; set; }
        public string CustomerLN { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public StateList State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
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
