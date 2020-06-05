using System;
using System.Collections.Generic;

namespace Vehicle_inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }



            // Cessna mx410 = new Cessna();
            // mx410.MainColor = "White";
            // mx410.MaximumOccupancy = "2";

            // Ram dakota = new Ram();
            // dakota.MainColor = "Red";
            // dakota.MaximumOccupancy = "6";

            // Tesla modelS = new Tesla();
            // modelS.MainColor = "Blue";
            // modelS.MaximumOccupancy = "5";

            // Zero fxs = new Zero();
            // fxs.MainColor = "Green";
            // fxs.MaximumOccupancy = "6";

            // mx410.Drive();
            // mx410.Turn("Right");
            // mx410.Stop();

            // dakota.Drive();
            // dakota.Turn("Left");
            // dakota.Stop();

            // modelS.Drive();
            // modelS.Turn("Right");
            // modelS.Stop();

            // fxs.Drive();
            // fxs.Turn("Left");
            // fxs.Stop();
        }
    }
}
