using System.Data.Common;

namespace Chapter6.Data.ClassData
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Person> Children = new List<Person>();

        public void WriteToConsole()
        {
            Console.WriteLine($"Name : {Name}\nDOB : {DateOfBirth}");
        }

        public static Person AddChildren(Person father, Person mother, string childName)
        {
            var child = new Person() { Name = childName };
            father.Children.Add(child);
            mother.Children.Add(child);
            return child;
        }

        public Person AddChildren(Person anotherPerson, string childName)
        {
            return AddChildren(this, anotherPerson, childName);
        }


        public static Person operator *(Person p1, Person p2)
        {
            var child = new Person() { Name = "New Child" };
            p1.Children.Add(child);
            p2.Children.Add(child);
            return child;
        }

        public static bool operator == (Person p1, Person p2){

            return p1.Children.Count == p2.Children.Count;
        }

        public static bool operator !=(Person p1, Person p2)
        {

            return p1.Children.Count == p2.Children.Count;
        }



        public Person GetChildByName(string childName) 
        {
            return GetChildByNameFromDataBase(childName);
        }

 
        private Person GetChildByNameFromDataBase(string childName)
        {
            Person result = null;
            foreach (var child in this.Children)
            {
                if (child.Name.ToLower().Equals(childName.ToLower()))
                {
                    result = child;
                }
            }

            return result ?? null;
        }

        public int MethodIWantToCall(string input)
        {
            return input.Length; // it doesn't matter what this does
        }

       

        public int CompareTo(object? obj)
        {
            if(obj is Person)
            {
                return DateOfBirth.CompareTo(((Person)obj).DateOfBirth);
            }
            else
            {
                throw new InvalidCastException($"{nameof(obj)} isnt Person Type !");
            }
        }
        public int CompareTo(Person obj)
        {
            return Name.CompareTo(obj.Name); 
        }
    }
}
