using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnyTimeDoctor.Models
{
    public class Notification
    {
        public int ID { get; set; }
        [Required]
        public string message { get; set; }
        [Required]
        public int DoctorID { get; set; }
        [Required]
        public int PatientID { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}