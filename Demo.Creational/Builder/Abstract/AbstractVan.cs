using Demo.Creational.Builder.Enum;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Abstract
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
