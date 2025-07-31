using System;
using System.Collections.Generic;

namespace OOPUAS
{
    interface IVehicle
    {
        string Brand { get; set; }
        void StartEngine();
    }
}
