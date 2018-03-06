using Demo.NoPattern.Abstract;
using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Concrete
{
    public class Pickup: AbstractVan
    {
        public Pickup(IEngine engine) : base(engine)
        {
        }

        public Pickup(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
