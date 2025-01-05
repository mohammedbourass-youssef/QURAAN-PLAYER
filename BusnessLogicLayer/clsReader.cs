using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessLogicLayer
{
    public class clsReader
    {
        public int readerID {  get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string SecondName { get; set; }

        public string picturepath { get; set; }
        enum enMode { enAdd, enUpdate }
        enMode _mode = enMode.enAdd;

        bool _AddNew()
        {
            readerID = clsReaderdataaccess.AddNew(readerID,FirstName,LastName,SecondName,picturepath);
            return readerID > 0;
        }
        clsReader(int ID,string firstname,string lastname,string secondname,string profile)
        {
            readerID = ID;
            FirstName = firstname;
            LastName = lastname;
            SecondName = secondname;
            picturepath = profile;
            _mode = enMode.enUpdate;
        }
        public clsReader()
        {
            readerID = 0;
            FirstName = "";
            LastName = "";
            SecondName = "";
            picturepath = "";
            _mode = enMode.enAdd;
        }
        public string GetFullName()
        {
            if(SecondName == "" || SecondName == " ")
            {
                return FirstName +" "+LastName;
            }
            else
            {
                return FirstName + " " +SecondName +" "+LastName;
            }
        }

        public static DataTable GetAllReaders()
        {
          return  clsReaderdataaccess.GetAllReaders();
        }
        public static DataTable GetTopSexReaders()
        {
            return clsReaderdataaccess.GetTop6Readers();
        }
        public static int NumberOfSurat(int ReaderID)
        {
           return clsReaderdataaccess.CountNumberOfExistedSurat(ReaderID);
        }
        public bool Save()
        {
            if(_mode == enMode.enAdd)
            {
                return _AddNew();
            }
            else
            {
                return false;
            }
        }
        public static clsReader Find(int readerID)
        {
            string firstname = "";
            string lastname = ""; 
            string secondname = "";
            string profile = "";
            if(clsReaderdataaccess.Find(readerID,ref firstname,ref lastname,ref secondname,ref profile))
            {
                return new clsReader(readerID,firstname,lastname,secondname,profile);
            }
            else 
                return null;
        }
        public static int FindID(string FullNAme)
        {
            int readerID = 0;
            string profile = "";
            if (clsReaderdataaccess.Find(FullNAme, ref readerID,ref profile))
            {
                return readerID;
            }
            else
                return -1;
        }

    }
}
