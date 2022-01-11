using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnyTimeDoctor.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime startTime { get; set; }
        [Required]
        public DateTime endTime { get; set; }
        [Required]
        public int PatientID { get; set; }
        [Required]
        public int DoctorID { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}