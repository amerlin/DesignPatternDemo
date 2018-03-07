using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Enum;

namespace Demo.Creational.Factory_Method.Concrete
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
