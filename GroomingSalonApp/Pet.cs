using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GroomingSalonApp
{
    class Pet
    {


        #region Properties
        public int PetId { get; set; }
        [ForeignKey("CustomerAccount")]
        public int CustomerId { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime Birthday { get; set; }

        public virtual CustomerAccount CustomerAccount { get; set; }
        #endregion

        #region Constructor
        public Pet()
        {
           
          
        }
        #endregion
    }
}
