using Exercicio_POO_16_Employee_Heranaca_Polimorfismo.Entities;
using System.Globalization;

List<Employee> list = new List<Employee>();
Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (ch == 'y')
    {
        Console.Write("Additional charge: ");
        double aditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new OutSourceEmployee(name, hours, valueHour, aditionalCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, valueHour));
    }

    Console.WriteLine();
    Console.WriteLine("PAYMENTS: ");
    foreach (Employee emp in list)
    {
        Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
    }
}

