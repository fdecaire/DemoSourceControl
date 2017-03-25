using System;
using Microsoft.EntityFrameworkCore;

namespace DataSource
{
	public interface IStoreAppContext : IDisposable
	{
		DbSet<Product> Products { get; }
		int SaveChanges();
		void MarkAsModified(Product item);
	}
}
