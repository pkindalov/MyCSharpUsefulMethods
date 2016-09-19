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


        //write chars on console with parameter in char format with new line. WL - writeLine
        static string printCharsWL(char str, int count)
        {
            string result = null;

            for (int i = 0; i < count; i++)
            {
                result += str + "\n";
            }

            return result;

        }




        //method for colorign given text. Parameters are some string and colour name , and if colour name exists, the string is colored with it.
        static void coloringText(string text, string colourName)
        {


            Dictionary<string, ConsoleColor> colours = new Dictionary<string, ConsoleColor>();
            colours.Add("Red", ConsoleColor.Red);
            colours.Add("Blue", ConsoleColor.Blue);
            colours.Add("Green", ConsoleColor.Green);
            colours.Add("Cyan", ConsoleColor.Cyan);

            bool isColorFound = false;

            foreach (KeyValuePair<string, ConsoleColor> colors in colours)
            {
                if (colors.Key == colourName)
                {
                    isColorFound = true;
                    Console.ForegroundColor = colors.Value;
                    Console.WriteLine(text);
                    Console.ResetColor();
                }

            }

            if (!isColorFound)
            {
                Console.WriteLine(text);
            }


        }




        //method which accept for parameter color name and if this color exists in dictionary, change console font color on letters
        static void consoleColor(string color)
        {
            Dictionary<string, ConsoleColor> colours = new Dictionary<string, ConsoleColor>();
            colours.Add("Red", ConsoleColor.Red);
            colours.Add("Blue", ConsoleColor.Blue);
            colours.Add("Green", ConsoleColor.Green);
            colours.Add("Cyan", ConsoleColor.Cyan);

            bool isColorFound = false;

            foreach (KeyValuePair<string, ConsoleColor> colors in colours)
            {
                if (colors.Key == color)
                {
                    isColorFound = true;
                    Console.ForegroundColor = colors.Value;
                }


            }


        }



        //method which just reset original font color of letters
        static void resetColor()
        {
            Console.ResetColor();
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


            Console.WriteLine(printCharsWL('@', 5));


            coloringText("Some example in blue", "Blue");

            string text = "I am in red color";
            coloringText(text, "Red");

            string noSuchColor = "Sorry , no such color";
            string colorName = "Pink";

            coloringText(noSuchColor, colorName);


            consoleColor("Red");
            Console.WriteLine("Text in red color");

            Console.WriteLine();

            resetColor();
            Console.WriteLine("Text in default color");





        }
    }
}
