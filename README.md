 

		#MyCSharpUsefulMethods#
		####Different methods in C# ####
		
		First method is called printCharsString(string str, int count) because first parameter is string and it is my
		little replacement of new string(simbol, count). This method return a value. Examples:
		
		first way:
		Console.WriteLine(printCharsString("Some text", 3));
		
		Result: Some text Some text Some text
		
		
		second way fo use:
		
		string someText = printCharsString("Some text2", 5);
        Console.WriteLine(someText);
		
		Result: Some tex2 Some text2 Some tex2 Some text2 Some tex2
		
		
		
		Second method is like this on top but this time no return value
	
		Example:
		
		printCharsStringCw("Same function but no return value", 2);
		
		Result:
		
		Same function but no return value Same function but no return value
		
		==================================================================================================================================================================

		Next method printChars write chars on console with parameter in char format. Method return string in result
		string printChars(char str, int count)
		
		Example:
		
		Console.WriteLine(printChars('*', 4));
		
		Result:
		
		****
		
		
		Second way of use example:
		string wayForUse2 = printChars('s', 5);
        Console.WriteLine(wayForUse2);
		
		Result:
		sssss
		
		
		Next method is printCharsWL(char str, int count). It is very similar to printChars. Only difference is print every symbol on new line.
		
		Example:
		
		Console.WriteLine(printCharsWL('@', 5));
		
		Result:
		
		@
		@
		@
		@
		@
		
		==================================================================================================================================================================
		
		Next method method is for coloring given text - void coloringText(string text, string colourName).
		Parameters are some string and colour name(It is IMPORTANT name of color to begin with Uppecase letter) , and if colour name exists, the string is colored with it.
		
		
		Example of use:
		
		coloringText("Some example in blue", "Blue");
		
			or
			
		string text = "I am in red color";
        coloringText(text, "Red");	
		
		Result: if red colour is added to dictionairy then the text string will be in red color. If the color is not added to dictionairy then the string variable
		will be in default console color.
	
	
		Second example show if the color which you want to color text don`t exists , then the string variable will be in default console color
		
		Example 2:
		
		 string noSuchColor = "Sorry , no such color";
         string colorName = "Pink";
		 
		 Result: On console will be write noSuchColor variable in default console color.



		Added method which accept for parameter color name and if this color exists in dictionary, change console font color on letters
		
		Example:
		
		consoleColor("Red");
        Console.WriteLine("Text in red color");
		
		Result: 
		Every text under consoleColor() will be colourful.
		