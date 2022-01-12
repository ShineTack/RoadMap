using ProcedureInjectionFramework.Attributes;
using ProcedureInjectionFramework.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models.Classes;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcedureInjectionInitializer initializer =
                new ProcedureInjectionInitializer(
                    "Data Source=(LocalDb)\\MSSqlLocalDb;Initial Catalog=Polyclinic;Integrated Security=True;",
                    Assembly.Load("Models").GetTypes());
            CRUDRepository repository = initializer.GetCRUDRepository();

            var obj = repository.ReadById<CityType>(2);

            Console.ReadLine();
        }
    }
}
