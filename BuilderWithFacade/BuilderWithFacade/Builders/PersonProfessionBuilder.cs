using BuilderWithFacade.Domains;
using BuilderWithFacade.Facades;

namespace BuilderWithFacade.Builders
{
    public class PersonProfessionBuilder : PersonBuilderFacade
    {

        public PersonProfessionBuilder(Person person)
        {
            Person = person;
        }

        public PersonProfessionBuilder HisProfession(string profession)
        {
            Person.Profession = profession;
            return this;
        }
    }
}
