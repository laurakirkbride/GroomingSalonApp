using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class Pet
    {

       

        private static int lastPetId = 0;

        #region Properties
        public int PetId { get; }
        public int CustomerId { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime Birthday { get; set; }
        #endregion

        #region Constructor
        public Pet()
        {
            
            PetId= ++lastPetId;
          
        }
        #endregion
    }
}
