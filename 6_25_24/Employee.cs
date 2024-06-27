namespace _6_25_24;

internal class Employee:IPerson
{
    private int id;
    private string name;
    private byte age;
    public int Id { get => id; set { } }
    public int Salary { get; set; }
    public string Name { get => name; set => name = value; }
    public byte Age { get => age; set => age = value; }

    public string ShowInfo()
    {
        return $"{Name} {Age} {Salary}";
    }
    public override string ToString()
    {
        return ShowInfo();
    }
    public Employee(string name,byte age, int salary)
    {
        Id = ++id;
        Name = name;
        Age = age;
        Salary = salary;
    }

}
