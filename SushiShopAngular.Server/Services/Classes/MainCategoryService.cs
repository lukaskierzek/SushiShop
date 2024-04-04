using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Enums;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models.ModelsDTO.Sushi;
using SushiShopAngular.Server.Services.Interfaces;

namespace SushiShopAngular.Server.Services.Classes
{
    public class MainCategoryService : IMainCategoryService
    {
        private readonly SushiShopContext _context;
        private readonly IMapper _mapper;

        public MainCategoryService(SushiShopContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public List<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi) => _mapper.Map<List<MainCategoryDTO>>(sushi);

        public async Task<List<MainCategory>> GetAllMainCategory()
        {
            var mainCategories = await _context.MainCategories
                .Where(mainCategory => mainCategory.IsDeleted == (int)IsDeleted.No)
                .ToListAsync();

            return mainCategories;
        }

        public async Task<int> GetMainCategoryId(string mainCategoryName)
        {
            var id = await _context.MainCategories.Where(mc => mc.Name == mainCategoryName).Select(mc=>mc.Id).FirstOrDefaultAsync();

            return id;
        }
    }
}
