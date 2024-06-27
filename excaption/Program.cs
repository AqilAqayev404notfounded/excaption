using excaption;

Department department = new Department("Aqil",10);
Employee employee = new Employee("Aqil", 10 , 1000);
department.AddEmployee(employee);
foreach (var item in department.employees)
{
    Console.WriteLine(item);
}

