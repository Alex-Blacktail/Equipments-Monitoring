using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Equipments.Application.Interfaces;
using Equipments.Application.ViewModels;
using Equipments.Application.Common.Exeptions;
using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Equipments.Application.Queries;

namespace Equipments.Application.Handlers
{
    public class EquipmentQueryHandler :
        IRequestHandler<EquipmentGetDetailsQuery, EquipmentDetailsViewModel>,
        IRequestHandler<EquipmentGetListQuery, EquipmentsListViewModel>
    {
        private readonly IEquipmentsDbContext _context;
        private readonly IMapper _mapper;

        public EquipmentQueryHandler(IEquipmentsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EquipmentDetailsViewModel> Handle(EquipmentGetDetailsQuery request, CancellationToken cancellationToken)
        {
            var equipment = await _context.Equipments
                .FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken);

            if (equipment == null)
            {
                throw new NotFoundExeption(nameof(equipment), request.Id);
            }

            return _mapper.Map<EquipmentDetailsViewModel>(equipment);
        }

        public async Task<EquipmentsListViewModel> Handle(EquipmentGetListQuery request, CancellationToken cancellationToken)
        {
            var equipments = await _context.Equipments
                .ProjectTo<EquipmentLookupViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return new EquipmentsListViewModel { Equipments = equipments };
        }
    }
}
