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


        //same method like this on top but this time no return value. Cw - mean in method is used console.writeline
        static void printCharsStringCw(string str, int count)
        {
            string result = null;

            for (int i = 0; i < count; i++)
            {
                result += str + " ";
            }

            Console.WriteLine(result);

        }




        //write chars on console with parameter in char format. Method return string in result
        static string printChars(char str, int count)
        {
            string result = null;

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;

        }


       






        static void Main(string[] args)
        {
            Console.WriteLine(printCharsString("Some text", 3));

            string someText = printCharsString("Some text2", 5);
            Console.WriteLine(someText);


            printCharsStringCw("Same function but no return value", 2);


            Console.WriteLine(printChars('*', 4));
            string wayForUse2 = printChars('s', 5);
            Console.WriteLine(wayForUse2);



           
        }
    }
}
