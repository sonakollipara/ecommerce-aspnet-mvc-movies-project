using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
	public class ProducersController : Controller
	{
		private readonly AppDbContext _Context;
        public ProducersController(AppDbContext Context)
        {
				_Context = Context;
        }
        public async Task<IActionResult> Index()
		{
			var allProducers =await _Context.Producers.ToListAsync();
			return View(allProducers);
		}
	}
}
