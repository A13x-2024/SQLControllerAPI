using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLControllerTest.Data;
using SQLControllerTest.Models;

namespace SQLControllerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotatoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PotatoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpGet]
        public async Task<ActionResult<List<Potato>>> GetAllPotatoes()
        {
            var potatoes = await _dataContext.Potatoes.ToListAsync();
            return Ok(potatoes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Potato>> GetPotatoById(int id)
        {
            var potato = await _dataContext.Potatoes.FindAsync(id);
            if (potato == null)
            {
                return NotFound();
            }
            return Ok(potato);
        }
    }
}
