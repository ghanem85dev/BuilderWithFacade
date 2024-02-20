using BuilderWithFacade.Domains;
using BuilderWithFacade.Facades;

namespace BuilderWithFacade.Builders
{
    public class PersonInfoBuilder : PersonBuilderFacade
    {
        public PersonInfoBuilder(Person person)
        {
            Person = person;
        }

        public PersonInfoBuilder WithFirstName(string firstName)
        {
            Person.FirstName = firstName;
            return this;
        }

        public PersonInfoBuilder WithLastName(string lastName)
        {
            Person.LastName = lastName;
            return this;
        }
    }
}
