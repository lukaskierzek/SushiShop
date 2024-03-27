using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Enums;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;
using SushiShopAngular.Server.Services.Interfaces;

namespace SushiShopAngular.Server.Services.Classes
{
    public class IngredientService : IIngredientService
    {
        private readonly SushiShopContext _context;
        private readonly IMapper _mapper;

        public IngredientService(SushiShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Ingredient>> GetAllIngredient()
        {
            var allIngredients = await _context.Ingredients
                .Where(i => i.IsDeleted == (int)IsDeleted.No)
                .ToListAsync();

            return allIngredients;
        }

        public List<IngredientListDTO> GetAllIngredientDTO(List<Ingredient> ingredients) => _mapper.Map<List<IngredientListDTO>>(ingredients);
    }
}
