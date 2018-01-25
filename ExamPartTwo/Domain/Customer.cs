﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPartTwo.Domain
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(p => p.CustomerID);

            Property(p => p.CustomerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CompanyName)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.ContactName)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.ContactTitle)
                .HasMaxLength(30)
                .IsRequired();

            Property(p => p.Address)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.City)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Region)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.PostalCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Country)
                .HasMaxLength(50)
                .IsRequired();
            
            Property(p => p.Phone)
                .HasMaxLength(24)
                .IsRequired();

            Property(p => p.Fax)
                .HasMaxLength(24)
                .IsRequired();
        }
    }
}
