using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidationApp
{
    internal static class Validator
    {
        public static DataEnums Validate(string[] args, DataPattern[] patterns)
        {

            if (args.Length != 2)
                return DataEnums.InvalidInputPattern;

            foreach (var pattern in patterns)
            {
                if (args[0] == pattern.PatternName)
                {
                    if (Regex.IsMatch(args[1], pattern.Pattern))
                        return DataEnums.ValidData;
                }
            }

            return DataEnums.NotValidData;
        }
    }
}
