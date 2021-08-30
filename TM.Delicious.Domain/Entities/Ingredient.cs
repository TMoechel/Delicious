using System;
using TM.Delicious.Domain.Common;

namespace TM.Delicious.Domain.Entities
{
    public class Ingredient: AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
