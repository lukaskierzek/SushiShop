using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Enums;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Services.Classes;
using SushiShopAngular.Server.Services.Interfaces;

namespace SushiShopAngular.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet("ingredient")]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetAllIngredient()
        {
            var allIngredients = await _ingredientService.GetAllIngredient();
            var allIngredientsDTO = _ingredientService.GetAllIngredientDTO(allIngredients);

            return Ok(allIngredientsDTO);
        }
    }
}
