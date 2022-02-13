using System;
using System.Xml.Serialization;
using ProcedureInjectionFramework.Attributes;

namespace Models.Classes
{
    [Serializable]
    [Model]
    [CreateProc("proc_BuildingNumber@Create")]
    [ReadProc("proc_BuildingNumber@Read")]
    [UpdateProc("proc_BuildingNumber@Update")]
    [DeleteProc("proc_BuildingNumber@Delete")]
    [XmlRoot(ElementName = "BuildingNumber")]
    public class BuildingNumber
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "Number")]
        public string Number { get; set; }

        public bool IsValid()
        {
            return Number != string.Empty && Number != null;
        }
    }
}