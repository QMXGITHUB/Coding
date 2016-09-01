namespace CodeSmell_StaticMethod
{
    public class PersonApp
    {
        public void DoSomething()
        {
            var person = Person.CreateNew();
            person.FirstName = "NewName";
            person.LastName = "NewFamilyName";
            System.Console.WriteLine(person.ToString());

            var gaoqiang = Person.CreateNew();
            gaoqiang.SetAge(1);
        }
    }
}   