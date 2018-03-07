using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Enum;
using Demo.Creational.Factory_Method.Interface;

namespace Demo.Creational.Factory_Method.Concrete
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
