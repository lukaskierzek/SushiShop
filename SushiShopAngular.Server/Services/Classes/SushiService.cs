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
    public class SushiService : ISushiService
    {
        private readonly SushiShopContext _context;
        private readonly IMapper _mapper;

        public SushiService(SushiShopContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Sushi>> GetAllSushiWithDeleted()
        {
            var sushi = await _context.Sushis
                .Include(sushi => sushi.Ingredients)
                .Include(sushi => sushi.SubCategories)
                .Include(sushi => sushi.MainCategory)
                .Include(sushi => sushi.Description)
                .ToListAsync();

            return sushi;
        }

        public async Task<List<Sushi>> GetAllSushiByQuery(string mainCategoryName)
        {
            var sushi = new List<Sushi>();

            if (mainCategoryName.ToLower() != Categories.ALL.ToString().ToLower())
            {
                sushi = await _context.Sushis
               .Where(sushi => sushi.IsDeleted == (int)IsDeleted.No)
               .Where(sushi => sushi.MainCategory.Name == mainCategoryName)
               .Include(sushi => sushi.Ingredients)
               .Include(sushi => sushi.SubCategories)
               .Include(sushi => sushi.MainCategory)
               .Include(sushi => sushi.Description)
               .ToListAsync();
            }
            else
            {
                sushi = await _context.Sushis
                .Where(sushi => sushi.IsDeleted == (int)IsDeleted.No)
                .Include(sushi => sushi.Ingredients)
                .Include(sushi => sushi.SubCategories)
                .Include(sushi => sushi.MainCategory)
                .Include(sushi => sushi.Description)
                .ToListAsync();
            }

            return sushi;
        }

        public async Task<Sushi> GetSushiById(int id)
        {
            var sushiById = await _context.Sushis
                //.Where(sushi => sushi.IsDeleted == (int)IsDeleted.No)
                .Include(sushi => sushi.Ingredients)
                .Include(sushi => sushi.SubCategories)
                .Include(sushi => sushi.MainCategory)
                .Include(sushi => sushi.Description)
                .FirstOrDefaultAsync(s => s.Id == id);

            return sushiById;
        }

        public async Task<Sushi> CreateSushi(Sushi sushi, List<SushiIngredient> sushiIngredients)
        {
            sushi.sushiIngredients.Clear();

            await _context.Sushis.AddAsync(sushi);
            await _context.SushiIngredients.AddRangeAsync(sushiIngredients);
            // TODO: Add subcategiories
            await _context.SaveChangesAsync();

            return sushi;
        }

        public async Task<Sushi> UpdateSushi(Sushi sushi)
        {
            _context.Entry(sushi).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return sushi;
        }

        public bool AnySushi(int id) => _context.Sushis.Any(sushi => sushi.Id == id);
        public List<SushiIngredient> GetSushiIngredientDTOFromSushiPOST(List<CreateSushiIngredientDTO> ingredients) => _mapper.Map<List<SushiIngredient>>(ingredients);
        public List<SushiDTO> GetAllSushiDTO(List<Sushi> sushi) => _mapper.Map<List<SushiDTO>>(sushi);
        public SushiDTO GetSushiByIdDTO(Sushi sushi) => _mapper.Map<SushiDTO>(sushi);
        public Sushi CreateSushiFromSushiDTO(CreateSushiDTO createSushiDTO) => _mapper.Map<Sushi>(createSushiDTO);
    }
}
