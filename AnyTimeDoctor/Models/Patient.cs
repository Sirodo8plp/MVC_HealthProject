using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnyTimeDoctor.Models
{
    public class Patient
    {   
        public int ID { get; set; }
        [Required]
        public string AMKA { get; set; }
        [Required]
        public string username { get; set; }
        public string passwordHash { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string email { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}