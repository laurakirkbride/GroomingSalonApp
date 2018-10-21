using System;
using System.Globalization;

namespace GroomingSalonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            Console.WriteLine("********************************");
            Console.WriteLine("Welcome to the Grooming Salon!");
            Console.WriteLine("********************************");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create a Customer Account");
                Console.WriteLine("2. Add a Pet to your Customer Account");
                Console.WriteLine("3. Schedule Grooming Appointment");
                Console.WriteLine("4. Print all pets for a customer account");
                Console.Write("Please select an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        return;
                    case "1": //Create Customer Account
                        try
                        {
                            Console.WriteLine("Customer First Name: ");
                            var customerFirstName = Console.ReadLine();

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

                            var account = Salon.CreateCustomerAccount(customerFirstName, customerLN, streetAddress, city, state, zip, phoneNumber);
                            Console.WriteLine($"CustomerId: {account.CustomerId}, First Name: {account.CustomerFN}, Last Name:{account.CustomerLN}");
                        }
                        catch (FormatException fx)
                        {
                            Console.WriteLine($"Error: {fx.Message}");
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Incorrect account type. Please try again.");
                        }
                        catch (ArgumentNullException ax)
                        {
                            Console.WriteLine($"Error: {ax.Message}");
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong. Try again!");
                        }


                        break;
                    case "2": //Add Pet to Customer Account
                        try
                        {
                            Console.WriteLine("Enter Customer Id: ");
                            var customerId = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter PetName: ");
                            var petName = Console.ReadLine();

                            var pet = Salon.CreatePet(customerId, petName);
                        }
                        catch (FormatException fx)
                        {
                            Console.WriteLine($"Error: {fx.Message}");
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong. Try again!");
                        }
                        break;
                    case "3":  //Schedule Appt
                        try
                        {
                            //Change to Customer Phone Number after Database is added
                            Console.WriteLine("Enter Customer Id: ");
                            var customerId= Convert.ToInt32(Console.ReadLine());
                            PrintAllPetss();
                            Console.Write("PetId:");
                            var petId = Convert.ToInt32(Console.ReadLine());
                            //Need to add DateTime code
                            Console.Write("Enter Appointment Date (dd-mm-yyyy):");
                            DateTime apptDate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", provider);

                            var appt = Salon.CreateAppointment(customerId, petId, apptDate);
                            Console.WriteLine($"CustomerId: {appt.CustomerId}, PetId: {appt.PetId}, Appt Date:{appt.AppointmentDate}");
                        }
                        catch (ArgumentNullException nullE)
                        {
                            Console.WriteLine($"Error: {nullE.Message}");
                        }
                        catch (FormatException fx)
                        {
                            Console.WriteLine($"Error: {fx.Message}");
                        }
                        catch
                        {
                            Console.WriteLine("Something went wrong. Try again!");
                        }
                        break;
                    case "4"://Print all pets
                        PrintAllPetss();
                        break;
                    default:
                        break;
                }
            }//end while


        }
        private static void PrintAllPetss()
        {
            var pets = Salon.GetAllPets();
            foreach (var pet in pets)
            {
                Console.WriteLine($"PetId: {pet.PetId}, Pet Name: {pet.PetName}");
            }
        }
    }
}
