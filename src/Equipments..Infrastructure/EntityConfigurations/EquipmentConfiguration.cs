using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipments.Infrastructure.EntityConfigurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("id");

            builder.Property(e => e.EquipmentTypeId)
                   .HasColumnName("equipment_type_id");

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

            builder.HasOne(d => d.EquipmentType)
                   .WithMany(p => p.Equipment)
                   .HasForeignKey(d => d.EquipmentTypeId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK__Equipment__equip__33D4B598");
        }
    }
}
