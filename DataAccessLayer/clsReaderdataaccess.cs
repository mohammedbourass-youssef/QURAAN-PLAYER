using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class clsReaderdataaccess
    {
        static public DataTable GetAllReaders()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select *from Readers";
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

        public static int CountNumberOfExistedSurat(int readerID)
        {
            int result = -1;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select Count(*) as numberofsurat from Surats where  ReaderID = @ReaderID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReaderID", readerID);
            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();
                if (obj != null && int.TryParse(obj.ToString(), out int a))
                    result = a;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            finally { connection.Close(); }
            return result;
        }

        static public bool Find(int readerID, ref string firstname, ref string lastname,ref string secondname,ref string picturepah)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select *from Readers Where ReaderID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", readerID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   
                    readerID = (int)reader["ReaderID"];
                    firstname = (string)reader["FirstName"];
                    lastname = (string)reader["LastName"];
                    if (reader["SecondName"]==DBNull.Value)
                    {
                        secondname = "";
                    }
                    else
                    {
                        secondname = (string)reader["SecondName"];
                    }
                    if (reader["PicturePath"] != DBNull.Value)
                    {
                        picturepah = (string)reader["PicturePath"];
                    }
                    else
                        picturepah = "";
                    result = true;
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return result;
        }
        static public bool Find(string fullname,ref int readerID  ,  ref string picturepah)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"SELECT *from ReaderWithFullNameAttribute_View
where fullname = @fullname";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@fullname", fullname);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    readerID = (int)reader["ReaderID"];
                    if (reader["PicturePath"] != DBNull.Value)
                    {
                        picturepah = (string)reader["PicturePath"];
                    }
                    else
                        picturepah = "";
                    result = true;
                }
                reader.Close();
            }
            catch (Exception ex) {
                   string mes = ex.Message;
            }
            finally { connection.Close(); }
            return result;
        }
        static public DataTable GetTop6Readers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"Select top 6 *from Readers";
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
        static public int AddNew(int readerID,  string firstname, string lastname, string secondname, string picturepah)
        {
           
            int lastid = 0;
            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
            string query = @"INSERT INTO [dbo].[Readers]
     VALUES
           (@FirstName
           ,@LastName
           ,@SecondName
           ,@PicturePath) ;
           select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReaderID", readerID);
            command.Parameters.AddWithValue("@FirstName", firstname);
            command.Parameters.AddWithValue("@LastName", lastname);
            command.Parameters.AddWithValue("@PicturePath", picturepah);
            if (!string.IsNullOrEmpty(secondname))
                command.Parameters.AddWithValue("@SecondName", secondname);
            else
                command.Parameters.AddWithValue("@SecondName", DBNull.Value);

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


        //not Implemented 
 //       static public bool Update(int readerID, string firstname, string lastname, string secondname, string picturepah)
 //       {
 //           //issue reason : 1-FirstTime, 2-Renew, 3-Replacement for Damaged, 4- Replacement for Lost.
 //           bool result = false;
 //           SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
 //           string query = @"UPDATE [dbo].[Surats]
 //  SET [ReaderID] = @ReaderID
 //     ,[Path] = @Path
 //     ,[SuratIDName] = @SuratIDName
 //WHERE [Surats].ID = @ID";
 //           SqlCommand command = new SqlCommand(query, connection);
 //           command.Parameters.AddWithValue("@ReaderID", readerID);
 //           command.Parameters.AddWithValue("@Path", path);
 //           command.Parameters.AddWithValue("@SuratIDName", suratnameID);
 //           command.Parameters.AddWithValue("@ID", suratID);

 //           try
 //           {
 //               connection.Open();
 //               result = command.ExecuteNonQuery() > 0;

 //           }
 //           catch (Exception ex)
 //           {
 //               string Message = ex.Message;

 //           }
 //           finally { connection.Close(); }
 //           return result;
 //       }
       
 //       static public bool IsExist(int suratID)
 //       {
 //           bool result = false;
 //           SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionWay);
 //           string query = @"Select found = 1 from Surats Where ID = @ID";
 //           SqlCommand command = new SqlCommand(query, connection);
 //           command.Parameters.AddWithValue("@ID", suratID);
 //           try
 //           {
 //               connection.Open();
 //               object obj = command.ExecuteScalar();
 //               if (obj != null && bool.TryParse(obj.ToString(), out bool isactive))
 //                   result = isactive;
 //           }
 //           catch (Exception ex)
 //           {
 //               string msg = ex.Message;
 //           }
 //           finally { connection.Close(); }
 //           return result;
 //       }
    }
}
