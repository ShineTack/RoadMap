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

            Address address = new Address() 
            { 
                Region = new Region() { Id = 1 },
                CityType = new CityType() { Id = 1},
                CityName = new CityName() { Id = 2},
                StreetType = new StreetType() { Id = 1},
                StreetName = new StreetName() { Id = 1},
                BuildingNumber = new BuildingNumber() { Id = 1}
            };

            try
            {
                repository.Create<Address>(address);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            address = repository.Read<Address>(13);
            
            Console.WriteLine(address.Id);
            Console.WriteLine(address.CityName.Name);
            Console.WriteLine(address.StreetName.Id);
            Console.WriteLine(address.StreetName.Name);
            
            address.CityName.Id = 1;
            repository.Update<Address>(address);

            address = repository.Read<Address>(13);
            
            Console.WriteLine(address.Id);
            Console.WriteLine(address.CityName.Name);
            
            repository.Delete<Address>(16);
            repository.Delete<Address>(17);

            Console.ReadLine();
        }
    }
}
