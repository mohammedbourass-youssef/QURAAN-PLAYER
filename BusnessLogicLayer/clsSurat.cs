using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessLogicLayer
{
    public class clsSurat
    {
        public int suratID { get; set; }
        public int readerID { get; set; }
        public string path { get; set; }
        public int suratnameID { get; set; }
        public clsReader reader { get; set; }
        public string Name { get; set; }
        enum enMode { AddNew , update}
        enMode _mode = enMode.AddNew;

        bool _AddNew()
        {
            suratID =  SuratDataAccess.AddNew(this.readerID, this.path, this.suratnameID);
            if (suratID > 0)
            {
                reader = clsReader.Find(readerID);
                return true;
            }
            return false;
        }
        bool _Update()
        {
            return false;
        }
        clsSurat(int suratID, int readerID, string path, int suratnameID)
        {
           this.suratID = suratID;
           this.readerID = readerID;
           this.path = path;
           this.suratnameID = suratnameID;
           Name = clsSuratsNamesDataAccess.GetNameByID(suratnameID);
           reader = clsReader.Find(readerID);
            _mode = enMode.update;
        }
        public clsSurat()
        {
            this.suratID = 0;
            this.readerID = 0;
            this.path = "";
            this.suratnameID = 0;
            _mode = enMode.AddNew;
        }
        public static DataTable GetSuratTop6()
        {
            return SuratDataAccess.GetTop6();
        }
        public static DataTable GetSuratTop5for(int readerID)
        {
            return SuratDataAccess.GetTop5SuratOf(readerID);
        }
        public static DataTable GetAllSuratSong(int SuratID)
        {
            return SuratDataAccess.GetAllSongOfSurat(SuratID);
        }
        public static bool IsExist(int suratID, int readerID)
        {
            return SuratDataAccess.IsExist(suratID, readerID);
        }
        public static clsSurat Find(int suratID)
        {
            
            int readerID = 0;
            string path = "";
            int suratnameID = 0;
            if (SuratDataAccess.Find(suratID, ref readerID, ref path, ref suratnameID))
            {
                return new clsSurat(suratID, readerID, path, suratnameID);
            }
            else
                return null;
        }

        public bool Save()
        {
            if (_mode == enMode.AddNew)
                return _AddNew();
            else
                return _Update();
        }
    }
}
