using Demo.Creational.Builder.Abstract;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Concrete
{
    public class CarDirector: VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            builder.BuildBoot();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
