
WarO_CSharp
=========

a C# submission for War-O as a code exercise

* This is a work-in-progress ... NOT complete
* This project uses .NET Core 3.x
* It is probably not idiomatic as I'm still learning the .NET Core ecosystem, especially project structure and packaging.
* I have written a version in Java where everything is immutable, and some of that spirit continues in this version (though it is not especially elegant).

To Run/Test:
---------

* `./run.sh`
* `./test.sh`
* `./coverage_test.sh`

Origin:
---------

* `dotnet new console`
* `dotnet new sln`
* article [here](https://insimpleterms.blog/adding-nunit-tests-to-a-net-core-console-app)
    - `dotnet sln add src/WarO-CSharp-v2.csproj`
    - `dotnet run -p src/WarO-CSharp-v2.csproj`
    - tests
        - `cd tests`
        - `dotnet new nunit`
        - `dotnet add reference ../src/WarO-CSharp-v2.csproj`
        - `cd ..`
        - `dotnet sln add ./tests/tests.csproj`

Rules:
---------

Rules are [here](Rules.md).

TODO:
---------

* examine collection interfaces 
    - https://stackoverflow.com/questions/3628425/ienumerable-vs-list-what-to-use-how-do-they-work
* consider properties 
* async, like Java
* consider LINQ review
* fix bug about # of games
* consider immutability
* validator during game, capture discards 
* format code appropriately
* move code into folders, possibly namespaces
* write a remote API server 
