using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class EquipmentComponentType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EquipmentComponent> EquipmentComponents { get; set; }
        public virtual ICollection<PropertyType> PropertyTypes { get; set; }
    }
}
