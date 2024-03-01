using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Enums;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Services;

namespace SushiShopAngular.Server.Controllers
{
    [ApiController]
    [Route(RouteSushiShop.MainRoute)]
    public class SushiShopController : ControllerBase
    {
        private readonly SushiShopContext _context;
        private readonly IMapper _mapper;
        private readonly ISushiService _sushiService;
        public SushiShopController(SushiShopContext dbContext, IMapper mapper, ISushiService sushiService)
        {
            _context = dbContext;
            _mapper = mapper;
            _sushiService = sushiService;
        }

        [HttpGet]
        [Route(RouteSushiShop.AllSushi)]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushi()
        {
            var allSushis = await _context.Sushis
                .Where(sushi => sushi.IsDeleted == (int)IsDeleted.No)
                .Include(sushi => sushi.Ingredients)
                .Include(sushi => sushi.SubCategories)
                .Include(sushi => sushi.MainCategory)
                .Include(sushi => sushi.Description)
                .ToListAsync();

            var allSushisDTO = _mapper.Map<List<SushiDTO>>(allSushis);

            return Ok(allSushisDTO);
        }

        [HttpGet]
        [Route(RouteSushiShop.AllMainCategory)]
        public async Task<ActionResult<IEnumerable<MainCategory>>> GetAllMainCategory()
        {
            var allCategories = await _context.MainCategories
                .Where(mc=>mc.IsDeleted == (int)IsDeleted.No)
                .ToListAsync();

            var allMainCategoryDTO = _sushiService.GetAllMainCategoryDTO(allCategories);

            return Ok(allMainCategoryDTO);
        }


        [HttpGet]
        [Route("rawdto")]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushiRawDto()
        {
            var allSushis = await _context.Sushis
                .Where(sushi => sushi.IsDeleted == (int)IsDeleted.No)
                .Include(s => s.sushiIngredients)
                .Include(s => s.Ingredients)
                .Include(s => s.MainCategory)
                .Include(s => s.Description)
                .Include(s => s.SubCategories)
                .Include(s => s.sushiSubCategories)
                .ToListAsync();

            var allSushisDTO = _mapper.Map<List<SushiDTO>>(allSushis);

            return Ok(allSushisDTO);
        }

        [HttpGet]
        [Route("raw")]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushiRaw()
        {
            var allSushis = await _context.Sushis
                .Where(sushi => sushi.IsDeleted == (int)IsDeleted.No)
                .Include(s => s.sushiIngredients)
                .ToListAsync();


            return Ok(allSushis);
        }
    }

}
