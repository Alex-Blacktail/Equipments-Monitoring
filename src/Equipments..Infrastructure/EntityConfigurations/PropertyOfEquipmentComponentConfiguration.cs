using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipments.Infrastructure.EntityConfigurations
{
    public class PropertyOfEquipmentComponentConfiguration : IEntityTypeConfiguration<PropertyOfEquipmentComponent>
    {
        public void Configure(EntityTypeBuilder<PropertyOfEquipmentComponent> builder)
        {
            builder.ToTable("PropertyOfEquipmentComponent");

            builder.Property(e => e.Id)
                   .HasColumnName("id")
                   .ValueGeneratedOnAdd();

            builder.Property(e => e.EquipmentComponentId).HasColumnName("equipment_component_id");

            builder.Property(e => e.Value)
                   .IsRequired()
                   .HasMaxLength(120)
                   .HasColumnName("value");

            builder.HasOne(d => d.EquipmentComponent)
                   .WithMany(p => p.PropertyOfEquipmentComponents)
                   .HasForeignKey(d => d.EquipmentComponentId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK__PropertyO__equip__412EB0B6");
        }
    }
}
