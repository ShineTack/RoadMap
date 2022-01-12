using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [ReadAll("proc_Region@ReadAll")]
    [XmlRoot("Data")]
    public class Regions
    {
        [XmlElement("Regions", typeof(List<Region>))]
        public List<Region> AllRegions { get; set; }
    }
}