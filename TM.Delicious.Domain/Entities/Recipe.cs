using System;
using System.Collections.Generic;
using TM.Delicious.Domain.Common;

namespace TM.Delicious.Domain.Entities
{
    public class Recipe: AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Ingredient> IngredientsList { get; set; }
        public Guid IdCategory { get; set; }
    }
}
