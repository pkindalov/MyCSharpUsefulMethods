 

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
		