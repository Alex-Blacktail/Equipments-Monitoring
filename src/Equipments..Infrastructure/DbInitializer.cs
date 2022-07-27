using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipments.Infrastructure
{
    public class DbInitializer
    {
        public static void Initialize(EquipmentsManagmentContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
