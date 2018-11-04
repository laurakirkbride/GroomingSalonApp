using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GroomingSalonApp
{
    class Appointment
    {

        #region #region Properties
        public int AppointmentId { get; set; }
        [ForeignKey("CustomerAccount")]
        public int CustomerId { get; set; }
       
        public int PetId { get; set; }
        public Service Service { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual CustomerAccount CustomerAccount { get; set; }
       
        #endregion

        #region Constructor
        public Appointment()
        {
           
             CreatedDate=DateTime.Now;
        }
        #endregion

    }
}
