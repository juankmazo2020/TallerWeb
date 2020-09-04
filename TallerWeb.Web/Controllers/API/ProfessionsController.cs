using Microsoft.AspNetCore.Mvc;
using TallerWeb.Web.Data;

namespace TallerWeb.Web.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessionsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProfessionsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProfessions()
        {
            OkObjectResult okObjectResult = Ok(_context.Professions);
            return (okObjectResult);
        }
    }

}
