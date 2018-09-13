# CodeLouisville.DataLayer.Sample

this project is meant to demonstrate how to use the **[CodeLouisville.DataLayer](https://github.com/kcwms/Codelouisville.DataLayer)** project

my goal is to demonstrate 

1. [polymorphism](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism)

1. [inheritance](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance)


## To use this sample
1. download/clone this repo along with **[CodeLouisville.DataLayer](https://github.com/kcwms/Codelouisville.DataLayer)** project
1. edit the Sample.csproj file to point to the *.csporj file in the CodeLouisville.DataLayer project.
    1. if you place both projects in the same folder, this _should_ not be required
1. run this project


## Things to spark discussions... and questions

Notice that we have only defined an interface in the Main method... why?

Notice that you are using a third party assembly in your program... how does this work?

Notice that depending on the second that you run the code, you are either using the JsonDataStore or XmlDataStore classes to persists data to the flat file "database" and while those two classes rely on logic defined in the BaseData class, they actually save data in different forms... when would you want to do this?

Notice how you can use the System.Linq namespace to manipulate data in the retunred collection... is this being done in the "database" or in your code and what difference does that make?

Notice the use of the Generic Type placeholder **T**... what type of class is T?