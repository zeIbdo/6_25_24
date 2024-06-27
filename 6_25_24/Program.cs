using _6_25_24.Exceptions;

namespace _6_25_24;

internal class Program
{
    static void Main(string[] args)
    {

        Department department = new Department("IT", 2);

        try
        {
            Employee employee1 = new Employee("John Doe", 30, 50000);
            Employee employee2 = new Employee("Jane Smith", 28, 55000);
            Employee employee3 = new Employee("Alice Johnson", 32, 60000);

            department.Add(employee1);
            Console.WriteLine("Added: " + employee1);

            department.Add(employee2);
            Console.WriteLine("Added: " + employee2);

            department.Add(employee3);
            Console.WriteLine("Added: " + employee3);
        }
        catch (CapacityLimitException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occurred.");
        }
        finally
        {
        Console.WriteLine("Program has ended.");
        }

    }
}






