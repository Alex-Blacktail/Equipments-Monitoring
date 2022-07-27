using AutoMapper;
using Equipments.Application.Common.Mappings;
using Equipments.Application.Contracts.Commands;

namespace Equipments.WebApi.Models
{
    public class EquipmentTypeCreateViewModel : IMapWith<EquipmentTypeCreateCommand>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EquipmentTypeCreateViewModel, EquipmentTypeCreateCommand>()
                .ForMember(c => c.Name, e => e.MapFrom(vm => vm.Name));
        }
    }
}
