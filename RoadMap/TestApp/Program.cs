using ProcedureInjectionFramework.Attributes;
using ProcedureInjectionFramework.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcedureInjectionInitializer initializer = 
                new ProcedureInjectionInitializer(
                    "Data Source=(LocalDb)\\MSSqlLocalDb;Initial Catalog=Polyclinic;Integrated Security=True;", 
                Assembly.GetExecutingAssembly().GetTypes());
            CRUDRepository repository = initializer.GetCRUDRepository();

            Address address = new Address() 
            { 
                Region = new Region() { id = 1 },
                CityType = new CityType() { id = 1},
                CityName = new CityName() { id = 1},
                StreetType = new StreetType() { id = 1},
                StreetName = new StreetName() { id = 1},
                BuildingNumber = new BuildingNumber() { id = 1}
            };

            try
            {
                repository.Create<Address>(address);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }


    }

    [Model]
    [CreateProc("proc_Address@Create")]
    [Serializable]
    public class Address
    {
        public int id { get; set; }
        public Region Region { get; set; }
        public CityType CityType { get; set; }
        public CityName CityName { get; set;}
        public StreetType StreetType { get; set; }
        public StreetName StreetName { get; set; }
        public BuildingNumber BuildingNumber { get; set; }
    }

    [Model]
    [Serializable]
    public class BuildingNumber
    {
        public int id
        {
            get; set;
        }
    }

    [Model]
    [Serializable]
    public class StreetName
    {
        public int id
        {
            get; set;
        }
    }

    [Model]
    [Serializable]
    public class StreetType
    {
        public int id
        {
            get; set;
        }
    }

    [Model]
    [Serializable]
    public class CityName
    {
        public int id { get; set; }
    }

    [Model]
    [Serializable]
    public class CityType
    {
        public int id { get; set; }
    }

    [Model]
    [Serializable]
    public class Region
    {
        public int id { get; set; }
    }
}
