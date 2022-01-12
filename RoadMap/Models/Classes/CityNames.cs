using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [ReadAll("proc_CityName@ReadAll")]
    [XmlRoot("Data")]
    public class CityNames
    {
        [XmlElement("CityNames", typeof(List<CityName>))]
        public List<CityName> AllCityNames { get; set; }
    }
}