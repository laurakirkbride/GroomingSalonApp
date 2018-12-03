using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    public class Pet
    {


        #region Properties
        public int PetId { get; set; }
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime Birthday { get; set; }
        #endregion

        #region Constructor
        public Pet()
        {
           
          
        }
        #endregion
    }
}
