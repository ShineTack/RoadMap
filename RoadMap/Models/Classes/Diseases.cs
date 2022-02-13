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
    [ReadAll("proc_Disease@ReadAll")]
    [Serializable]
    [XmlRoot(ElementName = "Data")]
    public class Diseases
    {
        [XmlElement(ElementName = "Diseases", Type = typeof(List<Disease>))]
        public List<Disease> AllDiseases { get; set; }
    }
}
