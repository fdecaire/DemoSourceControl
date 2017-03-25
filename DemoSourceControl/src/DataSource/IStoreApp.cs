using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
