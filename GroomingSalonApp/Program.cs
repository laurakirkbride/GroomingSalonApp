using System;

namespace GroomingSalonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Welcome to the Grooming Salon!");
            Console.WriteLine("********************************");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create a Customer Account");
            Console.WriteLine("2. Add a Pet to your Customer Account");
            Console.WriteLine("3. Schedule Grooming Appointment");
            Console.WriteLine("4. Print all pets for a customer account");
            Console.Write("Please selct an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    return;
                case "1":
                    Console.WriteLine("Customer First Name: ");
                    var customerFN = Console.ReadLine();

                    Console.WriteLine("Customer Last Name: ");
                    var customerLN = Console.ReadLine();

                    Console.WriteLine("Customer Street Address: ");
                    var streetAddress = Console.ReadLine();

                    Console.WriteLine("Customer City: ");
                    var city = Console.ReadLine();

                    Console.WriteLine("Customer State: ");
                    var state = Console.ReadLine();

                    Console.WriteLine("Customer Zip: ");
                    var zip = Console.ReadLine();

                    Console.WriteLine("Customer Phone Number: ");
                    var phoneNumber = Console.ReadLine();

                    var account= Salon.CreateCustomerAccount(customerFN, customerLN, streetAddress, city, state, zip, phoneNumber);
     

                    break;
                case "2":
                case "3":
                case "4":
                default:
                    break;
            }


        }
    }
}
