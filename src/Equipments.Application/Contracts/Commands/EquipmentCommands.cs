using System;
using MediatR;

namespace Equipments.Application.Commands
{
    public class EquipmentCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ReceiptDate { get; set; }
    }

    public class EquipmentUpdateCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ReceiptDate { get; set; }
    }

    public class EquipmentDeleteCommand : IRequest
    {
        public int Id { get; set; }
    }
}
    
