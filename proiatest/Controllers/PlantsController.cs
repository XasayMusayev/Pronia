using Microsoft.AspNetCore.Mvc;
using proiatest.DAL;
using proiatest.Entites;

namespace proiatest.Controllers
{
    public class PlantsController : Controller
    {
        public PlantsController (ProniaDbContext context)
	    {
            _context= context;
	    }
        public IActionResult Details(int id)
        {
            Plant plant =_context.Plants.FirstOrDefault(p=>p.Id==id);
            return View();
        }
    }
}
