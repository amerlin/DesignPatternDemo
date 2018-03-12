using Demo.Creational.Prototype.Enum;
using Demo.Creational.Prototype.Interface;

namespace Demo.Creational.Prototype.Abstract
{
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine) : base(engine)
        {
        }

        public AbstractCar(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
