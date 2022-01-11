using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnyTimeDoctor.Models
{
    public class Admin
    {
        public int ID { get; set; }

        [Required]
        public string username { get; set; }
        public string passwordHash { get; set; }

    }
}