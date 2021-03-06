﻿using Demo.Creational.Builder.Abstract;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Concrete
{
    public class VanDirector: VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
