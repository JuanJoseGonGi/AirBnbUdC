﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirbnbUdc.Repository.Implementation.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Core_DBEntities : DbContext
    {
        public Core_DBEntities()
            : base("name=Core_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<MultimediaType> MultimediaType { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyMultimedia> PropertyMultimedia { get; set; }
        public virtual DbSet<PropertyOwner> PropertyOwner { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
    }
}
