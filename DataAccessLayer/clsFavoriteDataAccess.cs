using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsFavoriteDataAccess
    {
        static public int Add(int SuratID)
        {
            int lastid = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"INSERT INTO [dbo].[Favorites]
     VALUES
           (@SuratID)" + "\nselect SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SuratID", SuratID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    lastid = ID;
                else
                    lastid = 0;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;

            }
            finally { connection.Close(); }
            return lastid;
        }


        static public bool Delete(int SuratID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"DELETE FROM [dbo].[Favorites] WHERE SuratID = @SuratID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SuratID", SuratID);

            try
            {
                connection.Open();
                 result = command.ExecuteNonQuery()>0;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;

            }
            finally { connection.Close(); }
            return result;
        }

        static public DataTable GetData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = "Select *from Favorites";
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
                dt = null;
            }
            finally { connection.Close(); }
            return dt;
        }

        static public bool Exist(int SuratID)
        {
            int lastid = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select found = 1 FROM [dbo].[Favorites] WHERE SuratID = @SuratID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SuratID", SuratID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                    lastid = ID;
                else
                    lastid = 0;
            }
            catch (Exception ex)
            {
                string Message = ex.Message;

            }
            finally { connection.Close(); }
            return lastid==1;
        }


    }
}
