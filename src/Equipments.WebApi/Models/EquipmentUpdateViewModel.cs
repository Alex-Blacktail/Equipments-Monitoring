using AutoMapper;
using Equipments.Application.Commands;
using Equipments.Application.Common.Mappings;

namespace Equipments.WebApi.Models
{
    public class EquipmentUpdateViewModel : IMapWith<EquipmentUpdateCommand>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ReceiptDate { get; set; }

        public int EquipmentTypeId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EquipmentUpdateViewModel, EquipmentUpdateCommand>()
               .ForMember(с => с.Id, e => e.MapFrom(vm => vm.Id))
               .ForMember(с => с.Name, e => e.MapFrom(vm => vm.Name))
               .ForMember(с => с.ModelNumber, e => e.MapFrom(vm => vm.ModelNumber))
               .ForMember(с => с.InventoryNumber, e => e.MapFrom(vm => vm.InventoryNumber))
               .ForMember(с => с.ProductionDate, e => e.MapFrom(vm => vm.ProductionDate))
               .ForMember(с => с.ReceiptDate, e => e.MapFrom(vm => vm.ReceiptDate))
               .ForMember(c => c.EquipmentTypeId, e => e.MapFrom(vm => vm.EquipmentTypeId));

        }
    }
}
