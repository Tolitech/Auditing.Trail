using System;
using Xunit;
using Tolitech.CodeGenerator.Auditing.Trail.Commands.InsertItems;
using Tolitech.CodeGenerator.Auditing.Trail.Tests.Models;

namespace Tolitech.CodeGenerator.Auditing.Trail.Tests
{
    public class AuditTrailTest
    {
        [Fact(DisplayName = "AuditTrail - InsertItems - Valid")]
        public void AuditTrail_InsertItems_Valid()
        {
            var person = new Person() { Id = Guid.NewGuid(), Name = "Name" };

            var items = new InsertItemsCommand();
            items.Items.Enqueue(person.Audit());
            
            Assert.True(items.IsValid());
        }

        [Fact(DisplayName = "AuditTrail - InsertItems - Invalid")]
        public void AuditTrail_InsertItems_Invalid()
        {
            var items = new InsertItemsCommand();
            Assert.False(items.IsValid());
        }
    }
}
