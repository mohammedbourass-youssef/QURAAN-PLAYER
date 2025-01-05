using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class clsSuratsNamesDataAccess
    {
        public static string GetNameByID(int suratnameID)
        {
            string result = "";
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"select SuratName from SuratesName where SuratID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", suratnameID);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null)
                    result = obj.ToString();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally { connection.Close(); }
            return result;
        }
        public static int GetIDByName(string suratnameID)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"select SuratID  from SuratesName where SuratName = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", suratnameID);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null)
                    result = int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally { connection.Close(); }
            return result;
        }
        static public DataTable GetAllSorahsNAmes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"select *from SuratesName";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally { connection.Close(); }
            return dt;
        }
    }
}
