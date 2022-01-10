using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProcedureInjectionFramework.Core.Classes
{
    public class CRUDRepository
    {
        private DataStorage _dataStorage;

        internal CRUDRepository (DataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        public void Create<T>(T model)
        {
            SqlConnection conn = new SqlConnection(_dataStorage.ConnectionString);
            string commandName = (from crudObject in _dataStorage.procs
                                 where crudObject.ModelName == model.GetType().Name
                                 select crudObject.CreateProc).ToString();
            string xmlParameter = "";
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(model.GetType());
                serializer.Serialize(stringwriter, this);
                xmlParameter = stringwriter.ToString();
            }
            SqlCommand cmd = new SqlCommand(commandName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@xmlData", xmlParameter));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
