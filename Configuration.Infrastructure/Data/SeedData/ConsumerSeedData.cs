using Configuration.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration.Infrastructure.Data.SeedData;
public class ConsumerSeedData : IEntityTypeConfiguration<PlanType>
{
    public void Configure(EntityTypeBuilder<PlanType> builder)
    {
        builder.HasData(
            new PlanType()
            {
                Id = 1,
                Code = "Lite",
                Name = "Lite"
            },
            new PlanType()
            {
                Id = 2,
                Code = "Advanced",
                Name = "Advanced"
            },
            new PlanType()
            {
                Id = 3,
                Code = "Premium",
                Name = "Premium"
            },
            new PlanType()
            {
                Id = 4,
                Code = "Platinum",
                Name = "Platinum"
            }
            );
    }
}
