using ProcedureInjectionFramework.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    public static class CrudService
    {
        public static CRUDRepository repository { get; set; }

        public static void CrudServiceInitialize()
        {
            ProcedureInjectionInitializer initializer =
                new ProcedureInjectionInitializer(
                    "Data Source=(LocalDb)\\MSSqlLocalDb;Initial Catalog=Polyclinic;Integrated Security=True;",
                    Assembly.Load("Models").GetTypes());
            repository = initializer.GetCRUDRepository();
        }
    }
}
