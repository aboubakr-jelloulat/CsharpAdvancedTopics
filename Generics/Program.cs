

// ********  [ Generic Constraints  : ]  ********


/*
    GENERIC CONSTRAINTS IN C#

            Generic constraints are rules applied to type parameters in generic classes or methods,
            specifying what kinds of types can be used for the type parameter.

            TYPES OF GENERIC CONSTRAINTS:

            1. where T : struct
               - T must be a value type (e.g., int, double, DateTime)
       
            2. where T : class
               - T must be a reference type (e.g., string, custom classes)
       
            3. where T : new()
               - T must have a public parameterless constructor, allowing "new T()" inside the generic class/method
       
            4. where T : BaseClass
               - T must inherit from the specified base class
       
            5. where T : InterfaceName
               - T must implement the specified interface
       
            6. Multiple constraints
               - You can combine constraints, e.g.:
                 where T : class, IComparable<T>, new()
         
            NOTES:
            - You cannot constrain T to a specific type like int or string directly.
            - Constraints provide type safety, better performance, and clear rules for generic usage.
*/

public class foo<T>
{
    private T data;

    public foo(T value)
    {
        data = value;
    }


    public  T getData()
    {
        return data ;
    }


    public void display()
    {
        System.Console.WriteLine(data);
    }
    
}


class Program
{
    
    static void Main()
    {
        var f1 =  new foo<string>("hej");

        f1.display();
        System.Console.WriteLine($"String Data : {f1.getData()}\n\n");

        var f2 = new foo<int> (1337);

        f2.display();
        System.Console.WriteLine($"int Data : {f2.getData()}");
        
    }
}

