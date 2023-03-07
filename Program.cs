using Exercicio_POO_16_Employee_Heranaca_Polimorfismo.Entities;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        Console.Write("Enter the number of employees: ");
        int numberEmployees = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numberEmployees; i++)
        {
            Console.WriteLine($"Employee #{i} data: ");
            Console.Write("Outsourced (y/n)? ");
            char outsourced = char.Parse(Console.ReadLine());

            if (outsourced == 'y')
                employees.Add(CreateOutsourcedEmployee());
            else
                employees.Add(CreateEmployee());
        }
        Console.WriteLine();
        Console.WriteLine("PAYMENTS: ");
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    private static OutSourceEmployee CreateOutsourcedEmployee()
    {
        Employee employed = CreateEmployee();
        Console.Write("Additional charge: ");
        double aditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        return new OutSourceEmployee(employed.Name, employed.Hour, employed.VeluePerHours, aditionalCharge);
    }

    private static Employee CreateEmployee()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hour: ");
        double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        return new Employee(name, hours, valueHour);
    }
}