

class Generic_Delegate 
{
   public delegate bool Filter<in T>(T nb);

    public static void  Display<T>(IEnumerable<T> collection, Filter<T> filter)
    {
        foreach (T item in collection)
        {
            if (filter(item))
                System.Console.WriteLine($"* * * * {item} => Is Even * * * *");
        }
    }
}


class ActionsInCs
{

    /*
        This is work as well you can pass it like this  : public static void  Display<T>(IEnumerable<T> collection, Filter<T> filter)

            but he a build-in c# delegate a 3 type :

                - Action<T> : points to a method that TAKES T and RETURNS void.
                - Func<T1,...,TResult> : points to a method that RETURNS TResult; the last generic type is the return type.
                - Predicate<T> : points to a method that TAKES T and RETURNS bool (i.e., Func<T, bool>).
                - You can assign a method group (like Print/Add/IsEven) to a compatible delegate type.

   */


    public static void  Display<T>(IEnumerable<T> collection, Predicate<T> filter, Action action)
    {
        action();


        foreach (T item in collection)
        {
            if (filter(item))
                System.Console.WriteLine($" - {item} ");
        }
    }

    
}


class Program
{
    static void Main()
    {
        
        // IEnumerable<int> is read-only: you can iterate but not modify directly.

        IEnumerable<int> nums = new int[] { 2, 5, 6, 7, 9, 1, 3, 4, 8 };


        Generic_Delegate.Display(nums, n => n % 2 == 0);

        System.Console.WriteLine("\n\n---  Action   ---\n\n");


        ActionsInCs.Display(nums, n => n < 5, () => System.Console.WriteLine("Numbers Less Than 5"));
        ActionsInCs.Display(nums, n => n > 5, () => System.Console.WriteLine("Numbers Grater Than 5"));
        ActionsInCs.Display(nums, n => n % 2 != 0, () => System.Console.WriteLine("odd Numbers"));


        System.Console.WriteLine("Actions Method Example : ");

        Action<string> action = Print;
        action("Hej !");

        Func<int, int, int> addD = Add;
        Console.WriteLine(addD(2, 2));

        Predicate<int> predicate = IsEven;
        Console.WriteLine(predicate(3));


    }


    static void Print(string name) => Console.WriteLine(name);
    static int Add(int n1, int n2) => n1 + n2;
    static bool IsEven(int n) => n % 2 == 0;
    
}
