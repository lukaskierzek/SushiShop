using AutoMapper;
using SushiShopAngular.Server.Data;
using SushiShopAngular.Server.Models;
using SushiShopAngular.Server.Models.ModelsDTO;

namespace SushiShopAngular.Server.Services
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

        public IEnumerable<MainCategoryDTO> GetAllMainCategoryDTO(List<MainCategory> sushi) => _mapper.Map<List<MainCategoryDTO>>(sushi);
    }
}
