using System;

namespace Vehicle_inheritance
{
    public class Ram : Vehicle, IGas  // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. RRrrrrrummbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram will turn {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Ram will Stop");
        }
    }
}
