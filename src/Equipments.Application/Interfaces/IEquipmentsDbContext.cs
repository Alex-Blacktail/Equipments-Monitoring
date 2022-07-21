using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Equipments.Domain;

namespace Equipments.Application.Interfaces
{
    public interface IEquipmentsDbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Equipment> Equipments { get; set; }
        DbSet<EquipmentComponent> EquipmentComponents { get; set; }
        DbSet<EquipmentComponentType> EquipmentComponentTypes { get; set; }
        DbSet<EquipmentType> EquipmentTypes { get; set; }
        DbSet<PersonInfo> PersonInfos { get; set; }
        DbSet<PropertyOfEquipmentComponent> PropertyOfEquipmentComponents { get; set; }
        DbSet<PropertyType> PropertyTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
