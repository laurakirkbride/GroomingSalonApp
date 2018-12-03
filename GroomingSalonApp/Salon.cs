using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroomingSalonApp
{
    public class Salon
    {
        public static SalonModel db = new SalonModel();

        /// <summary>
        /// Create an customer account at the salon
        /// /// </summary>
        /// <param name="customerFN">Customer First Name</param>
        /// <param name="customerLN">Customer Last Name</param>
        /// <param name="streetAddress">Customer Street Address</param>
        /// <param name="city">Customer City</param>
        /// <param name="state">Customer State</param>
        /// <param name="zip">Customer Zip</param>
        /// <param name="phoneNumber">Phone Number</param>
        /// <returns>Newly created account</returns>
        public static CustomerAccount CreateCustomerAccount(string emailAddress, string customerFN, string customerLN, string streetAddress, string city, StateList state, string zip, string phoneNumber)
        {
            var account = new CustomerAccount
            {
                EmailAddress=emailAddress,
                CustomerFN = customerFN,
                CustomerLN = customerLN,
                StreetAddress=streetAddress,
                City=city,
                State=state,
                Zip=zip,
                PhoneNumber=phoneNumber
            };
            db.CustomerAccounts.Add(account);
            db.SaveChanges();
            return account;
        }

        /// <summary>
        /// Create a pet account that is assoicated with a customer
        /// /// </summary>
        /// <param name="customerId">CustomerId of pet owner</param>
        /// <param name="petName">Name of pet</param>
        /// <param name="species">Species of pet ex. dog</param>
        /// <param name="breed">breed</param>
        /// <param name="species">spcies</param>
        /// <param name="petBirthDay">Birthday of pet</param>
        /// <returns>Newly created account</returns>
        public static Pet CreatePet(string emailAddress, string petName)
        {
            var pet = new Pet
            {
                EmailAddress = emailAddress, 
                PetName=petName,
       
                //Birthday=birthday
            };
            db.Pets.Add(pet);
            db.SaveChanges();
            return pet;
        }
        public static Appointment CreateAppointment(int customerId, int petId,DateTime apptDate)
        {
            var appt = new Appointment
            {
                CustomerId = customerId,
                PetId = petId,
                AppointmentDate = apptDate
            };
            db.Appointments.Add(appt);

            db.SaveChanges();

            return appt;
        }
        public static IEnumerable<CustomerAccount> GetCustomerAccounts(string emailAddress)
        {
            return db.CustomerAccounts.Where(a => a.EmailAddress == emailAddress);

        }

        public static IEnumerable<Pet> GetAllPets(string emailAddress)
        {
            return db.Pets.Where(a => a.EmailAddress == emailAddress); ;
            
        }
        public static CustomerAccount GetCustomerAccountDetails(int customerId)
        {
             return db.CustomerAccounts.SingleOrDefault(m => m.CustomerId == customerId);
        }
        
        public static void EditAccount(CustomerAccount updatedAccount)
        {
            var oldAccount = Salon.GetCustomerAccountDetails(updatedAccount.CustomerId);
            
            oldAccount.CustomerFN = updatedAccount.CustomerFN;
            oldAccount.CustomerLN = updatedAccount.CustomerLN;
            oldAccount.StreetAddress = updatedAccount.StreetAddress;
            oldAccount.City = updatedAccount.City;
            oldAccount.State = updatedAccount.State;
            oldAccount.Zip = updatedAccount.Zip;
            oldAccount.PhoneNumber = updatedAccount.PhoneNumber;
            db.Update(oldAccount);
            db.SaveChanges();
        }
        public static bool CustomerAccountExists(int id)
        {
            return db.CustomerAccounts.Any(e => e.CustomerId == id);
        }

        public static void DeleteCustomerAccount(int customerId)
        {
            var account = Salon.GetCustomerAccountDetails(customerId);
            db.CustomerAccounts.Remove(account);
            db.SaveChanges();
        }

    }
}
