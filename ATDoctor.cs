using System.Collections.Generic;
using AnyTimeDoctor.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AnyTimeDoctor.DAL
{
    public class ATDoctorContext: DbContext
    {
        public ATDoctorContext() : base("ATDoctorContext") { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}