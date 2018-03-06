using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Abstract
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
