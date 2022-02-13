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
    [ReadAll("proc_DoctorSpecialization@ReadAll")]
    [XmlRoot(ElementName = "Data")]
    public class DoctorSpecializations
    {
        [XmlElement(ElementName = "DoctorSpecializations", Type = typeof(List<DoctorSpecialization>))]
        public List<DoctorSpecialization> AllDoctorSpecializations { get; set; }
    }
}
