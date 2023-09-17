using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationApp
{
    internal static class Logger
    {
        public static void Log(DataEnums status)
        {
            switch (status)
            {
                case DataEnums.NotValidData:
                    Console.WriteLine("False");
                    break;
                case DataEnums.ValidData: 
                    Console.WriteLine("True");
                    break;
                case DataEnums.InvalidInputPattern:
                    Console.WriteLine("Error. Inpud data should follow next pattern: data_type data");
                    break;
            }
        }
    }
}
