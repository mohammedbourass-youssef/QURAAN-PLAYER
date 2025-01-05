using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusnessLogicLayer
{
    public class clsFavorite
    {
        public static bool Add(int SuratID)
        {
            return (!clsFavoriteDataAccess.Exist(SuratID)) ? clsFavoriteDataAccess.Add(SuratID) > 0 : false;
        }
        public static bool Remove(int SuratID)
        {
            return clsFavoriteDataAccess.Delete(SuratID);
        }
        public static DataTable GetAllRecord()
        {
            return clsFavoriteDataAccess.GetData();
        }
        public static bool IsExist(int SuratID)
        {
            return clsFavoriteDataAccess.Exist(SuratID);
        }
       
    }
}
