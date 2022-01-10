using System;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_Address@Create")]
    [ReadProc("proc_Address@Read")]
    [UpdateProc("proc_Address@Update")]
    [DeleteProc("proc_Address@Delete")]
    [XmlRoot(ElementName = "Address")]
    public class Address
    {
        [XmlElement(Type = typeof(int), ElementName = "Id")]
        public int Id { get; set; }
        [XmlElement(Type = typeof(Region), ElementName = "Region")]
        public Region Region { get; set; }
        [XmlElement(Type = typeof(CityType), ElementName = "CityType")]
        public CityType CityType { get; set; }
        [XmlElement(Type = typeof(CityName), ElementName = "CityName")]
        public CityName CityName { get; set; }
        [XmlElement(Type = typeof(StreetType), ElementName = "StreetType")]
        public StreetType StreetType { get; set; }
        [XmlElement(Type = typeof(StreetName), ElementName = "StreetName")]
        public StreetName StreetName { get; set; }
        [XmlElement(Type = typeof(BuildingNumber), ElementName = "BuildingNumber")]
        public BuildingNumber BuildingNumber { get; set; }
    }
}