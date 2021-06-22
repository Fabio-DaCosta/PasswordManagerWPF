using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerLibrary
{
    public static class Access
    {
        private static string _masterkey = "testMasterkey";

        public static bool Login(string masterkey)
        {
            return _masterkey == masterkey;
        }

        public static bool IsMasterkeySet()
        {
            return _masterkey != null;
        }

        public static void SetMasterkey(string masterkey)
        {
            if (IsValid(masterkey))  _masterkey = masterkey;
        }

        private static bool IsValid(string masterkey)
        {
            return true;
        }
    }
}
