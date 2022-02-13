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
    [CreateProc("proc_Hospital@Create")]
    [UpdateProc("proc_Hospital@Update")]
    [ReadProc("proc_Hospital@Read")]
    [DeleteProc("proc_Hospital@Delete")]
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public string Address { get; set; }
    }
}
