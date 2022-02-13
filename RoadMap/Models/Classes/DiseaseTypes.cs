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
    [ReadAll("proc_DiseaseType@ReadAll")]
    [Serializable]
    [XmlRoot(ElementName = "Data")]
    public class DiseaseTypes
    {
        [XmlElement(ElementName = "DiseaseTypes", Type = typeof(List<DiseaseType>))]
        public List<DiseaseType> AllDiseaseTypes { get; set; }
    }
}
