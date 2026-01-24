
public class Employee
{
    public string Name;

    public string Department;

    public decimal Salary;


    public override string ToString()
    {
        return $"Name: {Name}, Department: {Department}, Salary: {Salary:C}";
    }
    
}

