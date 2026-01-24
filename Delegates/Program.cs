
var employees = new Employee[]
{
    new Employee { Name = "Diana", Department = "Marketing", Salary = 1100m},

    new Employee { Name = "Charlie", Department = "Finance", Salary = 700m},

    new Employee { Name = "Bob", Department = "HR", Salary = 420m}

};


EmployeeController.Filter(employees, "salary greater than 1000", e => e.Salary > 1000);

EmployeeController.Filter(employees, "salary between 500 and 1000", e => e.Salary >= 500 && e.Salary <= 1000);

EmployeeController.Filter(employees, "salary less than 500", e => e.Salary < 500);


Calculator.Cal(10, 10, (a, b) => a + b);
Calculator.Cal(5, 2, (a, b) => a * b);
Calculator.Cal(10, 2, (a, b) => a / b);