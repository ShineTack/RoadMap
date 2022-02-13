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
    [Serializable]
    [ReadAll("proc_PersonalInfo@ReadAll")]
    [AdditionalParams(new object[] { false })]
    [XmlRoot(ElementName = "Data")]
    public class Patients
    {
        [XmlElement(ElementName = "Patients", Type = typeof(List<Patient>))]
        public List<Patient> AllPatients { get; set; }
    }
}
