using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelLearning.Core.Models;


namespace TravelLearning.Infrastructure.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CheckIn)
                .HasColumnType("date");

            builder.Property(x => x.CheckOut)
                .HasColumnType("date");
            builder.Property(x => x.CustomerName)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(x => x.ServiceType)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Amount)
                .HasColumnType("decimal(18,2)");
        }
    }
}
