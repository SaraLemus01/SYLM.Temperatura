using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYLMTemperatura.UnitTestMSTes
{
    public class StringManipulator
    {

        public string ReverseString(string input)
        {
            if (input == null) return null;
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        public string RemoveSpaces(string input) 
        {
            return input.Replace(" "," ");
        }
    }
}
