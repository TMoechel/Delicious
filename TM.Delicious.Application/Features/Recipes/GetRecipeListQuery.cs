using MediatR;
using System.Collections.Generic;
using TM.Delicious.Application.Features.Recipes;

namespace TM.Delicious.Application.Features.Events
{
    public class GetRecipeListQuery: IRequest<List<RecipeVm>>
    {

    }
}
