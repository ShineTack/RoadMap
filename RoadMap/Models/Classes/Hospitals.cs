using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models.Classes
{
    [Model]
    [ReadAll("proc_Hospital@ReadAll")]
    [Serializable]
    [XmlRoot(ElementName = "Data")]
    public class Hospitals
    {
        [XmlElement(ElementName = "Hospitals", Type = typeof(List<Hospital>))]
        public List<Hospital> AllHospitals { get; set; }
    }
}
