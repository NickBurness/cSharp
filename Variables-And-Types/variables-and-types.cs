using System;
// When defining a variable in C# the variables 'data type' must be defined prior to their use. 
public class VariablesAndTypes
{
   public static void Main()
   {
      // each of these declarations from here up until the comment (// test code) is an example of a variable.
    int aInt = 1;
    float aFloat = 1f; // when defining a float you must define it with an explicit letter 'f' after the number.
    bool aBool = true; // a boolean can be either 'true or false'.
    double aDouble = 1.00; // unlike an int, a double allows for decimal places.
    string aString = "This is a string"; // notice that a string is held within abbreviation marks like the hello world example 
    char aChar = 'Z'; // like a string but only one character. 
    
    /* 
    
    C# supports type inteference. this means you don't always have to explicitly specified. you can let the compiler which interpets your code try and understand the type of variable
    that has been declared automatically. However, once the type of variable has been determined, it cannot be assigned a different type. 

    */

    var aVar = 500; // would be defined as an int. 
    var bVar = 100; // would be defined as an int
    var cVar = aVar + bVar; // the sum will be defined as an int
    var anotherVar = false; // would be defined as a bool.
    var yetAnotherVar = "so many variables"; // would be defined as a string.

      // test code 
      Console.WriteLine(typeof(aVar));
      Console.WriteLine(typeof(anotherVar));
      Console.WriteLine(typeof(yetAnotherVar));
   }
}