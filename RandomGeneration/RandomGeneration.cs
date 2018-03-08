using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomGeneration
{
    public class RndClassGen
    {
        public static string RndGen(int seedLength)
        {
            //IOTA
            //ASCII capital letters 65-90 and number "9" is 57
            List<char> charList = new List<char>();
            for (int i = 65; i < 91; i++)
            {
                charList.Add((char)i);
            }
            charList.Add((char)57);
            //Number of characters 26 + 1 = 27

            string str = "";
            Random random = new Random();

            for (int i = 0; i < seedLength; i++)
            {
                str += charList[random.Next(0, charList.Count())];
            }
            Thread.Sleep(1);

            return str;
        }
    }
}
