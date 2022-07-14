using System;

namespace Equipments.Domain
{
    public class Equipment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }  
        public string ModelNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ReceiptDate { get; set; }
        public bool IsActive { get; set; }
        public int EquipmentTypeId { get; set; }
    }
}
