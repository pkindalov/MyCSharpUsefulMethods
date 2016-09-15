using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpUsefulMethods
{
    class MyCSharpUsefulMethods
    {

        //write chars on console with parameter in string format
        static string printCharsString(string str, int count)
        {
            string result = null;

            for (int i = 0; i < count; i++)
            {
                result += str + " ";
            }

            return result;

        }





        static void Main(string[] args)
        {
            Console.WriteLine(printCharsString("Some text", 3));

            string someText = printCharsString("Some text2", 5);
            Console.WriteLine(someText);
        }
    }
}
