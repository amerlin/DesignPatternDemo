using Demo.NoPattern.Abstract;
using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Concrete
{
    public class Sport: AbstractCar
    {
        public Sport(IEngine engine) : base(engine)
        {
        }

        public Sport(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
