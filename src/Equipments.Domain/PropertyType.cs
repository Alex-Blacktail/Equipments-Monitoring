using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class PropertyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EquipmnetComponentTypeId { get; set; }

        public virtual EquipmentComponentType EquipmnetComponentType { get; set; }
    }
}
