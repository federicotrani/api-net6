using api_net6.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_net6.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LocalidadesController : ControllerBase
  {
    private readonly ILogger<LocalidadesController> _logger;
    private readonly ApplicationDbContext _context;

    public LocalidadesController(ILogger<LocalidadesController> logger, ApplicationDbContext context)
    {
      _logger = logger;
      _context = context;
    }

    [HttpGet]
    public ActionResult<List<Localidad>> Get(){
       return _context.Localidades.ToList();
    }
  }
}