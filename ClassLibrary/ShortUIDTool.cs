using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericGameFramework.ClassLibrary
{
    public class ShortUIDTool
    {
        private static Random _random = new Random();
        private static char[] _characters = new char[] {'2', '3', '4', '5', '6', '7', '8', '9',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        public static string CreateNewShortId(int characters = 6)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < characters; i++)
            {
                builder.Append(_characters[_random.Next(_characters.Length)]);
                if(builder.Length % 3 == 0 && characters-1 != i) { builder.Append('-'); }
            }
            return builder.ToString();
        }

    }
}