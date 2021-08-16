using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IniOperation
{
    public class INI
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key,string def,StringBuilder retval,int size, string filePath);

        public static string GetIniValue(string filePath,string section,string key,int size=1024)
        {
            StringBuilder sb = new StringBuilder();
            GetPrivateProfileString(section, key, "", sb, size, filePath);
            return sb.ToString();
        }

        public static void WriteIniValue(string filePath,string section,string key, string value)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }
    }
}
