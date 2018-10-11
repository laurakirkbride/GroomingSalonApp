﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class Salon
    {

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
        public static CustomerAccount CreateCustomerAccount(string customerFN, string customerLN, string streetAddress, string city, string state, string zip, string phoneNumber)
        {
            var account = new CustomerAccount
            {
                CustomerFN = customerFN,
                CustomerLN = customerLN,
                StreetAddress=streetAddress,
                City=city,
                Zip=zip,
                PhoneNumber=phoneNumber
            };
            
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
        public static Pet CreatePet(int customerId, string petName, string species, string breed, DateTime birthday)
        {
            var pet = new Pet
            {
                CustomerId = customerId, 
                PetName=petName,
                Species=species,
                Breed=breed,
                Birthday=birthday
            };
            return pet;
        }




    }
}