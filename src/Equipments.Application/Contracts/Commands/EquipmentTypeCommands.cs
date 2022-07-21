using MediatR;

namespace Equipments.Application.Contracts.Commands
{
    public class EquipmentTypeCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
    }

    public class EquipmentTypeUpdateCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EquipmentTypeDeleteCommand : IRequest
    {
        public int Id { get; set; }
    }
}
