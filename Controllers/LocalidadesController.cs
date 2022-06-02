using api_net6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<List<Localidad>>> Get(){
       return await _context.Localidades.ToListAsync();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<List<Localidad>>> GetById(int id){
       var localidad = await _context.Localidades.FirstOrDefaultAsync(x=>x.Id == id);

       if(localidad==null){
           return NotFound();
       }
       
       return Ok(localidad);
    }

    [HttpPost]
    public async Task<ActionResult> Post(Localidad localidad){
        await _context.Localidades.AddAsync(localidad);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult> Put(int id, [FromBody] Localidad localidad){
        if(_context.Localidades.Any(x=>x.Id == id)){
            return BadRequest();
        }
        _context.Localidades.Update(localidad);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id){
        var localidad = await _context.Localidades.FirstOrDefaultAsync(x=>x.Id == id);

       if(localidad==null){
           return NotFound();
       }

        _context.Localidades.Remove(localidad);
        await _context.SaveChangesAsync();

        return Ok();
    }
  }
}