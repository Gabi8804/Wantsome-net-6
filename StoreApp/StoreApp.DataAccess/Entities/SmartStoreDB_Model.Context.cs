﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreApp.DataAccess.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartStoreDBEntities : DbContext
    {
        public SmartStoreDBEntities()
            : base("name=SmartStoreDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BrandCategories> BrandCategories { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CategorySpecs> CategorySpecs { get; set; }
        public virtual DbSet<Prod_CatSpec> Prod_CatSpec { get; set; }
        public virtual DbSet<ProductSubCategories> ProductSubCategories { get; set; }
        public virtual DbSet<Specs> Specs { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
    }
}