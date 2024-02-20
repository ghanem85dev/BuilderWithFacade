using BuilderWithFacade.Domains;
using BuilderWithFacade.Facades;

namespace BuilderWithFacade.Builders
{
    public class PersonAdressBuilder : PersonBuilderFacade
    {

        public PersonAdressBuilder(Person person)
        {
            Person = person;
        }

        public PersonAdressBuilder InCity(string city)
        {
            Person.City = city;
            return this;
        }

        public PersonAdressBuilder AtAddress(string address)
        {
            Person.Address = address;
            return this;
        }
    }
}
