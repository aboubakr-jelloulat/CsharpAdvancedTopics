

/*
    * Extension methods allow you to add new methods to existing types without modifying or inheriting from them. An extension method lets you add a new method to an existing class
        without modifying the class and without inheritance

    * The 3 strict rules An extension method must:

        Be inside a static class

        Be a static method

        The first parameter must start with this

*/

string name = "aboubakr";


Console.WriteLine("To Capital First Letter : " + name.ToCapitalFirstLetter());

string firstName = "Aboubaker";
string lastName  = "Jelloulat";

string fullName = firstName.ConcatWith(lastName, " * ");
System.Console.WriteLine($"ConcatWith : {fullName}");

int x = 41;
System.Console.WriteLine($"Add : {x.add(1)}");


