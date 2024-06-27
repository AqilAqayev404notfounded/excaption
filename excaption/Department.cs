namespace excaption;

public class Department
{
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public Employee[] employees;
    public Department(string name, int employeeLimit)
    {
        Name = name;
        EmployeeLimit = employeeLimit;
        
        employees = new Employee[0];


    }
    public void AddEmployee(Employee employee)
    {
        if (employees.Length >= EmployeeLimit)
            throw new CostumExcaption("limitden kenara cixmisiz");

        Array.Resize( ref employees, employees.Length + 1);
        employees[employees.Length - 1] = employee;


    }
    public Employee this[int i]
    {
        get { return employees[i]; }
        set { employees[i] = value; }
    }


}
