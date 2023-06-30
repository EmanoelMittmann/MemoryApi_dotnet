using Api_almostHacker.Infra;
using Api_almostHacker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_almostHacker.Controllers
{
    public class RecordsController : Controller
    {

        private ApiContext _context;

        public RecordsController()
        {
            _context = new ApiContext();
        }

        [HttpPost("Records")]
        public async Task<IActionResult> Save([FromBody] Records model)
        {
            _context.Records.AddAsync(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpGet("Records")]
        public async Task<IActionResult> Index()
        {
            return Ok(_context.Records.ToList());
        }

        [HttpPut("Records")]
        public async Task<IActionResult> Edit(int id, [FromBody] Records model)
        {
            try
            {
                _context.Records.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Edit), new { id = id, saveChangesError = true });
            }
        }

        [HttpDelete("Record")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            var record = await _context.Records.FindAsync(id);
            try
            {
                _context.Records.Remove(record);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }
    }
}
