using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedureInjectionFramework.Core.Classes
{
    [Serializable]
    internal class DataStorage
    {
        public DataStorage(string connectionString, List<CRUDProc> procs)
        {
            ConnectionString = connectionString;
            this.procs = procs;
        }

        public string ConnectionString { get; private set; }
        public List<CRUDProc> procs { get; private set; }


    }
}
