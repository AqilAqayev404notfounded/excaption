
namespace excaption;

public class Employee : IPerson
{
    public static int _id;
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public string ShowInfo()
    {
        return $"{Name},{Age},{Salary}";
    }

    public Employee(string name,int age,int salary)
    {
        _id++;
        Id = _id;
        Name = name;
        Age = age; 
        Salary = salary;

    }
    public override string ToString()
    {
        return ShowInfo();
    }

    //public static implicit operator Employee(int v)
    //{
    //    throw new NotImplementedException();
    //}
}
