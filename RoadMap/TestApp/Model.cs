using ProcedureInjectionFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    [Model]
    [CreateProc("proc_Model@Create")]
    [UpdateProc("proc_Model@Update")]
    [ReadProc("proc_Model@Read")]
    class Model
    {
    }
}
