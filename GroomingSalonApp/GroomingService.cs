using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class GroomingService
    {
        private static int groomingServiceId = 0;

        #region Properties
        public int GroomingServiceId { get; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public double GroomingPrice { get; set; }

        #endregion
    }
}
