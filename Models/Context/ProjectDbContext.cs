using MVC_Hospital.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Hospital.Models.Context
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=ProjectHospitalDb;User Id=sa;Password=1234;";
        }
        public DbSet<Doctor> Doctors{ get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<DoctorAndPatient> DoctorAndPatients { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AppUserAndRole> AppUserAndRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorAndPatient>().HasKey(x => new { x.DoctorId, x.PatientId});
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUserAndRole>().HasKey(x => new { x.AppUserId, x.RoleId });
            base.OnModelCreating(modelBuilder);




        }
    }
}