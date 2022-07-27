using AutoMapper;
using Equipments.Application.Common.Mappings;
using Equipments.Domain;

namespace Equipments.Application.ViewModels
{
    public class EquipmentLookupViewModel : IMapWith<Equipment>
    {
        public int Id { get; set; }
        public string EquipmentType { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Equipment, EquipmentLookupViewModel>()
                .ForMember(vm => vm.Id, e => e.MapFrom(e => e.Id))
                .ForMember(vm => vm.EquipmentType, e => e.MapFrom(e => e.EquipmentType.Name))
                .ForMember(vm => vm.Name, e => e.MapFrom(e => e.Name))
                .ForMember(vm => vm.ModelNumber, e => e.MapFrom(e => e.ModelNumber));
        }
    }
}
