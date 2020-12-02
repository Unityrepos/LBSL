using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LBSLC
{
    class Program
    {
        static void Main(string[] args)
        {
            string code;
            Dictionary<string, int> functionsName = new Dictionary<string, int>();
            Dictionary<int, string> functions = new Dictionary<int, string>();
            int functionIterator = 0;
            using (FileStream file = new FileStream (args [0], FileMode.Open))
            {
                using (StreamReader fileR = new StreamReader (file))
                {
                    code = fileR.ReadToEnd();
                }
            }
            if (File.Exists (args[0].Substring(0, args[0].Length - 1)))
            {
                File.Delete(args[0].Substring(0, args[0].Length - 1));
            }
            using (FileStream file = new FileStream(args[0].Substring(0,args[0].Length-1), FileMode.OpenOrCreate))
            {
                using (StreamWriter fileW = new StreamWriter(file))
                {
                    fileW.Write(code);
                }
            }
        }
    }
}
