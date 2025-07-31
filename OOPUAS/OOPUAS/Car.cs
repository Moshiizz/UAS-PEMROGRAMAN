using System;
using System.Collections.Generic;

namespace OOPUAS
{
    class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }

        public override void StartEngine()
        {
            Console.WriteLine($"Mobil {Brand} menghidupkan mesin: Vroom Vroom!");
        }
    }

}
