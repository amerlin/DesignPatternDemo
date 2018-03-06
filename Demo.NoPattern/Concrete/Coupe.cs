using Demo.NoPattern.Abstract;
using Demo.NoPattern.Enum;
using Demo.NoPattern.Interface;

namespace Demo.NoPattern.Concrete
{
    public class Coupe: AbstractCar
    {
        public Coupe(IEngine engine) : base(engine)
        {
        }

        public Coupe(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
