using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [ReadAll("proc_StreetType@ReadAll")]
    [XmlRoot("Data")]
    public class StreetTypes
    {
        [XmlElement("StreetTypes", typeof(List<StreetType>))]
        public List<StreetType> AllStreetTypes { get; set; }
    }
}