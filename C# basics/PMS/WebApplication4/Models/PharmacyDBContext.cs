using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebApplication4.Models
{
    public class PharmacyDBContext : DbContext
    {
        
    public PharmacyDBContext() : base("name=DefaultConnection") { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

        }

    }
}