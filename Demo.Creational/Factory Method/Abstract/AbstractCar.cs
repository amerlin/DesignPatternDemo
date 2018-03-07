using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Enum;

namespace Demo.Creational.Factory_Method.Abstract
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
