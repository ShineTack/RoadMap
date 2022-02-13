using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_DoctorSpecialization@Create")]
    [ReadProc("proc_DoctorSpecialization@Read")]
    [UpdateProc("proc_DoctorSpecialization@Update")]
    [DeleteProc("proc_DoctorSpecialization@Delete")]
    [XmlRoot(ElementName = "DoctorSpecialization")]
    public class DoctorSpecialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
