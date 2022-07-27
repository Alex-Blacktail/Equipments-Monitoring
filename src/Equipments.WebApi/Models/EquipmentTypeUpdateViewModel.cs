using AutoMapper;
using Equipments.Application.Common.Mappings;
using Equipments.Application.Contracts.Commands;

namespace Equipments.WebApi.Models
{
    public class EquipmentTypeUpdateViewModel : IMapWith<EquipmentTypeUpdateCommand>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<EquipmentTypeUpdateViewModel, EquipmentTypeUpdateCommand>()
                .ForMember(c => c.Id, e => e.MapFrom(vm => vm.Id));
        }
    }
}
