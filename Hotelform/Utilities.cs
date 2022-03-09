using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hotelform
{
   public static class Utilities
    {
        public static bool IsEmpty(string[] arr)
        {
            foreach (var item in arr)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    return false;
                }
            }
            return true;

        }
        public static string Hassme(this string pas)
        {
            byte[] stringByte = new UTF8Encoding().GetBytes(pas);
            var hashedPas = new SHA256Managed().ComputeHash(stringByte);
            string password = new UTF8Encoding().GetString(hashedPas);
            return password;

        }
    }
}
