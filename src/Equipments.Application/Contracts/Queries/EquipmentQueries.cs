using System;
using MediatR;
using Equipments.Application.ViewModels;

namespace Equipments.Application.Queries
{
    public class EquipmentGetDetailsQuery : IRequest<EquipmentDetailsViewModel>
    {
        public int Id { get; set; }
    }

    public class EquipmentGetListQuery : IRequest<EquipmentsListViewModel>
    {
    }
}
