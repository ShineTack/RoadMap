using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedureInjectionFramework.Attributes
{
    public class CreateProcAttribute : Attribute
    {
        public string ProcName { get; private set; }

        public CreateProcAttribute(string procName)
        {
            ProcName = procName;
        }
    }
}
