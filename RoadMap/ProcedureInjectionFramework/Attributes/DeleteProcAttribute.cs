using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedureInjectionFramework.Attributes
{
    public class DeleteProcAttribute : Attribute
    {
        public string ProcName { get; private set; }

        public DeleteProcAttribute(string procName)
        {
            ProcName = procName;
        }
    }
}
