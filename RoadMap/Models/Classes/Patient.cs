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
    [CreateProc("proc_Personalinfo@Create")]
    [UpdateProc("proc_Personalinfo@Update")]
    [ReadProc("proc_Personalinfo@Read")]
    [DeleteProc("proc_Personalinfo@Delete")]
    [AdditionalParams(new object[] { false })]
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int AddressId { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
