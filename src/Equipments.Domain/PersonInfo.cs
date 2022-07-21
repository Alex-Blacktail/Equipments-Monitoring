using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class PersonInfo
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public int? AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
