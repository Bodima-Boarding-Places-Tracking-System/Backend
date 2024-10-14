using boarding_mgt.Data;
using boarding_mgt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace boarding_mgt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardingApiController : ControllerBase
    {
        private readonly AppDbContext _db;

        public BoardingApiController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task< ActionResult<IEnumerable<Boarding>>> GetBoardings()
        {
            var boardings = await _db.Boarding.ToListAsync();
            if (boardings == null)
                return NotFound("There are no boarding available");
            return Ok(boardings);
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Boarding>> GetById(int Id)
        {
            var boarding = await _db.Boarding.FindAsync(Id);
            if(boarding==null)
                return NotFound("Boarding not found");

            return boarding;
        }

        [HttpPost]
        public async Task<ActionResult> CreateBoarding(Boarding boarding)
        {
            var ExistingBoarding = await _db.Boarding.FirstOrDefaultAsync(b => b.Name == boarding.Name);
            if (ExistingBoarding != null)
                return Conflict($"Boarding with name '{boarding.Name}' already exists." );
        
        await _db.AddAsync(boarding);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateBoarding(Boarding boarding)
        {
            var Boarding = await _db.Boarding.FindAsync(boarding.Id);
            if (Boarding == null)
                return NotFound("Boarding not found");
            Boarding.Name = boarding.Name;
            Boarding.Description = boarding.Description;
            Boarding.Type = boarding.Type;
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> DeleteBoarding(int Id)
        {
            var temp = await _db.Boarding.FindAsync(Id);
            if (temp == null)
                return NotFound("Boarding not found");
            _db.Boarding.Remove(temp);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
     }