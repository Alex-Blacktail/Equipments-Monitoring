using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class EquipmentComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ReceiptDate { get; set; }
        public bool IsActive { get; set; }
        public int EquipmentComponentTypeId { get; set; }
        public int? EquipmentId { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentComponentType EquipmentComponentType { get; set; }
        public virtual ICollection<PropertyOfEquipmentComponent> PropertyOfEquipmentComponents { get; set; }
    }
}
