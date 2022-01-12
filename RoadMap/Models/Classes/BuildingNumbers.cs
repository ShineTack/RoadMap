using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [ReadAll("proc_BuildingNumber@ReadAll")]
    [XmlRoot("Data")]
    public class BuildingNumbers
    {
        [XmlElement("BuildingNumbers", typeof(List<BuildingNumber>))]
        public List<BuildingNumber> AllBuildingNumbers { get; set; }
    }
}