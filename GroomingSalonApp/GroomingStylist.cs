using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    //My Repo
    class GroomingStylist
    {
        private static int lastStylistId = 0;

        #region Properties
        public int StylistId { get; }
        public string StylistFN { get; set; }
        public string StylistLN { get; set; }
        #endregion
    }
}
