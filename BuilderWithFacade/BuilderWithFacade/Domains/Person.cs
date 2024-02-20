namespace BuilderWithFacade.Domains
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, is a {Profession} living in {City} at {Address}";
        }
    }
}
