using AutoMapper;
using Equipments.Application.Commands;
using Equipments.Application.Common.Mappings;

namespace Equipments.WebApi.Models
{
    public class EquipmentCreateViewModel : IMapWith<EquipmentCreateCommand>
    {
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ReceiptDate { get; set; }

        public int EquipmentTypeId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EquipmentCreateViewModel, EquipmentCreateCommand>()
               .ForMember(c => c.Name, e => e.MapFrom(vm => vm.Name))
               .ForMember(c => c.ModelNumber, e => e.MapFrom(vm => vm.ModelNumber))
               .ForMember(c => c.InventoryNumber, e => e.MapFrom(vm => vm.InventoryNumber))
               .ForMember(c => c.ProductionDate, e => e.MapFrom(vm => vm.ProductionDate))
               .ForMember(c => c.ReceiptDate, e => e.MapFrom(vm => vm.ReceiptDate))
               .ForMember(c => c.EquipmentTypeId, e => e.MapFrom(vm => vm.EquipmentTypeId));
        }
    }
}
