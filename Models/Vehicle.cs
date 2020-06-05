using System;

namespace Vehicle_inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine("Turn");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
