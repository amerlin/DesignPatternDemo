using Demo.Creational.Factory_Method.Abstract;
using Demo.Creational.Factory_Method.Enum;
using Demo.Creational.Factory_Method.Interface;

namespace Demo.Creational.Factory_Method.Concrete
{
    public class BoxVan: AbstractVan
    {
        public BoxVan(IEngine engine) : base(engine)
        {
        }

        public BoxVan(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}
