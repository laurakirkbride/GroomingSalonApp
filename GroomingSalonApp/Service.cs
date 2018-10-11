using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class Service
    {
        private static int lastServiceId = 0;

        #region Properties
        public int ServiceId { get; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public double ServicePrice { get; set; }

        #endregion
    }
}
