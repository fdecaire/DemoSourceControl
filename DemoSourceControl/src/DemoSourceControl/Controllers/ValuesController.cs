using System.Linq;
using DataSource;
using Microsoft.AspNetCore.Mvc;

namespace DemoSourceControl.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
	    private IStoreAppContext db;

		public ValuesController(IStoreAppContext context)
		{
			db = context;
		}

		[HttpGet]
		[Route("GetAllProducts")]
		public IActionResult GetAllProducts()
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			var results = from p in db.Products select p;

			return Ok(results);
		}
    }
}
