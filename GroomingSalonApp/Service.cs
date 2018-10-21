using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{

    enum TypeOfService
    {
        Bath,
        Groom,
        Nail
        
    };
    
    class Service
    {
       

        #region Properties
       
        public TypeOfService ServiceType { get; set; }
        #endregion
    }
}
