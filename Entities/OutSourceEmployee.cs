namespace Exercicio_POO_16_Employee_Heranaca_Polimorfismo.Entities
{
    class OutSourceEmployee : Employee
    {
        public double AdicionalCharge { get; set; }

        public OutSourceEmployee() { }
        public OutSourceEmployee(string name, int hour, double veluePerHours, double adicionalCharge)
            : base(name, hour, veluePerHours)
        {
            AdicionalCharge = adicionalCharge;
        }

        public override double Payment() => base.Payment() + 1.1 * AdicionalCharge;
    }
}
