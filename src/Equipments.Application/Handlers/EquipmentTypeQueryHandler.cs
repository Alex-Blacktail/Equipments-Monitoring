using System.Threading;
using System.Threading.Tasks;
using Equipments.Application.Contracts.Queries;
using Equipments.Application.Interfaces;
using Equipments.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace Equipments.Application.Handlers
{
    public class EquipmentTypeQueryHandler :
        IRequestHandler<EquipmentTypeGetListQuery, EquipmentTypesListViewModel>
    {
        private readonly IEquipmentsDbContext _context;
        
        public EquipmentTypeQueryHandler(IEquipmentsDbContext context)
        {
            _context = context;
        }

        public async Task<EquipmentTypesListViewModel> Handle(EquipmentTypeGetListQuery request, CancellationToken cancellationToken)
        {
            var types = await _context.EquipmentTypes.ToListAsync();
            return new EquipmentTypesListViewModel { EquipmentTypes = types };
        }
    }
}
