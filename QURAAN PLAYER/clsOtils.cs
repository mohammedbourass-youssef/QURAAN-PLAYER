using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QURAAN_PLAYER
{
    public class clsOtils
    {
       public static bool IsArabicOnly(char text)
        {
            // Arabic Unicode range: \u0600-\u06FF and \u0750-\u077F for extended Arabic
            string pattern = @"^[\u0600-\u06FF\u0750-\u077F]$";
            return Regex.IsMatch(text.ToString(), pattern);
        }
    }
}
