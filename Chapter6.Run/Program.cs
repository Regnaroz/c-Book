
using Chapter6.Data.ClassData;
using Chapter6.Data.Interface;


//var father = new Person() { Name = "ALi" };

//var mother = new Person() { Name = "Alia" };
//father.AddChildren(mother, "Yazan");

//var personTest = new Person();
//Person.AddChildren(father, mother, "Ahmad");
//Person.AddChildren(father, mother, "Sarah");
//Person.AddChildren(father, mother, "Abood");

//var child = father * mother;
//var ChildEqual = father == mother;
//var ChildEqual2 = father == personTest;

//var childResult = father.GetChildByName("Abood");
//string msg = (childResult != null ) ? $"Yes has Child named :{childResult.Name}" : "No child found ";
//Console.WriteLine(msg);

//Person[] people =
//{
// new Person { Name = "Simon" , DateOfBirth = new DateTime(2022,05,1) },
// new Person { Name = "Jenny" , DateOfBirth = new DateTime(2022,04,1) },
// new Person { Name = "Adam" , DateOfBirth = new DateTime(2022,05,30)},
// new Person { Name = "Richard", DateOfBirth = new DateTime(2022,04,30) }
//};
//int[] peopleInt =
//{
//-5,10,0,9,4
//};

//Array.Sort(people, new PersonComparer());

//Console.WriteLine();

IPlayable video = new VideoPlayer();
IPlayable audio = new AudioPLayer();

video.PLay();
audio.PLay();
video.Pause();
audio.Pause();
