using System;

namespace Vehicle_inheritance
{
    public class Zero : Vehicle, IElectric  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. BrummmBrummmMmMmMm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero will turn {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Zero will Stop");
        }
    }
}
