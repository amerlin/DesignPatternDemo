using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Enum;

namespace Demo.Creational.Factory_Method.Concrete
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
