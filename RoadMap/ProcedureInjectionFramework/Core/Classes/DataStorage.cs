using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedureInjectionFramework.Core.Classes
{
    [Serializable]
    public class DataStorage
    {
        public DataStorage(string connectionString, List<CRUDProc> procs)
        {
            ConnectionString = connectionString;
            this.procs = procs;
        }

        public DataStorage()
        {

        }

        public string ConnectionString { get; set; }
        public List<CRUDProc> procs { get; set; }


    }
}
