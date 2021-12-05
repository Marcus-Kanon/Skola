using Genealogi.Data;
using Microsoft.AspNetCore.Mvc;

namespace Genealogi.Controllers
{
    public class FamilyController : Controller
    {
        private readonly GenealogiDbContext _db;

        public FamilyController(GenealogiDbContext db)
        {
            _db = db;

            Helpers.LoadPeople.Load(_db);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
