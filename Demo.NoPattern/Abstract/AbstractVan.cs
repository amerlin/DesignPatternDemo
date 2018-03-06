using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Abstract
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
