using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RadioCabs.Models
{
    public class Listing
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Password { get; set; }
        public string ContactPerson { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string FaxNo { get; set; }
        public string EmailAddress { get; set; }
        public string MembershipType { get; set; }
        public string PaymentType { get; set; }
    }
    
    public class Driver
    {
        public int ID { get; set; }
        public string DriverName { get; set; }
        public string Password { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string EmailAddress { get; set; }
        public string Experience { get; set; }
        public string Description { get; set; }
        public string PaymentType { get; set; }
    }

    public class Advertisement
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string TelephoneNo { get; set; }
        public string FaxNo { get; set; }
        public string EmailAddress { get; set; }
        public string Description { get; set; }
        public string PaymentType { get; set; }
    }

    public class Feedback
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        
    }

    public class RadioCabsDBContext : DbContext
    {
        public DbSet<Driver> drivers { get; set; }
        public DbSet<Listing> listings { get; set; }
        public DbSet<Advertisement> advertisements { get; set; }
        public DbSet<Feedback> feedbacks { get; set; }
    }
}