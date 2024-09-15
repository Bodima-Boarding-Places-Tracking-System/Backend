using boarding_mgt.Data;
using boarding_mgt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<IEnumerable<Boarding>> GetBoardings()
        {
            return _db.Boarding;
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Boarding>> GetById(int Id)
        {
            var boarding = await _db.Boarding.FindAsync(Id);
            return boarding;
        }

        [HttpPost]
        public async Task<ActionResult> CreateBoarding(Boarding boarding)
        {
            await _db.AddAsync(boarding);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateBoarding(Boarding boarding)
        {
            _db.Boarding.Update(boarding);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{Id:int}")]
        public async Task<ActionResult> DeleteBoarding(int Id)
        {
            var temp = await _db.Boarding.FindAsync(Id);
            _db.Boarding.Remove(temp);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
     }