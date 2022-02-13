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
    [ReadAll("proc_AllInfo@ReadAll")]
    [XmlRoot(ElementName = "Data")]
    public class Infoses
    {
        [XmlElement(ElementName = "Infoses", Type = typeof(List<Info>))]
        public List<Info> AllInfo { get; set; }
    }
}
