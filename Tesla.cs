using System;

namespace Vehicle_inheritance
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. MMmmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla will turn {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Tesla will Stop");
        }
    }
}
