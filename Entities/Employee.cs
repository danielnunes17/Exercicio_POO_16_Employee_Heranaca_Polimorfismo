namespace Exercicio_POO_16_Employee_Heranaca_Polimorfismo.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hour { get; set; }
        public double VeluePerHours { get; set; }

        public Employee(string name, int hour, double veluePerHours)
        {
            Name = name;
            Hour = hour;
            VeluePerHours = veluePerHours;
        }

        public virtual double Payment() => VeluePerHours * Hour;
    }
}
