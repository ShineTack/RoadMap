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
    [ReadAll("proc_ReadAllAddressesAsString")]
    [XmlRoot("Data")]
    public class AddressesAsString
    {
        [XmlElement(ElementName = "AddressesAsString", Type = typeof(List<AddressAsString>))]
        public List<AddressAsString> AllAddresses { get; set; }
    }
}
