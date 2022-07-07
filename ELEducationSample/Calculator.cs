using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace ELEducationSample
{
    public interface ISimpleCalculator
    {
        int Add(int start, int amount);
        int Subtract(int start, int amount);
        int Multiply(int start, int by);
        int Divide(int start, int by);
    }

    public interface IDebugWrite
    {
        string DebugWrite(int result);
        void DebugWriteToDB(string operation, int result);
    }

    public class Calculator : ISimpleCalculator, IDebugWrite
    {
        public int Add(int start, int amount)
        {
            int r = start + amount;
            DebugWrite(r);
            DebugWriteToDB("Add",r);
            return r;
        }
        public int Subtract(int start, int amount)
        {
            int r = start - amount;
            DebugWrite(r);
            DebugWriteToDB("Subtract", r);
            return r;
        }
        public int Multiply(int start, int by)
        {
            int r = start * by;
            DebugWrite(r);
            DebugWriteToDB("Multiply",r);
            return r;
        }
        public int Divide(int start, int by)
        {
            int r = start / by;
            DebugWrite(r);
            DebugWriteToDB("Divide",r);
            return r;
        }
        public String DebugWrite(int result)
        {
            Debug.WriteLine(result.ToString());
            return result.ToString();
        }

        public void DebugWriteToDB(string operation, int result)
        {
            //try
            //{
            //    String query = "INSERT INTO dbo.tblLogging (Result,LogDate) VALUES (@result,@timestamp)";
            //    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connstr))
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.Add("@result", SqlDbType.NChar).Value = string.Format("{0}: {1}", operation, result);
            //        command.Parameters.Add("@timestamp", SqlDbType.DateTime).Value = DateTime.Now;
            //        connection.Open();
            //        command.ExecuteNonQuery();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex.Message);
            //}
        }
    }
}
