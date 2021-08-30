using System;

namespace TM.Delicious.Application.Features.Recipes
{
    public class RecipeVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

    }
}
