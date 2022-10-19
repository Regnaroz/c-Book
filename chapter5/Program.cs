using Chapter5.Shared;

var person = new Person("Khalid",DateTime.UtcNow);
var personData = person.GetData();
(person.Name,person.DateOfBirth) = personData;
var name1 = personData.Item1;
var dateOfBorth = personData.Item2;
Console.WriteLine(personData);