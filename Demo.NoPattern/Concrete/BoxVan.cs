using Demo.NoPattern.Abstract;
using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Concrete
{
    public abstract class BoxVan: AbstractVan
    {
        protected BoxVan(IEngine engine) : base(engine)
        {
        }

        protected BoxVan(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
