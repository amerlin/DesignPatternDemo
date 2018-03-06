using Demo.Creational.Builder.Enum;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Abstract
{
    public abstract class AbstractCar: AbstractVehicle
    {
        protected AbstractCar(IEngine engine) : base(engine)
        {
        }

        protected AbstractCar(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
