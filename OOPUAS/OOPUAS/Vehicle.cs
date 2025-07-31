using System;
using System.Collections.Generic;

namespace OOPUAS
{
    abstract class Vehicle
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Vehicle(string brand)
        {
            this.brand = brand;
        }

        public abstract void StartEngine();
    }

}
