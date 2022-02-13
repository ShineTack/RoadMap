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

            /*int patientId = repository.Create<Patient>(new Patient()
            {
                FullName = "Pavel",
                AddressId = 15,
                BirthDate = DateTime.Now.AddYears(-20),
                Email = "tackshine@gmail.com"
            });

            int hospitalId = repository.Create<Hospital>(new Hospital()
            { 
                Name = "Gorodskaya bolnica",
                AddressId = 18
            });

            int doctorSpecializationId = repository.Create<DoctorSpecialization>(new DoctorSpecialization() 
            { 
                Name = "Lor"
            });

            int doctorId = repository.Create<Doctor>(new Doctor() 
            { 
                FullName = "Aleksey",
                AddressId = 19,
                SpecializationId = doctorSpecializationId,
                Email = "shinetack@gmail.com",
                BirthDate = DateTime.Now.AddYears(-50),
                HospitalId = hospitalId
            });

            int diseaseTypeId = repository.Create<DiseaseType>(new DiseaseType() 
            { 
                Type = "Bact"
            });

            int diseaseId = repository.Create<Disease>(new Disease() 
            { 
                Name = "Atit",
                DiseaseTypeId = diseaseTypeId
            });

            int illnessCertificateId = repository.Create<IllnessCertificate>(new IllnessCertificate() 
            { 
                FirstVisit = DateTime.Now,
                LastVisit = DateTime.Now,
                DiseaseId = diseaseId,
                DoctorId = doctorId,
                PatientId = patientId
            });

            int noteIllnessCertificateId = repository.Create<NoteIllnessCertificate>(new NoteIllnessCertificate()
            { 
                Note = Guid.NewGuid().ToString(),
                Date = DateTime.Now,
                IllnessCertificateId = illnessCertificateId
            });*/

            var allInfo = repository.ReadAll<Infoses>();

            Console.ReadLine();
        }
    }
}
