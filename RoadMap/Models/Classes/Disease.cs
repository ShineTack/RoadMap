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
    [CreateProc("proc_Disease@Create")]
    [ReadProc("proc_Disease@Read")]
    [UpdateProc("proc_Disease@Update")]
    [DeleteProc("proc_Disease@Delete")]
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiseaseTypeId { get; set;}
    }
}
