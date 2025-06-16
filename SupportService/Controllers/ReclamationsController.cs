using Microsoft.AspNetCore.Mvc;
using SupportService.Data;
using SupportService.Models;

namespace SupportService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReclamationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReclamationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Reclamation>> GetReclamations()
        {
            return _context.Reclamations.ToList();
        }

        [HttpPost]
        public ActionResult<Reclamation> PostReclamation(Reclamation reclamation)
        {
            _context.Reclamations.Add(reclamation);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetReclamations), new { id = reclamation.Id }, reclamation);
        }
    }
}
