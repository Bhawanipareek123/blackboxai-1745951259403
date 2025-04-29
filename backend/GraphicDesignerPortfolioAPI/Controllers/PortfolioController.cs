using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GraphicDesignerPortfolioAPI.Models;

namespace GraphicDesignerPortfolioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPortfolioItems()
        {
            var items = await _context.PortfolioItems.ToListAsync();
            return Ok(items);
        }
    }
}
