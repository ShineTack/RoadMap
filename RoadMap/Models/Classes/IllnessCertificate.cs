using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    [Model]
    [CreateProc("proc_IllnessCertificate@Create")]
    [ReadProc("proc_IllnessCertificate@Read")]
    [DeleteProc("proc_IllnessCertificate@Delete")]
    [Serializable]
    public class IllnessCertificate
    {
        public int Id { get; set; }
        public DateTime FirstVisit { get; set; } = DateTime.Now;
        public DateTime LastVisit { get; set; } = DateTime.Now;
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int DiseaseId { get; set; }
    }
}
