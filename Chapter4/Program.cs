

using Microsoft.Extensions.Configuration;
using System.Diagnostics.SymbolStore;
using System.Text.RegularExpressions;
using static System.Console;

#region Method to Check 


//GetuserInput();


//void GetuserInput()
//{
//    int number;
//    bool isTrue;
//    do
//    {
//        var userInput = ReadLine();
//        isTrue = int.TryParse(userInput, out number);

//        if (isTrue)
//        {
//               WriteLine($"Result  = {CalcualteMath(number)}");
//        }
//        else
//            WriteLine("Please Enter a Valid Number Value");
//    }
//    while (isTrue is false); // isTrue == false , ! isTrue
//}

//int CalcualteMath(int number)
//{
//    return number * 10;
//}

#endregion


#region Calctax()

//GetUserInput();

//void GetUserInput()
//{
//    double total;
//    char code;
//    bool isInputTrue;
//    do
//    {
//        var totalInput = ReadLine();
//        var codeInput = ReadLine();
//        isInputTrue = double.TryParse(totalInput, out total);
//        if (!isInputTrue)
//        {
//            WriteLine("Total is invalid !");
//            continue;
//        }
//        isInputTrue = char.TryParse(codeInput, out code);

//        if (isInputTrue)
//        {
//            bool isAlphaBet = Regex.IsMatch(code.ToString(), "[a-z]", RegexOptions.IgnoreCase);
//            if (isAlphaBet)
//            {
//                CalculateTax(total, code);
//            }
//            else
//            {
//                isInputTrue = false;
//                WriteLine("Code isn't an Alphaptic ! ");
//            }
//        }
//        else
//        {
//            WriteLine("Code is invalid ! ");
//        }

//    }
//    while (!isInputTrue);
//}

//void CalculateTax(double total, char code)
//{
//    var stm = code.ToString();
//    switch (stm) // "a".toUpper() => "A" , "A".toLower() => "a"
//    {
//        case "J":
//            {
//                WriteLine($"Total Minus Tax tax = {total - (total * 0.15)}");
//                break;
//            }
//        case "U":// "U" != "u"
//            {
//                WriteLine($"Total * tax = {total - (total * 0.20)}");
//                break;
//            }
//        default:
//            WriteLine($"Total * tax = {total * 0.30}");
//            break;
//    }
//}

#endregion

#region Factorial 

//WriteLine("Enter Fact Value : ");
//int value;
//var valueInput = ReadLine();
//var isInputValid = int.TryParse(valueInput, out value);

//if (isInputValid && value >= 0)
//{
//    int result = CalculateFactorial(value);

//    WriteLine($"Fact value of {value}  = {result}");
//}

//else
//{
//    Write("Invalid Value or value under 0 ");
//}

//int CalculateFactorial(int value) // 5 = 5 * (5-1) *(5-2)... *(5 - 0)
//{
//    //Recursion Function need to have at least 1 base case ; 
//   if (value == 0)
//    {
//        return 1;
//    }

//    else
//    {
//        return value * CalculateFactorial(value - 1);
//    }




//}


#endregion

#region ReadingFromJson

//string message = "Welcome to Our system ! ";
//bool result = Prepare(message);

//bool Prepare(string message)
//{
//    var config = new ConfigurationBuilder()
//                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//                   .AddJsonFile("appsettings.json").Build();

//    var Email = config.GetSection("Email").Value;
//    var isSent = SendEmail(Email, message);

//    return isSent;
//}

//bool SendEmail(string email, string message)
//{
//    if(email == "System@Admin.com")
//    {
//        return true;
//    }
//    return false;
//}

#endregion

