using Demo.Creational.Factory_Method.Enum;
using Demo.Creational.Factory_Method.Interface;

namespace Demo.Creational.Factory_Method.Abstract
{
    public abstract class AbstractVan: AbstractCar
    {
        protected AbstractVan(IEngine engine) : base(engine)
        {
        }

        protected AbstractVan(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
