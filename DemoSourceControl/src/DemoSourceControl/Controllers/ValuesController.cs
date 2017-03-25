using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataSource;
using Microsoft.AspNetCore.Mvc;

namespace DemoSourceControl.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
	    private IStoreAppContext db;
		List<Product> products = new List<Product>();

		// add these contructors
		public ValuesController() { }

		public ValuesController(IStoreAppContext context)
		{
			db = context;
		}

		public IEnumerable<Product> GetAllProducts()
		{
			return products;
		}

		public async Task<IEnumerable<Product>> GetAllProductsAsync()
		{
			return await Task.FromResult(GetAllProducts());
		}

		// GET api/values
		[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
