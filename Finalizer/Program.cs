

class Person
{
    private string Name { get; set; }

    public Person(string name)
    {
        Name = name;

        System.Console.WriteLine("This is a Constructor");
    }

    public Person() => Console.WriteLine("Default Constructor");



    public static void MakeSomeGarbage()
    {
        Version v;

        for (int i = 0; i < 1000; i++) 
            v = new Version();
    
    
    }

    ~Person() => Console.WriteLine("This is a Destructor");

}




class Program
{
    public static void Main()
    {
        
        Person.MakeSomeGarbage();

        Console.WriteLine($"Memory Used Before Collection {GC.GetTotalMemory(false):N0}");
        
        GC.Collect(); // Explicit Cleaning
        
        Console.WriteLine($"Memory Used Before Collection {GC.GetTotalMemory(true):N0}");



    }
    
}

