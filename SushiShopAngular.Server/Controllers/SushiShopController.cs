using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Enums;
using SushiShopAngular.Server.ExtensionMethods;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;
using SushiShopAngular.Server.Services.Interfaces;

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

        #region Sushi
        [HttpGet(RouteSushiShop.AllSushi)]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushi()
        {
            var allSushis = await _sushiService.GetAllSushi();

            var allSushisDTO = _sushiService.GetAllSushiDTO(allSushis);

            return Ok(allSushisDTO);
        }

        [HttpGet(RouteSushiShop.SushiById)]
        public async Task<ActionResult<Sushi>> GetSushiById([FromRoute] int id)
        {
            var sushiById = await _sushiService.GetSushiById(id);

            if (sushiById.IsNull())
                return NotFound();

            var sushiByIdDTO = _sushiService.GetSushiByIdDTO(sushiById);

            if (sushiByIdDTO.IsNull())
                return NotFound();

            return Ok(sushiByIdDTO);
        }

        [HttpPost(RouteSushiShop.PostSushi)]
        public async Task<ActionResult<Sushi>> PostSushi([FromBody] CreateSushiDTO createSushiDTO)
        {
            var sushi = _sushiService.CreateSushiFromSushiDTO(createSushiDTO);
            var ingredients = createSushiDTO.SushiIngredients;
            var ingredientsFromCreateSushiDTO = _sushiService.GetSushiIngredientDTOFromSushiPOST(ingredients);

            await _sushiService.CreateSushi(sushi, ingredientsFromCreateSushiDTO);

            return CreatedAtAction(nameof(GetSushiById), new { id = sushi.Id }, sushi);
        }

        [HttpPut("sushi/{id}")]
        public async Task<IActionResult> PutSushi([FromRoute] int id, [FromBody] SushiDTO updateSushi)
        {
            var sushiById = await _sushiService.GetSushiById(id);

            if (sushiById.IsNull())
                return NotFound();

            if (sushiById.Id != id)
                return BadRequest();

            AssignSushiValuesFromBody(sushiById, updateSushi);

            try
            {
                await _sushiService.UpdateSushi(sushiById);
            }
            catch (DbUpdateConcurrencyException)
            {
                var isAnySushi = _sushiService.AnySushi(id);
                if (!isAnySushi)
                    return NotFound();
                else
                    throw;
            }

            return NoContent();

            static void AssignSushiValuesFromBody(Sushi sushi, SushiDTO updateSushi)
            {
                sushi.Name = updateSushi.Name;
            }
        }
        #endregion


        #region Ingredient
        [HttpGet(RouteSushiShop.AllIngredient)]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetAllIngredient()
        {
            var allIngredients = await _context.Ingredients
                .Where(i => i.IsDeleted == (int)IsDeleted.No)
                .ToListAsync();

            var allIngredientsDTO = _sushiService.GetAllIngredientDTO(allIngredients);

            return Ok(allIngredientsDTO);
        }
        #endregion

        //======================================================================================================================================

#if DEBUG

        [HttpGet(RouteSushiShop.AllMainCategory)]
        public async Task<ActionResult<IEnumerable<MainCategory>>> GetAllMainCategory()
        {
            var allCategories = await _context.MainCategories
                .Where(mc => mc.IsDeleted == (int)IsDeleted.No)
                .ToListAsync();

            var allMainCategoryDTO = _sushiService.GetAllMainCategoryDTO(allCategories);

            return Ok(allMainCategoryDTO);
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
        [Route("raw")]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushiRaw()
        {
            var allSushis = await _context.Sushis
                .Include(s => s.sushiIngredients)
                .ToListAsync();


            return Ok(allSushis);
        }
#endif
    }

}
