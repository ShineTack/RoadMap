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
        public Region Region { get; set; } = new Region();
        [XmlElement(Type = typeof(CityType), ElementName = "CityType")]
        public CityType CityType { get; set; } = new CityType();
        [XmlElement(Type = typeof(CityName), ElementName = "CityName")]
        public CityName CityName { get; set; } = new CityName();
        [XmlElement(Type = typeof(StreetType), ElementName = "StreetType")]
        public StreetType StreetType { get; set; } = new StreetType();
        [XmlElement(Type = typeof(StreetName), ElementName = "StreetName")]
        public StreetName StreetName { get; set; } = new StreetName();
        [XmlElement(Type = typeof(BuildingNumber), ElementName = "BuildingNumber")]
        public BuildingNumber BuildingNumber { get; set; } = new BuildingNumber();

        public bool IsValid()
        {
            bool valid = true;

            valid = Region.Id != 0;
            valid = CityType.Id != 0;
            valid = CityName.Id != 0;
            valid = StreetName.Id != 0;
            valid = StreetType.Id != 0;
            valid = BuildingNumber.Id != 0;

            return valid;
        }
    }
}