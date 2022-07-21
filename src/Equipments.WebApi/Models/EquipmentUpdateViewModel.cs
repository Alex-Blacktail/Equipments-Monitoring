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

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EquipmentUpdateViewModel, EquipmentUpdateCommand>()
               .ForMember(vm => vm.Id, e => e.MapFrom(e => e.Name))
               .ForMember(vm => vm.Name, e => e.MapFrom(e => e.Name))
               .ForMember(vm => vm.ModelNumber, e => e.MapFrom(e => e.ModelNumber))
               .ForMember(vm => vm.InventoryNumber, e => e.MapFrom(e => e.InventoryNumber))
               .ForMember(vm => vm.ProductionDate, e => e.MapFrom(e => e.ProductionDate))
               .ForMember(vm => vm.ReceiptDate, e => e.MapFrom(e => e.ReceiptDate));
        }
    }
}
