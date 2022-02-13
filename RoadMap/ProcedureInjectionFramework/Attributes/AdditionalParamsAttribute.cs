using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedureInjectionFramework.Attributes
{
    public class AdditionalParamsAttribute : Attribute
    {
        public object[] Params { get; set; }

        public AdditionalParamsAttribute(object[] _params)
        {
            Params = _params;
        }
    }
}
