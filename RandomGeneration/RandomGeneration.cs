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
            charList.Add((char)57); // adds number 9
            //Number of characters 26 + 1 = 27

            string str = "";

            Random random = new Random();

            var xPosition = "";
            var previousPosition = "";
            for (int i = 0; i < seedLength; i++)
            {

                while (xPosition == previousPosition)
                {
                    Thread.Sleep(10);
                    xPosition = MainWindow.GetCursorPos();
                }
                previousPosition = xPosition;

                int rndNumber = random.Next(0, charList.Count()) + int.Parse(xPosition);
                int arrayNumber = rndNumber % 27;

                str += charList[arrayNumber];
            }

            return str;
        }
    }
}
