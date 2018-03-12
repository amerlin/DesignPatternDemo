using System;
using Demo.Creational.Prototype.Enum;

namespace Demo.Creational.Prototype.Interface
{
    public interface IVehicle: ICloneable
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
    }
}
