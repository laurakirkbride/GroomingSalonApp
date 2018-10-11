using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    //My Repo
    class Stylist
    {
        private static int lastStylistId = 0;

        #region Properties
        public int StylistId { get; }
        public string StylistFN { get; set; }
        public string StylistLN { get; set; }
        #endregion
    }
}
