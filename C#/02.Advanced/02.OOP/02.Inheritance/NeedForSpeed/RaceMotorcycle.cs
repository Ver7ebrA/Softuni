﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            base.DefaultFuelConsumption = 8d;
            base.FuelConsumption = base.DefaultFuelConsumption;
        }
    }
}
