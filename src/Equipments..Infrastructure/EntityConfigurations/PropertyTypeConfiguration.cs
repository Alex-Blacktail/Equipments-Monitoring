using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipments.Infrastructure.EntityConfigurations
{
    public class PropertyTypeConfiguration : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.ToTable("PropertyType");

            builder.Property(e => e.Id)
                   .HasColumnName("id")
                   .ValueGeneratedOnAdd();

            builder.Property(e => e.EquipmnetComponentTypeId).HasColumnName("equipmnet_component_type_id");

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(120)
                   .HasColumnName("name");

            builder.HasOne(d => d.EquipmnetComponentType)
                   .WithMany(p => p.PropertyTypes)
                   .HasForeignKey(d => d.EquipmnetComponentTypeId)
                   .HasConstraintName("FK__PropertyT__equip__286302EC");
        }
    }
}
