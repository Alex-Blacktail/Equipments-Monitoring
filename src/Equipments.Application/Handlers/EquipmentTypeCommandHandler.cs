using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Equipments.Application.Contracts.Commands;
using Equipments.Application.Interfaces;
using Equipments.Domain;
using Microsoft.EntityFrameworkCore;
using Equipments.Application.Common.Exeptions;

namespace Equipments.Application.Handlers
{
    public class EquipmentTypeCommandHandler :
        IRequestHandler<EquipmentTypeCreateCommand, int>,
        IRequestHandler<EquipmentTypeUpdateCommand>,
        IRequestHandler<EquipmentTypeDeleteCommand>
    {

        private readonly IEquipmentsDbContext _context;

        public EquipmentTypeCommandHandler(IEquipmentsDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(EquipmentTypeCreateCommand request, CancellationToken cancellationToken)
        {
            var equipmentType = new EquipmentType { Name = request.Name };
            await _context.EquipmentTypes.AddAsync(equipmentType, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return equipmentType.Id;
        }

        public async Task<Unit> Handle(EquipmentTypeUpdateCommand request, CancellationToken cancellationToken)
        {
            var equipmentType = await _context.EquipmentTypes
                .FirstOrDefaultAsync(e => e.Id == request.Id);

            if(equipmentType == null)
            {
                throw new NotFoundExeption(nameof(EquipmentType), equipmentType.Id);
            }

            equipmentType.Name = request.Name;
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

        public async Task<Unit> Handle(EquipmentTypeDeleteCommand request, CancellationToken cancellationToken)
        {
            var equipmentType = await _context.EquipmentTypes
               .FirstOrDefaultAsync(e => e.Id == request.Id);

            if (equipmentType == null)
            {
                throw new NotFoundExeption(nameof(EquipmentType), equipmentType.Id);
            }

            _context.EquipmentTypes.Remove(equipmentType);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
