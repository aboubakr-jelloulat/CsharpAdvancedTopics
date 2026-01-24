
public static class foo
{

    public static void Stock_OnPriceChanged(Stock stock, decimal OldPrice)
    {
        string state = "";

        if (OldPrice < stock.Price)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            state = "UP";
        }
        else if (OldPrice > stock.Price)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            state = "Down";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            state = "STILL";
        }
        Console.WriteLine($"{stock.Name} : {stock.Price} - {state}");
    }

}

