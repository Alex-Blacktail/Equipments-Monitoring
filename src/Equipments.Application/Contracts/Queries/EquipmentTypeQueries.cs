using Equipments.Application.ViewModels;
using MediatR;

namespace Equipments.Application.Contracts.Queries
{
    public class EquipmentTypeGetListQuery : IRequest<EquipmentTypesListViewModel>
    {
    }
}
