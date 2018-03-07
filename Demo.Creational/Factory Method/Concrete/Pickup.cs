using Demo.Creational.Factory_Method.Interface;
using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Enum;

namespace Demo.Creational.Factory_Method.Concrete
{
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine) : base(engine)
        {
        }

        public Pickup(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
