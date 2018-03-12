using Demo.Creational.Prototype.Interface;
using Demo.Creational.Prototype.Abstract;
using Demo.Creational.Prototype.Enum;

namespace Demo.Creational.Prototype.Concrete
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
