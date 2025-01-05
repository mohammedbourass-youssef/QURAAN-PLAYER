using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessLogicLayer
{
    public class SurahsNames
    {
        public static DataTable GetAllSurahsNames()
        {
            return clsSuratsNamesDataAccess.GetAllSorahsNAmes();
        }
        public static int GetSuratNameID(string name)
        {
            return clsSuratsNamesDataAccess.GetIDByName(name);
        }
    }
}
