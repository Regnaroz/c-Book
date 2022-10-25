using static System.Console;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net;
using System;
using System.Reflection;
using chapter8.Run;
using System.Globalization;

[Coder("Mark Price", "22 August 2019")]
[Coder("Johnni Rasmussen", "13 September 2019")]
static void DoStuff()
{
}
#region Working with Strings 
//string myList = "A,D,E,D,E";
//string word = "Hello World ! ";
//var elemnts = myList.Split(',');
//var elementsType = nameof(elemnts);
//foreach (var elem in elemnts)
//{
//    Console.Write($"[ {elem} ]  ");
//    Console.WriteLine(elementsType);
//}
//Console.WriteLine($"indexo of D : {elemnts.ToList().IndexOf("D")}");
//Console.WriteLine($"indexo of D : {elemnts.ToList().IndexOf("D",2)}");

////go to index 3 in word , then count 4 (including the 3rd index we on ) => lo W
//Console.WriteLine($"{word.Substring(3,4)}");

//string fullName = "Khalid Aqrabawi";
//Console.WriteLine($"Index of Space is : {fullName.IndexOf(' ')}");
//var wordsList = fullName.Split(' ');
//Console.WriteLine($"first Name : {wordsList[0]} , Last Name : {wordsList[1]}");
//Console.WriteLine($"do Name contains 'Z' ? {fullName.Contains('Z')}");
//Console.WriteLine($"do Name Starts With 'K' ? {fullName.StartsWith('K')}");

//string wordWithSpaces = " AD  R T E T/  ";//removes spaces from the start[0] and end[n-1]
//Console.WriteLine($"{wordWithSpaces} After Using Trim :{wordWithSpaces.Trim()}");

//Console.WriteLine($"{fullName} insert : {fullName.Insert(7,"Ibrhaim ")}");

//Console.WriteLine($"list join : {string.Join(" Question  ", elemnts)}");


#endregion


#region Regex


//Write("Enter your age: ");

////var ageChecker = new Regex(@"\d"); // will check if input has digit (number) if there is one digit it will return true igonring what comes befoer/after 

//var flag = false;
//do
//{
//    // check if input is only 2 char and the char ar from 0 - 5
//    var SpeceficNumberBetween = new Regex(@"^[0-5]{2}$");
//    // check if input is only 2 char and the char ar from 0 - 5
//    //four uppercase English letters only
//    var SpeceficNumberBetween1 = new Regex(@"^[A-Z]{4,}$");
//    //
//    var SpeceficNumberBetween2 = new Regex(@"^[A-Z]{2}\d{3}$");
//    // 3char, Must start with d , " . " can be any char, must end with g
//    var SpeceficNumberBetween3 = new Regex(@"^d.g$");
//    string input = ReadLine();
//    if (SpeceficNumberBetween3.IsMatch(input))
//    {
//        Console.WriteLine("Success Input 🤩");
//    }
//    else
//    {
//        Console.WriteLine("Invalid Input 🤡" );
//    }
//}
//while (!flag);
#endregion

#region Dictionaries
//var myDictionary = new Dictionary<int, string>();
//myDictionary.Add(1, "32-bit integer data type");
//myDictionary.Add(5, "64-bit integer data type");
//myDictionary.Add(9, "Single precision floating point number");
//WriteLine("Keywords and their definitions");
//foreach (KeyValuePair<int, string> item in myDictionary)
//{
//    WriteLine($" {item.Key}: {item.Value}");
//}

//WriteLine($"The definition of long is {myDictionary[9]}");
#endregion

#region Reflection

//WriteLine("Assembly metadata:");
//var assembly = Assembly.GetEntryAssembly();
//Console.WriteLine(assembly.FullName);
//var attributes = assembly.GetCustomAttributes();
//WriteLine($" Attributes:");
//foreach (Attribute a in attributes)
//{
//    WriteLine($" {a.GetType()}");
//}
//var version = assembly.GetCustomAttribute
// <AssemblyInformationalVersionAttribute>();
//WriteLine($" Version: {version.InformationalVersion}");
//var company = assembly.GetCustomAttribute
// <AssemblyCompanyAttribute>();
//WriteLine($" Company: {company.Company}");



//Type[] types = assembly.GetTypes();
//foreach (var type in types)
//{
//    WriteLine();
//    WriteLine($"Type: {type.FullName}");
//    MemberInfo[] members = type.GetMembers();
//    foreach (MemberInfo member in members)
//    {
//        WriteLine("{0}: {1} ({2})",
//        arg0: member.MemberType,
//        arg1: member.Name,
//        arg2: member.DeclaringType.Name);
//        var coders = member.GetCustomAttributes<CoderAttribute>()
//        .OrderByDescending(c => c.LastModified);
//        foreach (CoderAttribute coder in coders)
//        {
//            WriteLine("-> Modified by {0} on {1}",
//            coder.Coder, coder.LastModified.ToShortDateString());
//        }
//    }
//}
#endregion

#region localization / globalization
CultureInfo globalization = CultureInfo.CurrentCulture;
CultureInfo localization = CultureInfo.CurrentUICulture;
WriteLine("The current globalization culture is {0}: {1:C}",
 globalization.Name, 3000);
Console.WriteLine(DateTime.Now);
CultureInfo.CurrentCulture = new CultureInfo("fr-CA");
CultureInfo.CurrentUICulture = new CultureInfo("fr-CA");
Console.WriteLine(DateTime.Now);

WriteLine("The current globalization culture is {0}: {1:C}",
 globalization.Name, 3000);
WriteLine("The current localization culture is {0}: {1}",
 localization.Name, localization.DisplayName);
WriteLine();
#endregion