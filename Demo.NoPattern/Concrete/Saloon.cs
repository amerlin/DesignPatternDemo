using Demo.NoPattern.Abstract;
using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Concrete
{
    public class Saloon: AbstractCar
    {
        public Saloon(IEngine engine) : base(engine)
        {
        }

        public Saloon(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
