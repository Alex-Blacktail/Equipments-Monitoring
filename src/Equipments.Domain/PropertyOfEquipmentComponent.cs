using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class PropertyOfEquipmentComponent
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int EquipmentComponentId { get; set; }

        public virtual EquipmentComponent EquipmentComponent { get; set; }
    }
}
