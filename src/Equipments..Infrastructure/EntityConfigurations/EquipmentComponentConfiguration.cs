using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipments.Infrastructure.EntityConfigurations
{
    public class EquipmentComponentConfiguration : IEntityTypeConfiguration<EquipmentComponent>
    {
        public void Configure(EntityTypeBuilder<EquipmentComponent> builder)
        {
            builder.ToTable("EquipmentComponent");

            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("id");

            builder.Property(e => e.EquipmentComponentTypeId).HasColumnName("equipment_component_type_id");

            builder.Property(e => e.EquipmentId).HasColumnName("equipment_id");

            builder.Property(e => e.InventoryNumber)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnName("inventory_number");

            builder.Property(e => e.IsActive)
                   .IsRequired()
                   .HasColumnName("is_active");

            builder.Property(e => e.ModelNumber)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnName("model_number");

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(120)
                   .HasColumnName("name");

            builder.Property(e => e.ProductionDate)
                   .HasColumnType("date")
                   .HasColumnName("production_date");

            builder.Property(e => e.ReceiptDate)
                   .HasColumnType("date")
                   .HasColumnName("receipt_date");

            builder.HasOne(d => d.EquipmentComponentType)
                   .WithMany(p => p.EquipmentComponents)
                   .HasForeignKey(d => d.EquipmentComponentTypeId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK__Equipment__equip__3C69FB99");

            builder.HasOne(d => d.Equipment)
                   .WithMany(p => p.EquipmentComponents)
                   .HasForeignKey(d => d.EquipmentId)
                   .HasConstraintName("FK__Equipment__equip__3D5E1FD2");
        }
    }
}
