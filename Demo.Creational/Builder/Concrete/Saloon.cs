using Demo.Creational.Builder.Abstract;
using Demo.Creational.Builder.Enum;
using Demo.Creational.Builder.Interface;

namespace Demo.Creational.Builder.Concrete
{
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine) : base(engine)
        {
        }

        public Saloon(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
