using System;

namespace Vehicle_inheritance
{
    public interface IGas
    {
        double FuelCapacity { get; set; }
        double CurrentTankPercentage { get; set; }
        void RefuelTank()
        {
            // method definition omitted
        }
    }
}
