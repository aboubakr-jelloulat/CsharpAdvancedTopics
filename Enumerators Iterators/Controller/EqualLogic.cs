class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Salary { get; set; }

    public string Department { get; set; }

    public override string ToString()
    {
        return $"Employee: {Id}, {Name}, {Department}, {Salary:C}";
    }

    // Override Equals to compare content, not just references
    public override bool Equals(object obj)
    {
        if (obj is null || !(obj is Employee))
            return false;

        var other = obj as Employee;

        return this.Id == other.Id &&
                   this.Name == other.Name &&
                   this.Salary == other.Salary &&
                   this.Department == other.Department;
        }
    }

public class EqualLogic
{
    
    public static void Equal()
    {
        Employee e1 = new Employee { Id = 100, Name = "Sander", Department = "IT", Salary = 1500 };
        Employee e2 = new Employee { Id = 100, Name = "Sander", Department = "IT", Salary = 1500 };

        Console.WriteLine(e1 == e2); // compare the reference not the values only strings  

        Employee e3 = e1;
        Console.WriteLine(e3 == e1);

        string s1 = "hej", s2 = "hej";
        System.Console.WriteLine(s1 == s2);

        System.Console.WriteLine("\nEqual : \n");

        System.Console.WriteLine(e1.Equals(e2)); // Equal is compare the content but by default is compare the refrences so you must ovveride it 

    }

}

