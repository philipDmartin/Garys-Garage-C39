using System;

namespace Vehicle_inheritance
{
    public interface IName
    {
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}
