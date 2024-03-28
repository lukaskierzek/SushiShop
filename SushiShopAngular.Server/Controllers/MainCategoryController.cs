using Microsoft.AspNetCore.Mvc;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Services.Interfaces;

namespace SushiShopAngular.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainCategoryController : ControllerBase
    {
        private readonly IMainCategoryService _mainCategoryService;

        public MainCategoryController(IMainCategoryService mainCategoryService)
        {
            _mainCategoryService = mainCategoryService;
        }

        [HttpGet("main-category")]
        public async Task<ActionResult<List<MainCategory>>> GetAllMainCategory()
        {
            var allCategories = await _mainCategoryService.GetAllMainCategory();
            var allMainCategoryDTO = _mainCategoryService.GetAllMainCategoryDTO(allCategories);

            return Ok(allMainCategoryDTO);
        }
    }
}
