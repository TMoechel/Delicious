using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TM.Delicious.Application.Contracts.Persistence;
using TM.Delicious.Application.Features.Events;
using TM.Delicious.Domain.Entities;

namespace TM.Delicious.Application.Features.Recipes
{
    public class GetRecipeListQueryHandler : IRequestHandler<GetRecipeListQuery, List<RecipeVm>>
    {
        private readonly IAsyncRepository<Recipe> _recipeRepository;
        private readonly IMapper _mapper;

        public GetRecipeListQueryHandler(IMapper mapper, IAsyncRepository<Recipe> recipeRepository)
        {
            _mapper = mapper;
            _recipeRepository = recipeRepository;
        }
        public async Task<List<RecipeVm>> Handle(GetRecipeListQuery request, CancellationToken cancellationToken)
        {
            var allRecipes = (await _recipeRepository.ListAllAsync()).OrderBy(x => x.Date);
        }
    }
}
