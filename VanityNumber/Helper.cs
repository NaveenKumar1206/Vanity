using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanityNumber.Controllers
{
    public static class Helper
    {
        public static string MapAlphabet(string v1)
        {
            switch (v1)
            {
                case "0": return "0";
                case "1": return "1";
                case "2": return "abc";
                case "3": return "def";
                case "4": return "ghi";
                case "5": return "jkl";
                case "6": return "mno";
                case "7": return "pqrs";
                case "8": return "tuv";
                case "9": return "wxyz";
                default:
                    return v1;
            }
        }



        public static string MapFirstAlphabet(string v1)
        {
            switch (v1)
            {
                case "0": return "0";
                case "1": return "1";
                case "2": return "a";
                case "3": return "d";
                case "4": return "g";
                case "5": return "j";
                case "6": return "m";
                case "7": return "p";
                case "8": return "t";
                case "9": return "w";
                default:
                    return v1;
            }
        }


    }
}
