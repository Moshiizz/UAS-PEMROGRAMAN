using System;
using System.Collections.Generic;

namespace OOPUAS
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string brand) : base(brand) { }

        public override void StartEngine()
        {
            Console.WriteLine($"Motor {Brand} menghidupkan mesin: Brrr Brrr!");
        }
    }
}
