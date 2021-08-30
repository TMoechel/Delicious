using System;
using TM.Delicious.Domain.Common;

namespace TM.Delicious.Domain.Entities
{
    public class User: AuditableEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
