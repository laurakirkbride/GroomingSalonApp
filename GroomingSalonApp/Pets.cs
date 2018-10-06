using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class Pets
    {
        private static int lastAccountId = 0;

        #region Properties
        public int PetId { get; }
        public int CustomerId { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime PetBirthday { get; set; }
        #endregion

        #region Constructor
        public Pets(int customerId, string petName)
        {
            CustomerId = customerId;
            PetName = petName; 
        }
        #endregion
    }
}
