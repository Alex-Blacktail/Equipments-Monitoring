using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class EquipmentType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
