using System;
using System.Collections.Generic;

namespace Equipments.Domain
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
