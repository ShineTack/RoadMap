using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [ReadAll("proc_CityType@ReadAll")]
    [XmlRoot("Data")]
    public class CityTypes
    {
        [XmlElement("CityTypes", typeof(List<CityType>))]
        public List<CityType> AllCityTypes { get; set; }
    }
}