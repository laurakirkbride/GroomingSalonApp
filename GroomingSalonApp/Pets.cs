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
        public int CustomerAccountId { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime PetBirthday { get; set; }
        #endregion

        #region Constructor
        public Pets(int _CustomerAccountId, string _PetName)
        {
            CustomerAccountId = _CustomerAccountId;
            PetName = _PetName; 
        }
        #endregion
    }
}
