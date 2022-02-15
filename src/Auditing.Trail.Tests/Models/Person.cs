using System;

namespace Tolitech.CodeGenerator.Auditing.Trail.Tests.Models
{
    public  class Person : AuditableEntity
    {
        public Guid? Id { get; set; }

        public string? Name { get; set; }
    }
}
