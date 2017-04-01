﻿using DataSource.Domain;
using DataSource.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataSource
{
    public class StoreAppContext : DbContext, IStoreAppContext
    {
		public StoreAppContext(DbContextOptions<StoreAppContext> options)
        : base(options)
	    {

		}

		public DbSet<Product> Products { get; set; }

	    public new int SaveChanges()
	    {
			return base.SaveChanges();
	    }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.AddProduct("dbo");
		}
	}
}
