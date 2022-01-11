using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnyTimeDoctor.Models
{
    public enum Specialty
    {
        Pediatric,Orthopedics,Ophthalmologist
    }
    public class Doctor
    {
        public int ID { get; set; }
        [Required]
        public string AMKA { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string passwordHash { get; set; }
        [Required]
        public Specialty specialty { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}