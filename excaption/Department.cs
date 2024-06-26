namespace excaption;

internal class Department
{
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public Employee[] employees;
    private int employeeCount;
    public Department(string name, int employeeLimit)
    {
        Name = name;
        EmployeeLimit = employeeLimit;
        
        employees = new Employee[employeeLimit];
        employeeCount = 0;


    }
    public void AddEmployee(Employee employee)
    {
        Array.Resize( ref employees, employees.Length + 1);
        employees[employees.Length - 1] = employee;
        if (employeeCount >= EmployeeLimit)
            throw new CostumExcaption("limitden kenara cixmisiz");


    }
    public Employee this[int i]
    {
        get { return employees[i]; }
        set { employees[i] = value; }
    }


}
