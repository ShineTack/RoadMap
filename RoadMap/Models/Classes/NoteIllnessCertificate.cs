using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    [Model]
    [CreateProc("proc_NoteIllnessCertificate@Create")]
    [Serializable]
    public class NoteIllnessCertificate
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int IllnessCertificateId { get; set; }
    }
}
