﻿using Xunit;

namespace StoreAppTests
{
    public class UnitTests
    {
		[Fact]
	    public void TestTrue()
		{
			Assert.True(true);
		}

	    [Fact]
	    public void TestFalse()
	    {
		    Assert.False(false);
	    }
    }
}
