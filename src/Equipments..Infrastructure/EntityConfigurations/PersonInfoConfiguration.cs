using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipments.Infrastructure.EntityConfigurations
{
    public class PersonInfoConfiguration : IEntityTypeConfiguration<PersonInfo>
    {
        public void Configure(EntityTypeBuilder<PersonInfo> builder)
        {
            builder.Property(e => e.Id)
                   .HasColumnName("id")
                   .ValueGeneratedOnAdd();

            builder.ToTable("PersonInfo");

            builder.Property(e => e.AccountId)
                   .HasColumnName("account_id");

            builder.Property(e => e.Firstname)
                   .IsRequired()
                   .HasMaxLength(120)
                   .HasColumnName("firstname");

            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("id");

            builder.Property(e => e.Middlename)
                   .IsRequired()
                   .HasMaxLength(120)
                   .HasColumnName("middlename");

            builder.Property(e => e.Surname)
                   .IsRequired()
                   .HasMaxLength(120)
                   .HasColumnName("surname");

            builder.HasOne(d => d.Account)
                   .WithMany()
                   .HasForeignKey(d => d.AccountId)
                   .HasConstraintName("FK__PersonInf__accou__49C3F6B7");
        }
    }
}
