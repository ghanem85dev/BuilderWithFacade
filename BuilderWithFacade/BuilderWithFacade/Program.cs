using BuilderWithFacade.Facades;

var person = new PersonBuilderFacade()
    .Info.WithFirstName("Toto")
        .WithLastName("Titi")
    .Profession.HisProfession("SmartDeveloper")
    .Built.InCity("Paris")
        .AtAddress("La Defense")
        .Build();

Console.WriteLine(person);
