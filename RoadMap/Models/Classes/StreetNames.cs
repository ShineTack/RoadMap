using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [ReadAll("proc_StreetName@ReadAll")]
    [XmlRoot("Data")]
    public class StreetNames
    {
        [XmlElement("StreetNames", typeof(List<StreetName>))]
        public List<StreetName> AllStreetNames { get; set; }
    }
}