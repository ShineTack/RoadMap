using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    [Model]
    [Serializable]
    public class Info
    {
        public int CertificateId { get; set; }
        public DateTime FirstVisit { get; set; }
        public DateTime LastVisit { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseType { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSpecialization { get; set; }
        public string HospitalName { get; set; }
    }
}
