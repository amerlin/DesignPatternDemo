using Demo.Creational.Builder.Enum;

namespace Demo.Creational.Builder.Interface
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
    }
}
