using Equipments.Domain;
using Equipments.Application.Interfaces;
using Equipments.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Equipments.Infrastructure
{
    public partial class EquipmentsManagmentContext : DbContext, IEquipmentsDbContext
    {
        public EquipmentsManagmentContext(DbContextOptions<EquipmentsManagmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<EquipmentComponent> EquipmentComponents { get; set; }
        public virtual DbSet<EquipmentComponentType> EquipmentComponentTypes { get; set; }
        public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
        public virtual DbSet<PersonInfo> PersonInfos { get; set; }
        public virtual DbSet<PropertyOfEquipmentComponent> PropertyOfEquipmentComponents { get; set; }
        public virtual DbSet<PropertyType> PropertyTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentComponentConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentComponentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PersonInfoConfiguration());
            modelBuilder.ApplyConfiguration(new PropertyOfEquipmentComponentConfiguration());
            modelBuilder.ApplyConfiguration(new PropertyTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
