using System;
using System.Collections.Generic;
using System.Text;

namespace GroomingSalonApp
{
    public class Appointment
    {
        private static int lastAppointmentId = 0;

        #region #region Properties
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int PetId { get; set; }
        public Service Service { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Constructor
        public Appointment()
        {
             AppointmentId = ++lastAppointmentId;
             CreatedDate=DateTime.Now;
        }
        #endregion

    }
}
