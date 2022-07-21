using System.Threading;
using System.Threading.Tasks;
using Equipments.Domain;
using Equipments.Application.Interfaces;
using Equipments.Application.Common.Exeptions;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Equipments.Application.Commands;

namespace Equipments.Application.Handlers
{
    public class EquipmentCommandHandler :
        IRequestHandler<EquipmentCreateCommand, int>,
        IRequestHandler<EquipmentUpdateCommand>,
        IRequestHandler<EquipmentDeleteCommand>
    {
        private readonly IEquipmentsDbContext _context;

        public EquipmentCommandHandler(IEquipmentsDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(EquipmentCreateCommand request, CancellationToken cancellationToken)
        {
            var equipment = new Equipment
            {
                InventoryNumber = request.InventoryNumber,
                ProductionDate = request.ProductionDate,
                ReceiptDate = request.ReceiptDate,
                ModelNumber = request.ModelNumber,
                Name = request.Name
            };

            await _context.Equipments.AddAsync(equipment, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return equipment.Id;
        }

        public async Task<Unit> Handle(EquipmentUpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Equipments
                .FirstOrDefaultAsync(e => e.Id == request.Id);

            if (entity == null)
            {
                throw new NotFoundExeption(nameof(Equipment), request.Id);
            }

            entity.Name = request.Name;
            entity.ProductionDate = request.ProductionDate;
            entity.ReceiptDate = request.ReceiptDate;
            entity.InventoryNumber = request.InventoryNumber;
            entity.ModelNumber = request.ModelNumber;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

        public async Task<Unit> Handle(EquipmentDeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Equipments
                .FirstOrDefaultAsync(e => e.Id == request.Id);

            if (entity == null)
            {
                throw new NotFoundExeption(nameof(Equipment), request.Id);
            }

            _context.Equipments.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
