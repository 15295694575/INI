using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\yinyj\Desktop\1.ini";
            string value = INI.GetIniValue(filePath, "Main", "Author");
            Console.WriteLine(value);
            INI.WriteIniValue(filePath, "Main", "CreateDatetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.ReadKey();
        }
    }
}
