using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    [Model]
    [CreateProc("proc_DiseaseType@Create")]
    [ReadProc("proc_DiseaseType@Read")]
    [UpdateProc("proc_DiseaseType@Update")]
    [DeleteProc("proc_DiseaseType@Delete")]
    [Serializable]
    public class DiseaseType
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
