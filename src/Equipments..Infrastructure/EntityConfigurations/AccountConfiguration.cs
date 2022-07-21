using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equipments.Infrastructure.EntityConfigurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {

        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");

            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("id");

            builder.Property(e => e.Email)
                   .IsRequired()
                   .HasMaxLength(160)
                   .HasColumnName("email");

            builder.Property(e => e.Login)
                   .IsRequired()
                   .HasMaxLength(40)
                   .HasColumnName("login");

            builder.Property(e => e.Password)
                   .IsRequired()
                   .HasMaxLength(64)
                   .HasColumnName("password");
        }
    }
}
