using Mc2.CrudTest.Acceptance.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mc2.CrudTest.Acceptance.Persistance.Ef.Config
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(p => new { p.Firstname, p.Lastname,p.DateOfBirth }).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
