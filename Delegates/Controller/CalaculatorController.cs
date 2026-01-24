
public static class Calculator
{
    public delegate int OpDelegate(int num1, int num2);

    public static void Cal(int num1, int num2, OpDelegate del)
    
    => System.Console.WriteLine(del(num1, num2));
    
}
