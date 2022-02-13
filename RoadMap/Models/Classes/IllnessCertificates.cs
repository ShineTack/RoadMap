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
    [ReadAll("proc_IllnessCertificate@ReadAll")]
    [XmlRoot(ElementName = "Data")]
    public class IllnessCertificates
    {
        [XmlElement(ElementName = "IllnessCertificates", Type = typeof(List<IllnessCertificate>))]
        public List<IllnessCertificate> AllIllnessCertificates { get; set; }
    }
}
