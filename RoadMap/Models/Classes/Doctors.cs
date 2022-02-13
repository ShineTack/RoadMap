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
    [AdditionalParams(new object[] { true })]
    [XmlRoot(ElementName = "Data")]
    public class Doctors
    {
        [XmlElement(ElementName = "Doctors", Type = typeof(List<Doctor>))]
        public List<Doctor> AllDoctors { get; set; }
    }
}
