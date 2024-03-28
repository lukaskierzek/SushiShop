using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Enums;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;

namespace SushiShopAngular.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RawController : ControllerBase
    {
        private readonly SushiShopContext _context;
        private readonly IMapper _mapper;

        public RawController(SushiShopContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        [HttpGet("rawMainCategory")]
        public async Task<ActionResult<IEnumerable<MainCategory>>> GetAllRawMainCategory()
        {
            var allCategories = await _context.MainCategories
                .Where(mc => mc.IsDeleted == (int)IsDeleted.No)
                .Include(e => e.Sushis)
            .ToListAsync();

            return Ok(allCategories);
        }


        [HttpGet("rawdto")]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushiRawDto()
        {
            var allSushis = await _context.Sushis
                .Where(sushi => sushi.IsDeleted == (int)IsDeleted.No)
                .Include(s => s.sushiIngredients)
                .Include(s => s.Ingredients)
                .Include(s => s.MainCategory)
                .Include(s => s.Description)
                .Include(s => s.SubCategories)
                //.Include(s => s.sushiSubCategories)
                .ToListAsync();

            var allSushisDTO = _mapper.Map<List<SushiDTO>>(allSushis);

            return Ok(allSushisDTO);
        }

        [HttpGet]
        [Route("rawSushiQuery")]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushiRaw([FromQuery] string mainCategory)
        {
            var allSushis = await _context.Sushis
                .Where(s => s.MainCategory.Name == mainCategory)
                .Include(s => s.sushiIngredients)
                .Include(s => s.MainCategory)
                .ToListAsync();


            return Ok(allSushis);
        }
    }
}
