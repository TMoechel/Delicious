using System;
using System.Collections.Generic;
using TM.Delicious.Domain.Common;

namespace TM.Delicious.Domain.Entities
{
    public class Category: AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Recipe> RecipeList { get; set; }

    }
}
