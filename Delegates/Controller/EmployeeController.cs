public static class EmployeeController
{
    public delegate bool SalaryCondition(Employee e);

    public static void Filter(Employee[] employees, string title, SalaryCondition filter)
    {
        Console.WriteLine(title);

        foreach (var e in employees)
        {
            if (filter(e))
                Console.WriteLine(e);
        }

        Console.WriteLine();
    }
}
