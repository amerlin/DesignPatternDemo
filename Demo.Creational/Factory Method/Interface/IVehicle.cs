using Demo.Creational.Factory_Method.Enum;
using Demo.Creational.Factory_Method.Interface;

namespace Demo.Creational.Factory_Method.Interface
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
    }
}
