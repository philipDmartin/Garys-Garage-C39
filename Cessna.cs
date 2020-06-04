using System;
using System.Collections.Generic;

namespace Vehicle_inheritance
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flys past. Zooooomm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna will turn {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Cessna will roll to a Stop");
        }
    }
}
