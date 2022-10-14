using System.Reflection.PortableExecutable;
using System;
using static System.Console;
using static System.Convert;
//Chapter 3 
#region Null in Class
//var address = new Address();
//address.Building = null;
//address.Street = 5;
//address.City = string.Empty;
//address.Region = string.Empty;
//Write(address.Building ?? 0);// Condition(true) ?? false
//class Address
//{
//    public int? Building { get; set; }
//    public int Street { get; set; }
//    public string City { get; set; }
//    public string Region{ get; set; }
//}
#endregion


#region Formatting in WriteLine
string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine(
 format: "{0,-20} {1,6:N0}",
 arg0: applesText,
 arg1: applesCount);
//Cannont Have more than 3 args);
#endregion

#region Simplify Switch 


var streamObject = 11;
string message = string.Empty;

 message = streamObject switch
{
   5
    => "The stream is a file that I can write to.",
 4
    => "The stream is a read-only file.",
 3
    => "The stream is a memory address.",
 0
    => "The stream is null.",
 _
    => "The stream is some other type."
};
Write(message);
#endregion

#region Foreach()
string[] nameList = { "Adam", "Barry", "Charlie" };
foreach (var nameIndex in nameList)
{
    WriteLine($"{nameIndex} has {nameIndex.Length} characters.");
}
#endregion

#region Casting & Converting

// Implicit Casting , happens Automatically (compiler)
double value = 5; // doulbe = int ; 
//explicit Casting , manually user have to put it 
int intValue = (int)6.5; // int value = 6 , explicit Casting will NOT Round the value

//Convert by adding ( using static System.Convert; ) 

int number = ToInt32(5.30); // = 5 , convert will round the value

WriteLine("Enter Date Value : ");
//   var dateInput = ReadLine();
//    DateTime dateValue;
//    var ww = DateTime.TryParse(dateInput, out dateValue);

//var convertMessage = ww ? "Can convert " : "Cant Convert ";
//Write(convertMessage);
//var t = 5;

#endregion

#region Divide by / 0 
Write("enter Number to divide 100 to");

//var userInput = ReadLine();
//int divideOn;
//int.TryParse(userInput, out divideOn);
//double result;
//try
//{
//     result = (100 / divideOn);
//    Write($"result of divide is : {result}");
//}
//catch(InvalidCastException exc)
//{
//    Write(exc.Message);
//}
//catch(DivideByZeroException exc)
//{
//    result = 0;
//}
//catch (FormatException exc)
//{
//    Write(exc.Message);
//}
//catch (Exception exc)
//{
//    Write(exc.Message);
//}


unchecked
{
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
}





#endregion

#region FizzBuzz
int max = 100;
string resultMessage;
//for (int i = 1; i < max; i++)
//{
//    resultMessage = String.Empty;
//    if (i % 3 == 0)
//    {
//        resultMessage += "Fizz";
//    }
//    if (i % 5 == 0)
//    {
//        resultMessage += "Buzz";
//    }

//    resultMessage = !String.IsNullOrEmpty(resultMessage) ? resultMessage : i.ToString();
//    if ((i + 1) % 11 == 0)
//    {
//        WriteLine($" {resultMessage} ,");
//    }
//    else
//        Write($" {resultMessage} ,");
//}
#endregion

var userInput1 = ReadLine();

try
{
    int value1 = Convert.ToInt32(userInput1);
    if (value1 >= 0 && value1 <= 255)
    {
        var userInput2 = ReadLine();
        int value2 = Convert.ToInt32(userInput2);
        if (value2 >= 0 && value2 <= 255)
        {
            WriteLine($"result = {value1 / value2}");
        }
        else
            WriteLine($"{nameof(value2)} is Out of range 0 - 255");
    }
    else
        WriteLine($"{nameof(value1)} is Out of range 0 - 255");

}
catch (FormatException exc)
{
    WriteLine(exc.Message);
}
catch (DivideByZeroException exc)
{
    WriteLine(exc.Message);
}
