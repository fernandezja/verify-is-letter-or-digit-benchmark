using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VerifyIsLetter.ConsoleApp
{
    public class Verify
    {

        public bool WithRegEx(string stringToVerify) {
            return Regex.IsMatch(stringToVerify, @"^[a-zA-Z]+$");
        }

        public bool WithCharIsLetter(string stringToVerify)
        {
            return stringToVerify.All(char.IsLetter);
        }

        public bool WithForCompareAsciiValue(string stringToVerify)
        {
            for (int i = 0; i < stringToVerify.Length; i++)
            {
                //A=65 Z=90 and a=97 z=122
                if ((int)stringToVerify[i] < 65 || ((int)stringToVerify[i] > 90 
                    && (int)stringToVerify[i] < 97) || (int)stringToVerify[i] > 122)
                    return false;
            }
            return true;
        }

    }
}
