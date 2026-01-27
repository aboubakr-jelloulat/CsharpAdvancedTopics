


public class MyCustomException : Exception
{
    public MyCustomException() {}

    public MyCustomException(string message) : base(message) {}

    public MyCustomException(string message, Exception innerException)
        : base (message, innerException)
    {
    }
    
}

public class BusinessRuleException : Exception
{
    public int ErrorCode { get; }

    public BusinessRuleException(string message, int errorCode)
        : base(message)
    {
        ErrorCode = errorCode;
    }
}


class Program
{
    static void Main()
    {
        System.Console.WriteLine("\nBuild-in Exception : ");
        try
        {
            int n1 = 5, n2 = 0;

            if (n2 == 0)
                throw new DivideByZeroException("hej !! Division by zero!");

            int sum = n1 / n2;

            System.Console.WriteLine("sum : " + sum);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("DivideByZeroException: " + ex.Message);
        }



        System.Console.WriteLine("\n\nMy Custom Exception : \n");
        try
        {
            throw new MyCustomException("Test error");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught MyCustomException : " + ex.Message);
        }


        System.Console.WriteLine("\n\nBusiness Exception : ");
        try
        {
            throw new BusinessRuleException("Order amount is too low", 1001);
        }
        catch (BusinessRuleException ex)
        {
            Console.WriteLine("Caught MyCustomException : " + ex.Message);
        }


    }
    
}