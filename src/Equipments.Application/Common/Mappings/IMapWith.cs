using AutoMapper;

namespace Equipments.Application.Common.Mappings
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile);
    }
}
