# BuilderWithFacade

Why do we need the Builder with Facade?

Sometimes we may have a complex object, and the creational process requires more than one builder class. So, what we need to do is to introduce multiple builder classes in such a way, that we can jump from one builder to another while creating our object.

This approach helps us a lot in that process because we create a facade over our builders and it allows us to use all the builders to create a single object.