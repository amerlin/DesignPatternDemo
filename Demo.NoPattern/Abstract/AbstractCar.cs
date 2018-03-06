using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Abstract
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
