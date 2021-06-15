namespace CSharp9
{
    public record PersonRec(string FirstName, string LastName);
    //public record PersonRec(string FirstName, string LastName)
    //{
    //    public string FirstName { get; init; } = FirstName;
    //    public string LastName { get; init; } = LastName;

    //    public string HelloWorld()
    //    {
    //        return "Hello world!";
    //    }
    //}

    public record Developer(string FirstName, string LastName, string FavoriteLanguage) : PersonRec(FirstName, LastName);



    public class PersonClass
    {
        public PersonClass(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Summary { get; set; }

    }
}
