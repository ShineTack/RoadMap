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
            string commandName = _dataStorage.procs.Where(proc => proc.ModelName == model.GetType().Name).Select(proc => proc.CreateProc).ToArray()[0];
            string xmlParameter = "";
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(model.GetType());
                serializer.Serialize(stringwriter, model);
                xmlParameter = stringwriter.ToString();
            }
            SqlCommand cmd = new SqlCommand(commandName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@xmlData", xmlParameter));
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
