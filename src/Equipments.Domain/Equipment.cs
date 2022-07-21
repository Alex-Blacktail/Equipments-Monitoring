﻿using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ReceiptDate { get; set; }
        public bool IsActive { get; set; }
        public int EquipmentTypeId { get; set; }

        public virtual EquipmentType EquipmentType { get; set; }
        public virtual ICollection<EquipmentComponent> EquipmentComponents { get; set; }
    }
}