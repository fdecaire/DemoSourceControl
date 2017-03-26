using Microsoft.EntityFrameworkCore;

namespace DataSource
{
    public class StoreAppContext : DbContext, IStoreAppContext
    {
	    private readonly string _connectionString = "";

		public StoreAppContext(DbContextOptions options)
        : base(options)
	    {

		}

		public DbSet<Product> Products { get; set; }

		public void MarkAsModified(Product item)
		{
			Entry(item).State = EntityState.Modified;
		}
	}
}
