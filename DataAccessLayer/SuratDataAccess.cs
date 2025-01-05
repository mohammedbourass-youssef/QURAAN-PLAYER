using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
namespace DataAccessLayer
{
    public class SuratDataAccess
    {
        static public DataTable GetAllSong()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select *from Surats";
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
        static public DataTable GetTop6()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select top 5  ID, case 
     when SecondName is not null then Readers.FirstName + ' ' + Readers.SecondName + ' '+Readers.LastName 
	 when SecondName is  null then Readers.FirstName + ' ' +Readers.LastName 
	 end as FullName
, SuratNAme,path from Surats join SuratesName on Surats.SuratIDName = SuratesName.SuratID 
                                                      join Readers on Readers.ReaderID =Surats.ReaderID 
ORDER BY NEWID();";
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
        static public DataTable GetAllSongOfSurat(int suratID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select ID,case 
     when SecondName is not null then Readers.FirstName + ' ' + Readers.SecondName + ' '+Readers.LastName 
	 when SecondName is  null then Readers.FirstName + ' ' +Readers.LastName 
	 end as FullName
, SuratNAme,path from Surats join SuratesName on Surats.SuratIDName = SuratesName.SuratID 
                                                      join Readers on Readers.ReaderID =Surats.ReaderID 
													Where SuratID = @SuratID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SuratID", suratID);
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
        static public DataTable GetTop5SuratOf(int ReaderID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"select top 5 *from Surats join SuratesName on SuratesName.SuratID = Surats.SuratIDName
                             where ReaderID = @ReaderID
                             order by newid()";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReaderID", ReaderID);
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
        static public int AddNew(int readerID,string path,int suratnameID)
        {
            //issue reason : 1-FirstTime, 2-Renew, 3-Replacement for Damaged, 4- Replacement for Lost.
            int lastid = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"INSERT INTO [dbo].[Surats]
     VALUES
           (@ReaderID
           ,@Path
           ,@SuratIDName);"+"\nselect SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReaderID", readerID);
            command.Parameters.AddWithValue("@Path", path);
            command.Parameters.AddWithValue("@SuratIDName", suratnameID);
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
        static public bool Update(int suratID ,int readerID, string path, int suratnameID)
        {
            //issue reason : 1-FirstTime, 2-Renew, 3-Replacement for Damaged, 4- Replacement for Lost.
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"UPDATE [dbo].[Surats]
   SET [ReaderID] = @ReaderID
      ,[Path] = @Path
      ,[SuratIDName] = @SuratIDName
 WHERE [Surats].ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReaderID", readerID);
            command.Parameters.AddWithValue("@Path", path);
            command.Parameters.AddWithValue("@SuratIDName", suratnameID);
            command.Parameters.AddWithValue("@ID", suratID);
           
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                string Message = ex.Message;

            }
            finally { connection.Close(); }
            return result;
        }
        static public bool Find(int suratID,ref int readerID,ref string path,ref int suratnameID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select *from Surats Where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", suratID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    suratnameID = (int)reader["SuratIDName"];
                    readerID = (int)reader["ReaderID"];
                    path = (string)reader["Path"];                  
                    result = true;
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return result;
        }
       
        static public bool IsExist(int suratID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select found = 1 from Surats Where ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", suratID);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && bool.TryParse(obj.ToString(), out bool isactive))
                    result = isactive;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally { connection.Close(); }
            return result;
        }

        static public bool IsExist(int suratID,int readerID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"select case when exists (
                    select 1 from Surats 
                    where ReaderID = @ReaderID and SuratIDName = @SuratIDName
                ) then 1 else 0 end as found";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SuratIDName", suratID);
            command.Parameters.AddWithValue("@ReaderID", readerID);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && obj.ToString() == "1")
                    result = true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message; // Log or handle the exception as needed
            }
            finally
            {
                connection.Close();
            }
            return result;

        }

    }
}
