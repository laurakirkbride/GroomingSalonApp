using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    class GroomingSchedule
    {
        private static int lastAppointmentId = 0;

        #region Properties
        public int AppointmentId { get; }
        public int CustomerId { get; set; }
        public int PetId{ get; set; }
        public int StylistId { get; set; }
        public string ServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
    }
}
