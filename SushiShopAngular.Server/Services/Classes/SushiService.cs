using AutoMapper;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;
using SushiShopAngular.Server.Models.ModelsDTO.Ingredient;
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

        public List<SushiDTO> GetAllSushiDTO(List<Sushi> sushi) => _mapper.Map<List<SushiDTO>>(sushi);
        public SushiDTO GetSushiByIdDTO(Sushi sushi) => _mapper.Map<SushiDTO>(sushi);
        public List<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi) => _mapper.Map<List<MainCategoryDTO>>(sushi);
        public List<IngredientListDTO> GetAllIngredientDTO(List<Ingredient> ingredients) => _mapper.Map<List<IngredientListDTO>>(ingredients);
        public Sushi CreateSushiFromSushiDTO(CreateSushiDTO createSushiDTO) => _mapper.Map<Sushi>(createSushiDTO);
    }
}
