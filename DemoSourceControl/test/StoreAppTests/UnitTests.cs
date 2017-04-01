using System.Linq;
using DataSource;
using Xunit;

namespace StoreAppTests
{
    public class UnitTests : IClassFixture<UnitTestsFixture>
	{
	    private StoreAppContext _storeAppContext;

		public UnitTests(UnitTestsFixture fixture)
		{
			_storeAppContext = fixture.Context;
		}

	    [Fact]
	    public void TestQueryAll()
	    {
			var temp = (from p in _storeAppContext.Products select p).ToList();

		    Assert.Equal(2, temp.Count);
			Assert.Equal("Rice", temp[0].Name);
			Assert.Equal("Bread", temp[1].Name);
	    }

	    [Fact]
	    public void TestSelectBread()
	    {
		    var temp = (from p in _storeAppContext.Products where p.Name == "Bread" select p.Name).FirstOrDefault();

			Assert.Equal("Bread", temp);
		}
    }
}
