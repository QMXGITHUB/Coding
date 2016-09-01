using System;

namespace CodeSmell_StaticMethod
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Person CreateNew()
        {
            var person = new Person();
            person.Id = 1;
            person.FirstName = "Meixia";
            person.LastName = "Qiao";
            return person;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", FirstName, LastName);
        }
    }

    public class Employee : Person
    {
        public string Boss { get; set; }
        public string Departure { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} --- {2}", FirstName, LastName, Departure);
        }

        public override Person CreateNew()
        {
            return new Employee();
        }
    }
}