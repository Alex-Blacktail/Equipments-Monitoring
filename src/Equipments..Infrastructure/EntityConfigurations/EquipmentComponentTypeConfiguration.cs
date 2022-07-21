using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipments.Infrastructure.EntityConfigurations
{
    public class EquipmentComponentTypeConfiguration : IEntityTypeConfiguration<EquipmentComponentType>
    {
        public void Configure(EntityTypeBuilder<EquipmentComponentType> builder)
        {
            builder.ToTable("EquipmentComponentType");

            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("id")
                   .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(120)
                   .HasColumnName("name");
        }
    }
}
