
namespace excaption;

internal class Employee : IPerson
{
    public static int _id;
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public string ShowInfo()
    {
        return $"{Name},{Age}";
    }

    public Employee(Employee employee ,string name,string age,int salary)
    {
        _id++;
        Id = _id;

    }
    public override string ToString()
    {
        return ShowInfo();
    }

    public static implicit operator Employee(int v)
    {
        throw new NotImplementedException();
    }
}
