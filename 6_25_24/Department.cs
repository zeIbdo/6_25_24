using _6_25_24.Exceptions;

namespace _6_25_24;

internal class Department
{
    public string Name { get; set; }
    public int Limit { get; set; }
    Employee[] employees  = new Employee[0];
    public void Add(Employee employee)
    {
        if (employees.Length == Limit)
        {
            throw new CapacityLimitException("Limite catilib");
        }
        Array.Resize(ref employees, employees.Length+1);
        employees[employees.Length-1] = employee;
    }
    public Employee this[int index]
    {
        get { return employees[index]; }
        set { employees[index] = value; }
    }
    public Department(string name, int limit)
    {
        Name = name;
        Limit = limit;
    }
}
