# CodeLouisville.DataLayer.Sample

this project is meant to demonstrate how to use the **CodeLouisville.DataLayer** project

my goal is to demonstrate 

1. [polymorphism](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism)

1. [inheritance](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance)


## To use this sample
1. download/clone this repo along with **CodeLouisville.DataLayer** project
1. edit the Sample.csproj file to point to the *.csporj file in the CodeLouisville.DataLayer project.
    1. if you place both projects in the same folder, this will not be required
1. run this project

Notice that you are using an interface in the Main method 

Notice that you are using a third party assembly in your program

Notice that depending on the second that you run the code, you are either using the JsonDataStore or XmlDataStore classes to persists data to the flat file "database" and those two classes rely on logic defined in the BaseData class

Notice that the BaseData class does most of the work, while you only need to specifiy how you want the data persisted into the text file: you are not concerned with how that data get's persisted to disk

Notice how you can use the System.Linq namespace to manipulate data in the retunred collection.

Notice the use of the Generic Type placeholder **T**