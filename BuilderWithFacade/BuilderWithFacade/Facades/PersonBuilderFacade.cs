using BuilderWithFacade.Builders;
using BuilderWithFacade.Domains;

namespace BuilderWithFacade.Facades
{
    public class PersonBuilderFacade
    {
        protected Person Person { get; set; }

        public PersonBuilderFacade()
        {
            Person = new Person();
        }

        public Person Build() => Person;

        public PersonInfoBuilder Info => new PersonInfoBuilder(Person);
        public PersonProfessionBuilder Profession => new PersonProfessionBuilder(Person);
        public PersonAdressBuilder Built => new PersonAdressBuilder(Person);

    }
}
