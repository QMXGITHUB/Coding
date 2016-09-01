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
}