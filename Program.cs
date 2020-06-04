using System;
using System.Collections.Generic;

namespace Vehicle_inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cessna mx410 = new Cessna();
            mx410.MainColor = "White";
            mx410.MaximumOccupancy = "2";

            Ram dakota = new Ram();
            dakota.MainColor = "Red";
            dakota.MaximumOccupancy = "6";

            Tesla modelS = new Tesla();
            modelS.MainColor = "Blue";
            modelS.MaximumOccupancy = "5";

            Zero fxs = new Zero();
            fxs.MainColor = "Green";
            fxs.MaximumOccupancy = "6";

            mx410.Drive();
            mx410.Turn("Right");
            mx410.Stop();

            dakota.Drive();
            dakota.Turn("Left");
            dakota.Stop();

            modelS.Drive();
            modelS.Turn("Right");
            modelS.Stop();

            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();
        }
    }
}
