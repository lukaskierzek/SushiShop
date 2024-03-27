using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.ExtensionMethods;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;
using SushiShopAngular.Server.Services.Interfaces;

namespace SushiShopAngular.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SushiShopController : ControllerBase
    {
        private readonly SushiShopContext _context;
        private readonly IMapper _mapper;
        private readonly ISushiService _sushiService;
        public SushiShopController(IMapper mapper, ISushiService sushiService)
        {
            _mapper = mapper;
            _sushiService = sushiService;
        }

        [HttpGet("sushiAll")]
        public async Task<ActionResult<IEnumerable<Sushi>>> GetAllSushi()
        {
            var allSushis = await _sushiService.GetAllSushi();

            var allSushisDTO = _sushiService.GetAllSushiDTO(allSushis);

            return Ok(allSushisDTO);
        }

        [HttpGet("sushi")]
        public async Task<ActionResult<List<Sushi>>> GetAllSushiByQuery([FromQuery] string mainCategory)
        {
            var allSushiByQuery = await _sushiService.GetAllSushiByQuery(mainCategory);
            var allSushiByQueryDTO = _sushiService.GetAllSushiDTO(allSushiByQuery);

            return Ok(allSushiByQueryDTO);
        }

        [HttpGet("sushi/{id}")]
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

        [HttpPost("sushi")]
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
                // TODO: Add more values
            }
        }
    }
}
